using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using DeadHash.Classes;
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

            foreach (string s in args)
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
            ListViewItem lvi = new ListViewItem { Text = path };
            lsvPaths.Items.Add(lvi);
        }

        /// <summary>
        /// Load the hashes of a file into the GUI
        /// </summary>
        /// <param name="path">The complete path of a file</param>
        private void LoadHashes(string path)
        {
            try
            {
                txtMD5.Text = HashLoader.GetMD5FromFile(path);
                txtSHA1.Text = HashLoader.GetSHA1FromFile(path);
                txtSHA256.Text = HashLoader.GetSHA256FromFile(path);
                txtSHA384.Text = HashLoader.GetSHA384FromFile(path);
                txtSHA512.Text = HashLoader.GetSHA512FromFile(path);
                txtRIPEMD160.Text = HashLoader.GetRIPEMD160FromFile(path);
                txtCRC32.Text = HashLoader.GetCRC32FromFile(path);
            }
            catch (Exception ex)
            {
                MessageBoxAdv.Show(this, ex.Message, "DeadHash", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                if (ext == null || ext.Text.Length == 0) return;
                Clipboard.SetText(ext.Text);

                SuperToolTip stt = new SuperToolTip();
                ToolTipInfo tti = new ToolTipInfo();
                tti.Header.Hidden = true;
                tti.BackColor = MetroColor;
                tti.Body.Text = "Data copied to clipboard!";

                stt.VisualStyle = SuperToolTip.Appearance.Metro;
                stt.Style = SuperToolTip.SuperToolTipStyle.Balloon;
                stt.Show(tti, MousePosition, 1000);
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
                Process.Start("http://codedead.com/");
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
                Process.Start("help.pdf");
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
                Process.Start("license.pdf");
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

        /// <summary>
        /// Hide or show checkboxes in the ListView
        /// </summary>
        /// <param name="sender">The Checkboxes bar item button</param>
        /// <param name="e">Event argument</param>
        private void checkBoxesBarItem_Click(object sender, EventArgs e)
        {
            checkBoxesBarItem.Checked = !checkBoxesBarItem.Checked;
            lsvPaths.CheckBoxes = checkBoxesBarItem.Checked;
        }

        /// <summary>
        /// Hide or show gridlines in the ListView
        /// </summary>
        /// <param name="sender">The Gridnlines bar item button</param>
        /// <param name="e">Event argument</param>
        private void gridlinesBarItem_Click(object sender, EventArgs e)
        {
            gridlinesBarItem.Checked = !gridlinesBarItem.Checked;
            lsvPaths.GridLines = gridlinesBarItem.Checked;
        }

        /// <summary>
        /// Change the TopMost property, depending on the state of the Always on top bar item button
        /// </summary>
        /// <param name="sender">The Always on top bar item button</param>
        /// <param name="e">Event argument</param>
        private void alwaysOnTopBarItem_Click(object sender, EventArgs e)
        {
            alwaysOnTopBarItem.Checked = !alwaysOnTopBarItem.Checked;
            TopMost = alwaysOnTopBarItem.Checked;
        }

        /// <summary>
        /// Automatically resize the columns of the ListView
        /// </summary>
        /// <param name="sender">The Auto size bar item button</param>
        /// <param name="e">Event argument</param>
        private void autoSizeColumnsBarItem_Click(object sender, EventArgs e)
        {
            lsvPaths.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lsvPaths.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        /// <summary>
        /// Select all items in the ListView
        /// </summary>
        /// <param name="sender">The Select all items bar item button</param>
        /// <param name="e">Event argument</param>
        private void selectAllItemsBarItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in lsvPaths.Items)
            {
                lvi.Selected = true;
            }
        }

        /// <summary>
        /// Check all items in the ListView
        /// </summary>
        /// <param name="sender">The Check all items bar item button</param>
        /// <param name="e">Event argument</param>
        private void checkAllItemsBarItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in lsvPaths.Items)
            {
                lvi.Checked = true;
            }
        }

        /// <summary>
        /// Open the selected file
        /// </summary>
        /// <param name="sender">The Open bar item button</param>
        /// <param name="e">Event argument</param>
        private void openBarItem_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (ListViewItem lvi in lsvPaths.SelectedItems)
                {
                    Process.Start(lvi.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBoxAdv.Show(this, ex.Message, "DeadHash", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Clear all ListViewItems
        /// </summary>
        /// <param name="sender">The Clear bar item button</param>
        /// <param name="e">Event argument</param>
        private void clearBarItem_Click(object sender, EventArgs e)
        {
            lsvPaths.Items.Clear();
        }

        /// <summary>
        /// Add the complete file path of all the running processes to the ListView
        /// </summary>
        /// <param name="sender">The Open Processes bar item</param>
        /// <param name="e">Event argument</param>
        private void openProcessesBarItem_Click(object sender, EventArgs e)
        {
            foreach (Process p in Process.GetProcesses())
            {
                try
                {
                    OpenFile(p.MainModule.FileName);
                }
                catch (Exception)
                {
                    // Ignored
                }
            }
        }

        /// <summary>
        /// Open the path of the selected ListViewItem and load the details
        /// </summary>
        /// <param name="sender">The ListView</param>
        /// <param name="e">Mouse event argument</param>
        private void lsvPaths_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lsvPaths.SelectedItems.Count == 0) return;
            if (lsvPaths.SelectedItems[0].Text.Length == 0) return;

            LoadHashes(lsvPaths.SelectedItems[0].Text);
        }

        /// <summary>
        /// Change the drag and drop effects
        /// </summary>
        /// <param name="sender">The Main Form</param>
        /// <param name="e">Drag event argument</param>
        private void FrmMain_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.Data.GetDataPresent(DataFormats.FileDrop) ? DragDropEffects.Copy : DragDropEffects.None;
        }

        /// <summary>
        /// Open the full path of a dragged file into the GUI
        /// </summary>
        /// <param name="sender">The Main Form</param>
        /// <param name="e">Drag event argument</param>
        private void FrmMain_DragDrop(object sender, DragEventArgs e)
        {
            string[] fileList = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            foreach (string file in fileList)
            {
                if (File.Exists(file))
                {
                    OpenFile(file);
                }
            }
        }
    }
}
