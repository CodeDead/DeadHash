using System;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;

namespace DeadHash.Forms
{
    public partial class FrmMain : MetroForm
    {
        /// <summary>
        /// Constructor for the Main Form
        /// </summary>
        public FrmMain()
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

        /// <summary>
        /// Copy the content of the textbox to the clipboard
        /// </summary>
        /// <param name="sender">The textbox that was double clicked</param>
        /// <param name="e">Event argument</param>
        private void txtProperty_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                TextBoxExt ext = sender as TextBoxExt;
                if (ext != null && ext.Text.Length != 0)
                {
                    Clipboard.SetText(ext.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBoxAdv.Show(this, ex.Message, "DeadHash", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Exit the program when the user clicks on the Exit bar item button
        /// </summary>
        /// <param name="sender">Exit bar item button</param>
        /// <param name="e">Event argument</param>
        private void exitBarItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Open the CodeDead website in the default browser when the Website button is clicked
        /// </summary>
        /// <param name="sender">The Website button</param>
        /// <param name="e">Event argument</param>
        private void websiteBarItem_Click(object sender, EventArgs e)
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
        /// Show the About Form when the user clicks the About button
        /// </summary>
        /// <param name="sender">The About button</param>
        /// <param name="e">Event argument</param>
        private void aboutBarItem_Click(object sender, EventArgs e)
        {
            new FrmAbout().Show();
        }

        /// <summary>
        /// Open the help documentation when the user clicks the Help button
        /// </summary>
        /// <param name="sender">The help button</param>
        /// <param name="e">Event argument</param>
        private void helpBarItem_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("help.pdf");
            }
            catch (Exception ex)
            {
                MessageBoxAdv.Show(this, ex.Message, "DeadHash", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Open the license file when the user clicks the License button
        /// </summary>
        /// <param name="sender">The license button</param>
        /// <param name="e">Event argument</param>
        private void licenseBarItem_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("license.pdf");
            }
            catch (Exception ex)
            {
                MessageBoxAdv.Show(this, ex.Message, "DeadHash", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Show the Settings Form when the user clicks the Settings button
        /// </summary>
        /// <param name="sender">The Settings button</param>
        /// <param name="e">Event argument</param>
        private void settingsBarItem_Click(object sender, EventArgs e)
        {
            new FrmSettings().ShowDialog();
        }
    }
}
