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

namespace Colecciones_Biologia
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Recording2 recording.
    /// </summary>
    [TestModule("2dfc0b00-1ca8-4f17-a175-c34878dd2767", ModuleType.Recording, 1)]
    public partial class Recording2 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the Colecciones_BiologiaRepository repository.
        /// </summary>
        public static Colecciones_BiologiaRepository repo = Colecciones_BiologiaRepository.Instance;

        static Recording2 instance = new Recording2();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Recording2()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Recording2 Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
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
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Form21WhatsAppMozillaFirefox.ColeccionBiologiaUVG' at 37;12.", repo.Form21WhatsAppMozillaFirefox.ColeccionBiologiaUVGInfo, new RecordItemIndex(0));
            repo.Form21WhatsAppMozillaFirefox.ColeccionBiologiaUVG.Click("37;12");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LiteappsMcafeeCom.McAfeeWebProtection' at 252;27.", repo.LiteappsMcafeeCom.McAfeeWebProtectionInfo, new RecordItemIndex(1));
            repo.LiteappsMcafeeCom.McAfeeWebProtection.Click("252;27");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LiteappsMcafeeCom.Hilite' at 423;52.", repo.LiteappsMcafeeCom.HiliteInfo, new RecordItemIndex(2));
            repo.LiteappsMcafeeCom.Hilite.Click("423;52");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LiteappsMcafeeCom.Hilite' at 504;50.", repo.LiteappsMcafeeCom.HiliteInfo, new RecordItemIndex(3));
            repo.LiteappsMcafeeCom.Hilite.Click("504;50");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'ColeccionBiologiaUVGMozillaFirefox.ColeccionBiologiaUVG1.None1'.", repo.ColeccionBiologiaUVGMozillaFirefox.ColeccionBiologiaUVG1.None1Info, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.ColeccionBiologiaUVGMozillaFirefox.ColeccionBiologiaUVG1.None1Info, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ColeccionBiologiaUVGMozillaFirefox.ColeccionBiologiaUVG.None' at 267;152.", repo.ColeccionBiologiaUVGMozillaFirefox.ColeccionBiologiaUVG.NoneInfo, new RecordItemIndex(5));
            repo.ColeccionBiologiaUVGMozillaFirefox.ColeccionBiologiaUVG.None.Click("267;152");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ColeccionBiologiaUVGMozillaFirefox.ColeccionBiologiaUVG.None' at 369;142.", repo.ColeccionBiologiaUVGMozillaFirefox.ColeccionBiologiaUVG.NoneInfo, new RecordItemIndex(6));
            repo.ColeccionBiologiaUVGMozillaFirefox.ColeccionBiologiaUVG.None.Click("369;142");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ColeccionBiologiaUVGMozillaFirefox.ColeccionBiologiaUVG.None' at 477;-314.", repo.ColeccionBiologiaUVGMozillaFirefox.ColeccionBiologiaUVG.NoneInfo, new RecordItemIndex(7));
            repo.ColeccionBiologiaUVGMozillaFirefox.ColeccionBiologiaUVG.None.Click("477;-314");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ColeccionBiologiaUVGMozillaFirefox.ColeccionBiologiaUVG1.Departamento' at 194;31.", repo.ColeccionBiologiaUVGMozillaFirefox.ColeccionBiologiaUVG1.DepartamentoInfo, new RecordItemIndex(8));
            repo.ColeccionBiologiaUVGMozillaFirefox.ColeccionBiologiaUVG1.Departamento.Click("194;31");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'ColeccionBiologiaUVGMozillaFirefox.ColeccionBiologiaUVG1.Departamento1'.", repo.ColeccionBiologiaUVGMozillaFirefox.ColeccionBiologiaUVG1.Departamento1Info, new RecordItemIndex(9));
            Validate.AttributeEqual(repo.ColeccionBiologiaUVGMozillaFirefox.ColeccionBiologiaUVG1.Departamento1Info, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (AccessibleDefaultAction='click') on item 'ColeccionBiologiaUVGMozillaFirefox.ColeccionBiologiaUVG1.Departamento1'.", repo.ColeccionBiologiaUVGMozillaFirefox.ColeccionBiologiaUVG1.Departamento1Info, new RecordItemIndex(10));
            Validate.AttributeEqual(repo.ColeccionBiologiaUVGMozillaFirefox.ColeccionBiologiaUVG1.Departamento1Info, "AccessibleDefaultAction", "click");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ColeccionBiologiaUVGMozillaFirefox.ColeccionBiologiaUVG1.None1' at 369;710.", repo.ColeccionBiologiaUVGMozillaFirefox.ColeccionBiologiaUVG1.None1Info, new RecordItemIndex(11));
            repo.ColeccionBiologiaUVGMozillaFirefox.ColeccionBiologiaUVG1.None1.Click("369;710");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'ColeccionBiologiaUVGMozillaFirefox.ColeccionBiologiaUVG1.None' at 1919;252.", repo.ColeccionBiologiaUVGMozillaFirefox.ColeccionBiologiaUVG1.NoneInfo, new RecordItemIndex(12));
            repo.ColeccionBiologiaUVGMozillaFirefox.ColeccionBiologiaUVG1.None.MoveTo("1919;252");
            Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Move item 'ColeccionBiologiaUVGMozillaFirefox.ColeccionBiologiaUVG1.None' at 1927;244.", repo.ColeccionBiologiaUVGMozillaFirefox.ColeccionBiologiaUVG1.NoneInfo, new RecordItemIndex(13));
            repo.ColeccionBiologiaUVGMozillaFirefox.ColeccionBiologiaUVG1.None.MoveTo("1927;244");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Up item 'ColeccionBiologiaUVGMozillaFirefox.None' at 1919;372.", repo.ColeccionBiologiaUVGMozillaFirefox.NoneInfo, new RecordItemIndex(14));
            repo.ColeccionBiologiaUVGMozillaFirefox.None.MoveTo("1919;372");
            Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ColeccionBiologiaUVGMozillaFirefox.ColeccionBiologiaUVG.None' at 94;551.", repo.ColeccionBiologiaUVGMozillaFirefox.ColeccionBiologiaUVG.NoneInfo, new RecordItemIndex(15));
            repo.ColeccionBiologiaUVGMozillaFirefox.ColeccionBiologiaUVG.None.Click("94;551");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{NumPad1}{NumPad1}' with focus on 'ColeccionBiologiaUVGMozillaFirefox'.", repo.ColeccionBiologiaUVGMozillaFirefox.SelfInfo, new RecordItemIndex(16));
            repo.ColeccionBiologiaUVGMozillaFirefox.Self.EnsureVisible();
            Keyboard.Press("{NumPad1}{NumPad1}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ColeccionBiologiaUVGMozillaFirefox.ColeccionBiologiaUVG1.Reset' at 59;11.", repo.ColeccionBiologiaUVGMozillaFirefox.ColeccionBiologiaUVG1.ResetInfo, new RecordItemIndex(17));
            repo.ColeccionBiologiaUVGMozillaFirefox.ColeccionBiologiaUVG1.Reset.Click("59;11");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ColeccionBiologiaUVGMozillaFirefox.ColeccionBiologiaUVG1.LocalidadPostalCodePostalCodePostal' at 25;26.", repo.ColeccionBiologiaUVGMozillaFirefox.ColeccionBiologiaUVG1.LocalidadPostalCodePostalCodePostalInfo, new RecordItemIndex(18));
            repo.ColeccionBiologiaUVGMozillaFirefox.ColeccionBiologiaUVG1.LocalidadPostalCodePostalCodePostal.Click("25;26");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
