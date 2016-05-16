using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DeadHash.Forms
{
    public partial class FrmSettings : Syncfusion.Windows.Forms.MetroForm
    {
        /// <summary>
        /// Constructor for the Settings Form
        /// </summary>
        public FrmSettings()
        {
            InitializeComponent();
            LoadTheme();
            LoadLanguage();
        }

        /// <summary>
        /// Change the GUI to match the current theme, depending on the settings
        /// </summary>
        private void LoadTheme()
        {
            MetroColor = Properties.Settings.Default.MetroColor;
            BorderColor = MetroColor;
            CaptionBarColor = MetroColor;
        }

        /// <summary>
        /// CHange the GUI to match the current language, depending on the settings
        /// </summary>
        private void LoadLanguage()
        {

        }
    }
}
