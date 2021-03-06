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
    ///The Recording1 recording.
    /// </summary>
    [TestModule("1455deac-0cad-4f98-b08a-7644c5d5f0c9", ModuleType.Recording, 1)]
    public partial class Recording1 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the FirstRepository repository.
        /// </summary>
        public static FirstRepository repo = FirstRepository.Instance;

        static Recording1 instance = new Recording1();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Recording1()
        {
            Username = "Priyanka";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Recording1 Instance
        {
            get { return instance; }
        }

#region Variables

        string _Username;

        /// <summary>
        /// Gets or sets the value of variable Username.
        /// </summary>
        [TestVariable("787b726d-7479-4ae7-afaa-b305fd929a02")]
        public string Username
        {
            get { return _Username; }
            set { _Username = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FindAFlightMercuryTours.Profile' at Center.", repo.FindAFlightMercuryTours.ProfileInfo, new RecordItemIndex(0));
            repo.FindAFlightMercuryTours.Profile.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RegisterMercuryTours.FirstName' at Center.", repo.RegisterMercuryTours.FirstNameInfo, new RecordItemIndex(1));
            repo.RegisterMercuryTours.FirstName.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Priyanka' with focus on 'RegisterMercuryTours.FirstName'.", repo.RegisterMercuryTours.FirstNameInfo, new RecordItemIndex(2));
            repo.RegisterMercuryTours.FirstName.PressKeys("Priyanka");
            Delay.Milliseconds(0);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating Exists on item 'RegisterMercuryTours.FirstName'.", repo.RegisterMercuryTours.FirstNameInfo, new RecordItemIndex(3));
                Validate.Exists(repo.RegisterMercuryTours.FirstNameInfo, null, false);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(3)); }
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Tayade' with focus on 'RegisterMercuryTours.SomeTableTag.LastName'.", repo.RegisterMercuryTours.SomeTableTag.LastNameInfo, new RecordItemIndex(4));
            repo.RegisterMercuryTours.SomeTableTag.LastName.PressKeys("Tayade");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RegisterMercuryTours.SomeTableTag.Phone' at Center.", repo.RegisterMercuryTours.SomeTableTag.PhoneInfo, new RecordItemIndex(5));
            repo.RegisterMercuryTours.SomeTableTag.Phone.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '9067452430' with focus on 'RegisterMercuryTours.SomeTableTag.Phone'.", repo.RegisterMercuryTours.SomeTableTag.PhoneInfo, new RecordItemIndex(6));
            repo.RegisterMercuryTours.SomeTableTag.Phone.PressKeys("9067452430");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RegisterMercuryTours.SomeTableTag.Email' at Center.", repo.RegisterMercuryTours.SomeTableTag.EmailInfo, new RecordItemIndex(7));
            repo.RegisterMercuryTours.SomeTableTag.Email.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'priyankatayade5@gmail.com' with focus on 'RegisterMercuryTours.SomeTableTag.Email'.", repo.RegisterMercuryTours.SomeTableTag.EmailInfo, new RecordItemIndex(8));
            repo.RegisterMercuryTours.SomeTableTag.Email.PressKeys("priyankatayade5@gmail.com");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RegisterMercuryTours.SomeTableTag.Address1' at Center.", repo.RegisterMercuryTours.SomeTableTag.Address1Info, new RecordItemIndex(9));
            repo.RegisterMercuryTours.SomeTableTag.Address1.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Pune' with focus on 'RegisterMercuryTours.SomeTableTag.Address1'.", repo.RegisterMercuryTours.SomeTableTag.Address1Info, new RecordItemIndex(10));
            repo.RegisterMercuryTours.SomeTableTag.Address1.PressKeys("Pune");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RegisterMercuryTours.SomeTableTag.City' at Center.", repo.RegisterMercuryTours.SomeTableTag.CityInfo, new RecordItemIndex(11));
            repo.RegisterMercuryTours.SomeTableTag.City.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Pune' with focus on 'RegisterMercuryTours.SomeTableTag.City'.", repo.RegisterMercuryTours.SomeTableTag.CityInfo, new RecordItemIndex(12));
            repo.RegisterMercuryTours.SomeTableTag.City.PressKeys("Pune");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RegisterMercuryTours.SomeTableTag.State' at Center.", repo.RegisterMercuryTours.SomeTableTag.StateInfo, new RecordItemIndex(13));
            repo.RegisterMercuryTours.SomeTableTag.State.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Maharashtra' with focus on 'RegisterMercuryTours.SomeTableTag.State'.", repo.RegisterMercuryTours.SomeTableTag.StateInfo, new RecordItemIndex(14));
            repo.RegisterMercuryTours.SomeTableTag.State.PressKeys("Maharashtra");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Move item 'RegisterMercuryTours.SomeTableTag.PostalCode' at Center.", repo.RegisterMercuryTours.SomeTableTag.PostalCodeInfo, new RecordItemIndex(15));
            repo.RegisterMercuryTours.SomeTableTag.PostalCode.MoveTo();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '411057' with focus on 'RegisterMercuryTours.SomeTableTag.PostalCode'.", repo.RegisterMercuryTours.SomeTableTag.PostalCodeInfo, new RecordItemIndex(16));
            repo.RegisterMercuryTours.SomeTableTag.PostalCode.PressKeys("411057");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Move item 'RegisterMercuryTours.SomeTableTag.Country' at Center.", repo.RegisterMercuryTours.SomeTableTag.CountryInfo, new RecordItemIndex(17));
            repo.RegisterMercuryTours.SomeTableTag.Country.MoveTo();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'India' with focus on 'RegisterMercuryTours.SomeTableTag.Country'.", repo.RegisterMercuryTours.SomeTableTag.CountryInfo, new RecordItemIndex(18));
            repo.RegisterMercuryTours.SomeTableTag.Country.PressKeys("India");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RegisterMercuryTours.SomeTableTag.HttpNewtoursDemoautComImagesProfi' at Center.", repo.RegisterMercuryTours.SomeTableTag.HttpNewtoursDemoautComImagesProfiInfo, new RecordItemIndex(19));
            repo.RegisterMercuryTours.SomeTableTag.HttpNewtoursDemoautComImagesProfi.Click();
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
