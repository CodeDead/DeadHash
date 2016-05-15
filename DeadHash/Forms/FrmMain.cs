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
    }
}
