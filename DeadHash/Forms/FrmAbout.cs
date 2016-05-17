using System;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;

namespace DeadHash.Forms
{
    public partial class FrmAbout : MetroForm
    {
        /// <summary>
        /// Constructor for the About Form
        /// </summary>
        public FrmAbout()
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

            btnCodeDead.MetroColor = MetroColor;
            btnClose.MetroColor = MetroColor;
        }

        /// <summary>
        /// CHange the GUI to match the current language, depending on the settings
        /// </summary>
        private void LoadLanguage()
        {

        }

        /// <summary>
        /// Close the form when the close button is clicked
        /// </summary>
        /// <param name="sender">The close button</param>
        /// <param name="e">Event argument</param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Open the CodeDead website in the default browser when the CodeDead button is clicked
        /// </summary>
        /// <param name="sender">The CodeDead button</param>
        /// <param name="e">Event argument</param>
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

        /// <summary>
        /// Open the paomedia website in the default browser when the Paomedia button is clicked
        /// </summary>
        /// <param name="sender">The Paomedia button</param>
        /// <param name="e">Event argument</param>
        private void btnPaomedia_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("http://paomedia.github.io/small-n-flat/");
            }
            catch (Exception ex)
            {
                MessageBoxAdv.Show(this, ex.Message, "DeadHash", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
