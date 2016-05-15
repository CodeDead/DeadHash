using System;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;

namespace DeadHash.Forms
{
    public partial class FrmAbout : MetroForm
    {
        public FrmAbout()
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

            btnCodeDead.MetroColor = MetroColor;
            btnClose.MetroColor = MetroColor;
        }

        /// <summary>
        /// CHange the GUI to match the current language, depending on the settings
        /// </summary>
        private void LoadLanguage()
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCodeDead_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("http://codedead.com/");
            }
            catch (Exception ex)
            {
                MessageBoxAdv.Show(this, ex.Message, "DeadHash", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
