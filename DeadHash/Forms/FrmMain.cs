using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using FixedPanel = Syncfusion.Windows.Forms.Tools.Enums.FixedPanel;

namespace DeadHash.Forms
{
    public partial class FrmMain : MetroForm
    {
        /// <summary>
        /// Constructor for the Main Form
        /// </summary>
        public FrmMain(IEnumerable<string> args)
        {
            InitializeComponent();
            LoadTheme();
            LoadLanguage();

            foreach(string s in args)
            {
                OpenFile(s);
            }
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
        /// Load a file into the GUI, so that the user can view its properties
        /// </summary>
        /// <param name="path">The full path of a file</param>
        private void OpenFile(string path)
        {
            if (!File.Exists(path)) return;
            ListViewItem lvi = new ListViewItem {Text = path};
            lsvPaths.Items.Add(lvi);
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

        /// <summary>
        /// Open a file
        /// </summary>
        /// <param name="sender">The Open file bar item button</param>
        /// <param name="e">Event argument</param>
        private void openFileBarItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Multiselect = true,
                Filter = @"*.*|*.*"
            };

            if (ofd.ShowDialog() != DialogResult.OK) return;
            foreach (string s in ofd.FileNames)
            {
                OpenFile(s);
            }
        }

        /// <summary>
        /// Show or hide the Path panel
        /// </summary>
        /// <param name="sender">The Path bar item button</param>
        /// <param name="e">Event argument</param>
        private void pathBarItem_Click(object sender, EventArgs e)
        {
            pathBarItem.Checked = !pathBarItem.Checked;
            Panel1Helper();
        }

        /// <summary>
        /// Hide or show the Path panel
        /// </summary>
        private void Panel1Helper()
        {
            if (pathBarItem.Checked)
            {
                splitContainerAdv.Panel1.Show();
                splitContainerAdv.FixedPanel = FixedPanel.None;
            }
            else
            {
                splitContainerAdv.Panel1.Hide();
                splitContainerAdv.FixedPanel = splitContainerAdv.Panel2.Visible ? FixedPanel.Panel2 : FixedPanel.None;
            }
            splitContainerAdv.Panel1Collapsed = !pathBarItem.Checked;
            splitContainerAdv.IsSplitterFixed = !pathBarItem.Checked;
        }

        /// <summary>
        /// Hide or show the Properties panel
        /// </summary>
        /// <param name="sender">The Properties bar item button</param>
        /// <param name="e">Event argument</param>
        private void propertiesBarItem_Click(object sender, EventArgs e)
        {
            propertiesBarItem.Checked = !propertiesBarItem.Checked;
            Panel2Helper();
        }

        /// <summary>
        /// Hide or show the Properties panel
        /// </summary>
        private void Panel2Helper()
        {
            if (propertiesBarItem.Checked)
            {
                splitContainerAdv.Panel2.Show();
                splitContainerAdv.FixedPanel = FixedPanel.None;
            }
            else
            {
                splitContainerAdv.Panel2.Hide();
                splitContainerAdv.FixedPanel = splitContainerAdv.Panel1.Visible ? FixedPanel.Panel1 : FixedPanel.None;
            }
            splitContainerAdv.Panel2Collapsed = !propertiesBarItem.Checked;
            splitContainerAdv.IsSplitterFixed = !propertiesBarItem.Checked;
        }
    }
}
