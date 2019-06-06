namespace CodedUITestProject1
{
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
    using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;
    using System;
    using System.Collections.Generic;
    using System.CodeDom.Compiler;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    using System.Drawing;
    using System.Windows.Input;
    using System.Text.RegularExpressions;
    using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;


    public partial class UIMap
    {

        /// <summary>
        /// SimpleAppTest - Use 'SimpleAppTestParams' to pass parameters into this method.
        /// </summary>
        public void ModifiedSimpleAppTest()
        {
            #region Variable Declarations
            WpfButton uIStartButton = this.UIMainWindowWindow.UIStartButton;
            WinWindow uIMainWindowWindow1 = this.UIMainWindowWindow1;
            WpfCheckBox uICheckBoxCheckBox = this.UIMainWindowWindow.UICheckBoxCheckBox;
            WinButton uICloseButton = this.UIMainWindowWindow1.UICloseButton;
            #endregion

            // Launch '%USERPROFILE%\Documents\DIPLOMA\C#-WED\WK11-AdvUnitTest\AdvUnitTest\SimpleWPFApp\bin\Debug\SimpleWPFApp.exe'
            ApplicationUnderTest uIMainWindowWindow = ApplicationUnderTest.Launch(this.SimpleAppTestParams.UIMainWindowWindowExePath, this.SimpleAppTestParams.UIMainWindowWindowAlternateExePath);

            // Click 'Start' button
            Mouse.Click(uIStartButton, new Point(59, 2));

            // Maximize window 'MainWindow'
            uIMainWindowWindow1.Maximized = this.SimpleAppTestParams.UIMainWindowWindow1Maximized;

            uICheckBoxCheckBox.WaitForControlEnabled();
            // Select 'CheckBox' check box
            uICheckBoxCheckBox.Checked = this.SimpleAppTestParams.UICheckBoxCheckBoxChecked;

            // Restore window 'MainWindow'
            uIMainWindowWindow1.Restored = this.SimpleAppTestParams.UIMainWindowWindow1Restored;

            // Click 'Close' button
            Mouse.Click(uICloseButton, new Point(33, 16));
        }

        public virtual SimpleAppTestParams SimpleAppTestParams
        {
            get
            {
                if ((this.mSimpleAppTestParams == null))
                {
                    this.mSimpleAppTestParams = new SimpleAppTestParams();
                }
                return this.mSimpleAppTestParams;
            }
        }

        private SimpleAppTestParams mSimpleAppTestParams;
    }
    /// <summary>
    /// Parameters to be passed into 'SimpleAppTest'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class SimpleAppTestParams
    {

        #region Fields
        /// <summary>
        /// Launch '%USERPROFILE%\Documents\DIPLOMA\C#-WED\WK11-AdvUnitTest\AdvUnitTest\SimpleWPFApp\bin\Debug\SimpleWPFApp.exe'
        /// </summary>
        public string UIMainWindowWindowExePath = "C:\\Users\\madhu\\Documents\\DIPLOMA\\C#-WED\\WK11-AdvUnitTest\\AdvUnitTest\\SimpleWPFApp" +
            "\\bin\\Debug\\SimpleWPFApp.exe";

        /// <summary>
        /// Launch '%USERPROFILE%\Documents\DIPLOMA\C#-WED\WK11-AdvUnitTest\AdvUnitTest\SimpleWPFApp\bin\Debug\SimpleWPFApp.exe'
        /// </summary>
        public string UIMainWindowWindowAlternateExePath = "%USERPROFILE%\\Documents\\DIPLOMA\\C#-WED\\WK11-AdvUnitTest\\AdvUnitTest\\SimpleWPFApp\\" +
            "bin\\Debug\\SimpleWPFApp.exe";

        /// <summary>
        /// Maximize window 'MainWindow'
        /// </summary>
        public bool UIMainWindowWindow1Maximized = true;

        /// <summary>
        /// Select 'CheckBox' check box
        /// </summary>
        public bool UICheckBoxCheckBoxChecked = true;

        /// <summary>
        /// Restore window 'MainWindow'
        /// </summary>
        public bool UIMainWindowWindow1Restored = true;
        #endregion
    }
}
