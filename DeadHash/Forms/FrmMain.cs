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
    public partial class FrmMain : MetroForm
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
            MetroColor = Properties.Settings.Default.MetroColor;
            BorderColor = MetroColor;
            CaptionBarColor = MetroColor;

            mfbmMain.MetroColor = MetroColor;
            mfbmMain.ResetCustomization = false;
            mfbmMain.Style = VisualStyle.Metro;

            fileParentBarItem.MetroColor = MetroColor;
            editParentBarItem.MetroColor = MetroColor;
            viewParentBarItem.MetroColor = MetroColor;
            toolsParentBarItem.MetroColor = MetroColor;
            helpParentBarItem.MetroColor = MetroColor;

            txtMD5.Metrocolor = MetroColor;
            txtSHA1.Metrocolor = MetroColor;
            txtSHA256.Metrocolor = MetroColor;
            txtSHA384.Metrocolor = MetroColor;
            txtSHA512.Metrocolor = MetroColor;
            txtRIPEMD160.Metrocolor = MetroColor;
            txtCRC32.Metrocolor = MetroColor;

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
