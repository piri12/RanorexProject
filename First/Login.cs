﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace First
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Login recording.
    /// </summary>
    [TestModule("4ee6b740-ed8f-4ed5-b5ac-086aa8bdd384", ModuleType.Recording, 1)]
    public partial class Login : ITestModule
    {
        /// <summary>
        /// Holds an instance of the FirstRepository repository.
        /// </summary>
        public static FirstRepository repo = FirstRepository.Instance;

        static Login instance = new Login();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Login()
        {
            Username = "piri";
            Password = "Priya{LShiftKey down}@{LShiftKey up}94";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Login Instance
        {
            get { return instance; }
        }

#region Variables

        string _Username;

        /// <summary>
        /// Gets or sets the value of variable Username.
        /// </summary>
        [TestVariable("91f2aad9-bd66-4c1b-9ebb-11259d69eb51")]
        public string Username
        {
            get { return _Username; }
            set { _Username = value; }
        }

        string _Password;

        /// <summary>
        /// Gets or sets the value of variable Password.
        /// </summary>
        [TestVariable("48152fdd-9d29-4638-ab06-2448eee42bb8")]
        public string Password
        {
            get { return _Password; }
            set { _Password = value; }
        }

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.0")]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.0")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Website", "Opening web site 'http://newtours.demoaut.com/' with browser 'chrome' in normal mode.", new RecordItemIndex(0));
            Host.Current.OpenBrowser("http://newtours.demoaut.com/", "chrome", "", false, false, false, false, false);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'WelcomeMercuryTours.SomeTableTag.UserName' at 34;9.", repo.WelcomeMercuryTours.SomeTableTag.UserNameInfo, new RecordItemIndex(1));
            repo.WelcomeMercuryTours.SomeTableTag.UserName.DoubleClick("34;9");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WelcomeMercuryTours.SomeTableTag.UserName' at 39;10.", repo.WelcomeMercuryTours.SomeTableTag.UserNameInfo, new RecordItemIndex(2));
            repo.WelcomeMercuryTours.SomeTableTag.UserName.Click("39;10");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Username' with focus on 'WelcomeMercuryTours.SomeTableTag.UserName'.", repo.WelcomeMercuryTours.SomeTableTag.UserNameInfo, new RecordItemIndex(3));
            repo.WelcomeMercuryTours.SomeTableTag.UserName.PressKeys(Username);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'WelcomeMercuryTours.SomeTableTag.Password' at 28;6.", repo.WelcomeMercuryTours.SomeTableTag.PasswordInfo, new RecordItemIndex(4));
            repo.WelcomeMercuryTours.SomeTableTag.Password.DoubleClick("28;6");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Password' with focus on 'WelcomeMercuryTours.SomeTableTag.Password'.", repo.WelcomeMercuryTours.SomeTableTag.PasswordInfo, new RecordItemIndex(5));
            repo.WelcomeMercuryTours.SomeTableTag.Password.PressKeys(Password);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WelcomeMercuryTours.SomeTableTag.Login' at 11;8.", repo.WelcomeMercuryTours.SomeTableTag.LoginInfo, new RecordItemIndex(6));
            repo.WelcomeMercuryTours.SomeTableTag.Login.Click("11;8");
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
