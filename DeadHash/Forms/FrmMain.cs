#region Copyright Syncfusion Inc. 2001-2016.
// Copyright Syncfusion Inc. 2001-2016. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;

namespace DeadHash.Forms
{
    public partial class FrmMain : Syncfusion.Windows.Forms.MetroForm
    {
        public FrmMain()
        {
            InitializeComponent();
            LoadTheme();
        }

        /// <summary>
        /// Change the GUI to match the current theme, depending on the settings
        /// </summary>
        private void LoadTheme()
        {
            BorderColor = MetroColor;
            CaptionBarColor = MetroColor;

            mfbmMain.MetroColor = MetroColor;
            mfbmMain.ResetCustomization = false;
            mfbmMain.Style = VisualStyle.Metro;

            fileParentBarItem.MetroColor = Properties.Settings.Default.MetroColor;
            editParentBarItem.MetroColor = Properties.Settings.Default.MetroColor;
            viewParentBarItem.MetroColor = Properties.Settings.Default.MetroColor;
            toolsParentBarItem.MetroColor = Properties.Settings.Default.MetroColor;
            helpParentBarItem.MetroColor = Properties.Settings.Default.MetroColor;

            mfbmMain.RefreshCommandBarsAfterDesignerLoad(false);
        }

        /// <summary>
        /// CHange the GUI to match the current language, depending on the settings
        /// </summary>
        private void LoadLanguage()
        {
            
        }
    }
}
