#region Copyright Syncfusion Inc. 2001-2016.
// Copyright Syncfusion Inc. 2001-2016. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace DeadHash.Forms
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.mfbmMain = new Syncfusion.Windows.Forms.Tools.XPMenus.MainFrameBarManager(this);
            this.mainBar = new Syncfusion.Windows.Forms.Tools.XPMenus.Bar(this.mfbmMain, "Main");
            this.fileParentBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.openFileBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.openDirectoryBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.openProcessesBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.closeBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.exportBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.exitBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.editParentBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.openBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.deleteBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.clearBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.selectAllItemsBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.checkAllItemsBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.compareBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.openInVirusTotalBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.viewParentBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.pathBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.propertiesBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.gridlinesBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.fileDetailsBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.checkBoxesBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.alwaysOnTopBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.clipboardComparingBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.autoSizeColumnsBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.toolsParentBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.fileComparerBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.textComparerBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.textHasherBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.folderMonitorBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.settingsBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.helpParentBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.helpBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.checkForUpdatesBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.websiteBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.licenseBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.aboutBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            ((System.ComponentModel.ISupportInitialize)(this.mfbmMain)).BeginInit();
            this.SuspendLayout();
            // 
            // mfbmMain
            // 
            this.mfbmMain.BarPositionInfo = ((System.IO.MemoryStream)(resources.GetObject("mfbmMain.BarPositionInfo")));
            this.mfbmMain.Bars.Add(this.mainBar);
            this.mfbmMain.Categories.Add("File");
            this.mfbmMain.Categories.Add("Edit");
            this.mfbmMain.Categories.Add("View");
            this.mfbmMain.Categories.Add("Tools");
            this.mfbmMain.Categories.Add("Help");
            this.mfbmMain.CurrentBaseFormType = "";
            this.mfbmMain.EnableMenuMerge = true;
            this.mfbmMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mfbmMain.Form = this;
            this.mfbmMain.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.fileParentBarItem,
            this.openFileBarItem,
            this.openDirectoryBarItem,
            this.openProcessesBarItem,
            this.closeBarItem,
            this.exportBarItem,
            this.exitBarItem,
            this.editParentBarItem,
            this.openBarItem,
            this.deleteBarItem,
            this.clearBarItem,
            this.selectAllItemsBarItem,
            this.checkAllItemsBarItem,
            this.compareBarItem,
            this.openInVirusTotalBarItem,
            this.viewParentBarItem,
            this.pathBarItem,
            this.propertiesBarItem,
            this.gridlinesBarItem,
            this.fileDetailsBarItem,
            this.checkBoxesBarItem,
            this.alwaysOnTopBarItem,
            this.clipboardComparingBarItem,
            this.autoSizeColumnsBarItem,
            this.toolsParentBarItem,
            this.fileComparerBarItem,
            this.textComparerBarItem,
            this.textHasherBarItem,
            this.folderMonitorBarItem,
            this.settingsBarItem,
            this.helpParentBarItem,
            this.helpBarItem,
            this.checkForUpdatesBarItem,
            this.websiteBarItem,
            this.licenseBarItem,
            this.aboutBarItem});
            this.mfbmMain.MetroColor = System.Drawing.Color.SteelBlue;
            this.mfbmMain.ResetCustomization = false;
            this.mfbmMain.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.mfbmMain.UseBackwardCompatiblity = false;
            // 
            // mainBar
            // 
            this.mainBar.AllowCustomizing = false;
            this.mainBar.AllowHiding = false;
            this.mainBar.BarName = "Main";
            this.mainBar.BarStyle = ((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle)((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.IsMainMenu | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.Visible)));
            this.mainBar.Caption = "Main";
            this.mainBar.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.fileParentBarItem,
            this.editParentBarItem,
            this.viewParentBarItem,
            this.toolsParentBarItem,
            this.helpParentBarItem});
            this.mainBar.Manager = this.mfbmMain;
            // 
            // fileParentBarItem
            // 
            this.fileParentBarItem.BarName = "fileParentBarItem";
            this.fileParentBarItem.CategoryIndex = 0;
            this.fileParentBarItem.ID = "fileParentBarItem";
            this.fileParentBarItem.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.openFileBarItem,
            this.openDirectoryBarItem,
            this.openProcessesBarItem,
            this.closeBarItem,
            this.exportBarItem,
            this.exitBarItem});
            this.fileParentBarItem.MetroColor = System.Drawing.Color.SteelBlue;
            this.fileParentBarItem.SeparatorIndices.AddRange(new int[] {
            3,
            5});
            this.fileParentBarItem.ShowToolTipInPopUp = false;
            this.fileParentBarItem.SizeToFit = true;
            this.fileParentBarItem.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.fileParentBarItem.Text = "File";
            this.fileParentBarItem.WrapLength = 20;
            // 
            // openFileBarItem
            // 
            this.openFileBarItem.BarName = "openFileBarItem";
            this.openFileBarItem.CategoryIndex = 0;
            this.openFileBarItem.ID = "Open file...";
            this.openFileBarItem.ShowToolTipInPopUp = false;
            this.openFileBarItem.SizeToFit = true;
            this.openFileBarItem.Text = "Open file...";
            // 
            // openDirectoryBarItem
            // 
            this.openDirectoryBarItem.BarName = "openDirectoryBarItem";
            this.openDirectoryBarItem.CategoryIndex = 0;
            this.openDirectoryBarItem.ID = "Open directory...";
            this.openDirectoryBarItem.ShowToolTipInPopUp = false;
            this.openDirectoryBarItem.SizeToFit = true;
            this.openDirectoryBarItem.Text = "Open directory...";
            // 
            // openProcessesBarItem
            // 
            this.openProcessesBarItem.BarName = "openProcessesBarItem";
            this.openProcessesBarItem.CategoryIndex = 0;
            this.openProcessesBarItem.ID = "Open processess...";
            this.openProcessesBarItem.ShowToolTipInPopUp = false;
            this.openProcessesBarItem.SizeToFit = true;
            this.openProcessesBarItem.Text = "Open processess...";
            // 
            // closeBarItem
            // 
            this.closeBarItem.BarName = "closeBarItem";
            this.closeBarItem.CategoryIndex = 0;
            this.closeBarItem.ID = "Close";
            this.closeBarItem.ShowToolTipInPopUp = false;
            this.closeBarItem.SizeToFit = true;
            this.closeBarItem.Text = "Close";
            // 
            // exportBarItem
            // 
            this.exportBarItem.BarName = "exportBarItem";
            this.exportBarItem.CategoryIndex = 0;
            this.exportBarItem.ID = "Export";
            this.exportBarItem.ShowToolTipInPopUp = false;
            this.exportBarItem.SizeToFit = true;
            this.exportBarItem.Text = "Export";
            // 
            // exitBarItem
            // 
            this.exitBarItem.BarName = "exitBarItem";
            this.exitBarItem.CategoryIndex = 0;
            this.exitBarItem.ID = "Exit";
            this.exitBarItem.ShowToolTipInPopUp = false;
            this.exitBarItem.SizeToFit = true;
            this.exitBarItem.Text = "Exit";
            // 
            // editParentBarItem
            // 
            this.editParentBarItem.BarName = "editParentBarItem";
            this.editParentBarItem.CategoryIndex = 1;
            this.editParentBarItem.ID = "Edit";
            this.editParentBarItem.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.openBarItem,
            this.deleteBarItem,
            this.clearBarItem,
            this.selectAllItemsBarItem,
            this.checkAllItemsBarItem,
            this.compareBarItem,
            this.openInVirusTotalBarItem});
            this.editParentBarItem.MetroColor = System.Drawing.Color.SteelBlue;
            this.editParentBarItem.SeparatorIndices.AddRange(new int[] {
            2,
            3,
            5,
            6});
            this.editParentBarItem.ShowToolTipInPopUp = false;
            this.editParentBarItem.SizeToFit = true;
            this.editParentBarItem.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.editParentBarItem.Text = "Edit";
            this.editParentBarItem.WrapLength = 20;
            // 
            // openBarItem
            // 
            this.openBarItem.BarName = "openBarItem";
            this.openBarItem.CategoryIndex = 1;
            this.openBarItem.ID = "Open";
            this.openBarItem.ShowToolTipInPopUp = false;
            this.openBarItem.SizeToFit = true;
            this.openBarItem.Text = "Open";
            // 
            // deleteBarItem
            // 
            this.deleteBarItem.BarName = "deleteBarItem";
            this.deleteBarItem.CategoryIndex = 1;
            this.deleteBarItem.ID = "Delete";
            this.deleteBarItem.ShowToolTipInPopUp = false;
            this.deleteBarItem.SizeToFit = true;
            this.deleteBarItem.Text = "Delete";
            // 
            // clearBarItem
            // 
            this.clearBarItem.BarName = "clearBarItem";
            this.clearBarItem.CategoryIndex = 1;
            this.clearBarItem.ID = "Clear";
            this.clearBarItem.ShowToolTipInPopUp = false;
            this.clearBarItem.SizeToFit = true;
            this.clearBarItem.Text = "Clear";
            // 
            // selectAllItemsBarItem
            // 
            this.selectAllItemsBarItem.BarName = "selectAllItemsBarItem";
            this.selectAllItemsBarItem.CategoryIndex = 1;
            this.selectAllItemsBarItem.ID = "Select all items";
            this.selectAllItemsBarItem.ShowToolTipInPopUp = false;
            this.selectAllItemsBarItem.SizeToFit = true;
            this.selectAllItemsBarItem.Text = "Select all items";
            // 
            // checkAllItemsBarItem
            // 
            this.checkAllItemsBarItem.BarName = "checkAllItemsBarItem";
            this.checkAllItemsBarItem.CategoryIndex = 1;
            this.checkAllItemsBarItem.ID = "Check all items";
            this.checkAllItemsBarItem.ShowToolTipInPopUp = false;
            this.checkAllItemsBarItem.SizeToFit = true;
            this.checkAllItemsBarItem.Text = "Check all items";
            // 
            // compareBarItem
            // 
            this.compareBarItem.BarName = "compareBarItem";
            this.compareBarItem.CategoryIndex = 1;
            this.compareBarItem.ID = "Compare";
            this.compareBarItem.ShowToolTipInPopUp = false;
            this.compareBarItem.SizeToFit = true;
            this.compareBarItem.Text = "Compare";
            // 
            // openInVirusTotalBarItem
            // 
            this.openInVirusTotalBarItem.BarName = "openInVirusTotalBarItem";
            this.openInVirusTotalBarItem.CategoryIndex = 1;
            this.openInVirusTotalBarItem.ID = "Open in VirusTotal";
            this.openInVirusTotalBarItem.ShowToolTipInPopUp = false;
            this.openInVirusTotalBarItem.SizeToFit = true;
            this.openInVirusTotalBarItem.Text = "Open in VirusTotal";
            // 
            // viewParentBarItem
            // 
            this.viewParentBarItem.BarName = "viewParentBarItem";
            this.viewParentBarItem.CategoryIndex = 2;
            this.viewParentBarItem.ID = "View";
            this.viewParentBarItem.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.pathBarItem,
            this.propertiesBarItem,
            this.gridlinesBarItem,
            this.fileDetailsBarItem,
            this.checkBoxesBarItem,
            this.alwaysOnTopBarItem,
            this.clipboardComparingBarItem,
            this.autoSizeColumnsBarItem});
            this.viewParentBarItem.MetroColor = System.Drawing.Color.SteelBlue;
            this.viewParentBarItem.SeparatorIndices.AddRange(new int[] {
            5,
            7});
            this.viewParentBarItem.ShowToolTipInPopUp = false;
            this.viewParentBarItem.SizeToFit = true;
            this.viewParentBarItem.Text = "View";
            this.viewParentBarItem.WrapLength = 20;
            // 
            // pathBarItem
            // 
            this.pathBarItem.BarName = "pathBarItem";
            this.pathBarItem.CategoryIndex = 2;
            this.pathBarItem.ID = "Path";
            this.pathBarItem.ShowToolTipInPopUp = false;
            this.pathBarItem.SizeToFit = true;
            this.pathBarItem.Text = "Path";
            // 
            // propertiesBarItem
            // 
            this.propertiesBarItem.BarName = "propertiesBarItem";
            this.propertiesBarItem.CategoryIndex = 2;
            this.propertiesBarItem.ID = "Properties";
            this.propertiesBarItem.ShowToolTipInPopUp = false;
            this.propertiesBarItem.SizeToFit = true;
            this.propertiesBarItem.Text = "Properties";
            // 
            // gridlinesBarItem
            // 
            this.gridlinesBarItem.BarName = "gridlinesBarItem";
            this.gridlinesBarItem.CategoryIndex = 2;
            this.gridlinesBarItem.ID = "Gridlines";
            this.gridlinesBarItem.ShowToolTipInPopUp = false;
            this.gridlinesBarItem.SizeToFit = true;
            this.gridlinesBarItem.Text = "Gridlines";
            // 
            // fileDetailsBarItem
            // 
            this.fileDetailsBarItem.BarName = "fileDetailsBarItem";
            this.fileDetailsBarItem.CategoryIndex = 2;
            this.fileDetailsBarItem.ID = "File details";
            this.fileDetailsBarItem.ShowToolTipInPopUp = false;
            this.fileDetailsBarItem.SizeToFit = true;
            this.fileDetailsBarItem.Text = "File details";
            // 
            // checkBoxesBarItem
            // 
            this.checkBoxesBarItem.BarName = "checkBoxesBarItem";
            this.checkBoxesBarItem.CategoryIndex = 2;
            this.checkBoxesBarItem.ID = "Checkboxes";
            this.checkBoxesBarItem.ShowToolTipInPopUp = false;
            this.checkBoxesBarItem.SizeToFit = true;
            this.checkBoxesBarItem.Text = "Checkboxes";
            // 
            // alwaysOnTopBarItem
            // 
            this.alwaysOnTopBarItem.BarName = "alwaysOnTopBarItem";
            this.alwaysOnTopBarItem.CategoryIndex = 2;
            this.alwaysOnTopBarItem.ID = "Always on top";
            this.alwaysOnTopBarItem.ShowToolTipInPopUp = false;
            this.alwaysOnTopBarItem.SizeToFit = true;
            this.alwaysOnTopBarItem.Text = "Always on top";
            // 
            // clipboardComparingBarItem
            // 
            this.clipboardComparingBarItem.BarName = "clipboardComparingBarItem";
            this.clipboardComparingBarItem.CategoryIndex = 2;
            this.clipboardComparingBarItem.ID = "Clipboard comparing";
            this.clipboardComparingBarItem.ShowToolTipInPopUp = false;
            this.clipboardComparingBarItem.SizeToFit = true;
            this.clipboardComparingBarItem.Text = "Clipboard comparing";
            // 
            // autoSizeColumnsBarItem
            // 
            this.autoSizeColumnsBarItem.BarName = "autoSizeColumnsBarItem";
            this.autoSizeColumnsBarItem.CategoryIndex = 2;
            this.autoSizeColumnsBarItem.ID = "Auto size columns";
            this.autoSizeColumnsBarItem.ShowToolTipInPopUp = false;
            this.autoSizeColumnsBarItem.SizeToFit = true;
            this.autoSizeColumnsBarItem.Text = "Auto size columns";
            // 
            // toolsParentBarItem
            // 
            this.toolsParentBarItem.BarName = "toolsParentBarItem";
            this.toolsParentBarItem.CategoryIndex = 3;
            this.toolsParentBarItem.ID = "Tools";
            this.toolsParentBarItem.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.fileComparerBarItem,
            this.textComparerBarItem,
            this.textHasherBarItem,
            this.folderMonitorBarItem,
            this.settingsBarItem});
            this.toolsParentBarItem.MetroColor = System.Drawing.Color.SteelBlue;
            this.toolsParentBarItem.SeparatorIndices.AddRange(new int[] {
            2,
            3});
            this.toolsParentBarItem.ShowToolTipInPopUp = false;
            this.toolsParentBarItem.SizeToFit = true;
            this.toolsParentBarItem.Text = "Tools";
            this.toolsParentBarItem.WrapLength = 20;
            // 
            // fileComparerBarItem
            // 
            this.fileComparerBarItem.BarName = "fileComparerBarItem";
            this.fileComparerBarItem.CategoryIndex = 3;
            this.fileComparerBarItem.ID = "File Comparer";
            this.fileComparerBarItem.ShowToolTipInPopUp = false;
            this.fileComparerBarItem.SizeToFit = true;
            this.fileComparerBarItem.Text = "File Comparer";
            // 
            // textComparerBarItem
            // 
            this.textComparerBarItem.BarName = "textComparerBarItem";
            this.textComparerBarItem.CategoryIndex = 3;
            this.textComparerBarItem.ID = "Text Comparer";
            this.textComparerBarItem.ShowToolTipInPopUp = false;
            this.textComparerBarItem.SizeToFit = true;
            this.textComparerBarItem.Text = "Text Comparer";
            // 
            // textHasherBarItem
            // 
            this.textHasherBarItem.BarName = "textHasherBarItem";
            this.textHasherBarItem.CategoryIndex = 3;
            this.textHasherBarItem.ID = "Text Hasher";
            this.textHasherBarItem.ShowToolTipInPopUp = false;
            this.textHasherBarItem.SizeToFit = true;
            this.textHasherBarItem.Text = "Text Hasher";
            // 
            // folderMonitorBarItem
            // 
            this.folderMonitorBarItem.BarName = "folderMonitorBarItem";
            this.folderMonitorBarItem.CategoryIndex = 3;
            this.folderMonitorBarItem.ID = "Folder Monitor";
            this.folderMonitorBarItem.ShowToolTipInPopUp = false;
            this.folderMonitorBarItem.SizeToFit = true;
            this.folderMonitorBarItem.Text = "Folder Monitor";
            // 
            // settingsBarItem
            // 
            this.settingsBarItem.BarName = "settingsBarItem";
            this.settingsBarItem.CategoryIndex = 3;
            this.settingsBarItem.ID = "Settings";
            this.settingsBarItem.ShowToolTipInPopUp = false;
            this.settingsBarItem.SizeToFit = true;
            this.settingsBarItem.Text = "Settings";
            // 
            // helpParentBarItem
            // 
            this.helpParentBarItem.BarName = "helpParentBarItem";
            this.helpParentBarItem.CategoryIndex = 4;
            this.helpParentBarItem.ID = "Help";
            this.helpParentBarItem.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.helpBarItem,
            this.checkForUpdatesBarItem,
            this.websiteBarItem,
            this.licenseBarItem,
            this.aboutBarItem});
            this.helpParentBarItem.MetroColor = System.Drawing.Color.SteelBlue;
            this.helpParentBarItem.SeparatorIndices.AddRange(new int[] {
            1,
            3});
            this.helpParentBarItem.ShowToolTipInPopUp = false;
            this.helpParentBarItem.SizeToFit = true;
            this.helpParentBarItem.Text = "Help";
            this.helpParentBarItem.WrapLength = 20;
            // 
            // helpBarItem
            // 
            this.helpBarItem.BarName = "helpBarItem";
            this.helpBarItem.CategoryIndex = 4;
            this.helpBarItem.ID = "Help_1";
            this.helpBarItem.ShowToolTipInPopUp = false;
            this.helpBarItem.SizeToFit = true;
            this.helpBarItem.Text = "Help";
            // 
            // checkForUpdatesBarItem
            // 
            this.checkForUpdatesBarItem.BarName = "checkForUpdatesBarItem";
            this.checkForUpdatesBarItem.CategoryIndex = 4;
            this.checkForUpdatesBarItem.ID = "Check for updates";
            this.checkForUpdatesBarItem.ShowToolTipInPopUp = false;
            this.checkForUpdatesBarItem.SizeToFit = true;
            this.checkForUpdatesBarItem.Text = "Check for updates";
            // 
            // websiteBarItem
            // 
            this.websiteBarItem.BarName = "websiteBarItem";
            this.websiteBarItem.CategoryIndex = 4;
            this.websiteBarItem.ID = "Website";
            this.websiteBarItem.ShowToolTipInPopUp = false;
            this.websiteBarItem.SizeToFit = true;
            this.websiteBarItem.Text = "Website";
            // 
            // licenseBarItem
            // 
            this.licenseBarItem.BarName = "licenseBarItem";
            this.licenseBarItem.CategoryIndex = 4;
            this.licenseBarItem.ID = "License";
            this.licenseBarItem.ShowToolTipInPopUp = false;
            this.licenseBarItem.SizeToFit = true;
            this.licenseBarItem.Text = "License";
            // 
            // aboutBarItem
            // 
            this.aboutBarItem.BarName = "aboutBarItem";
            this.aboutBarItem.CategoryIndex = 4;
            this.aboutBarItem.ID = "About";
            this.aboutBarItem.ShowToolTipInPopUp = false;
            this.aboutBarItem.SizeToFit = true;
            this.aboutBarItem.Text = "About";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderColor = System.Drawing.Color.SteelBlue;
            this.BorderThickness = 2;
            this.CaptionBarColor = System.Drawing.Color.SteelBlue;
            this.CaptionButtonColor = System.Drawing.Color.Black;
            this.CaptionButtonHoverColor = System.Drawing.Color.White;
            this.CaptionForeColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(488, 314);
            this.MetroColor = System.Drawing.Color.SteelBlue;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeadHash";
            ((System.ComponentModel.ISupportInitialize)(this.mfbmMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.XPMenus.MainFrameBarManager mfbmMain;
        private Syncfusion.Windows.Forms.Tools.XPMenus.Bar mainBar;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem fileParentBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem openFileBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem openDirectoryBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem openProcessesBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem closeBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem exportBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem exitBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem editParentBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem openBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem deleteBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem clearBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem selectAllItemsBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem checkAllItemsBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem compareBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem openInVirusTotalBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem viewParentBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem pathBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem propertiesBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem gridlinesBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem fileDetailsBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem checkBoxesBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem alwaysOnTopBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem clipboardComparingBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem autoSizeColumnsBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem toolsParentBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem fileComparerBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem textComparerBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem textHasherBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem folderMonitorBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem settingsBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem helpParentBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem helpBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem checkForUpdatesBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem websiteBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem licenseBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem aboutBarItem;
    }
}