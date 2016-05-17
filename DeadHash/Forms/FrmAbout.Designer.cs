#region Copyright Syncfusion Inc. 2001-2016.
// Copyright Syncfusion Inc. 2001-2016. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace DeadHash.Forms
{
    partial class FrmAbout
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAbout));
            this.pnlAbout = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblAbout = new System.Windows.Forms.Label();
            this.btnCodeDead = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnClose = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnPaomedia = new Syncfusion.Windows.Forms.ButtonAdv();
            this.pnlAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAbout
            // 
            this.pnlAbout.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlAbout.Controls.Add(this.picLogo);
            this.pnlAbout.Controls.Add(this.lblAbout);
            this.pnlAbout.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAbout.Location = new System.Drawing.Point(0, 0);
            this.pnlAbout.Name = "pnlAbout";
            this.pnlAbout.Size = new System.Drawing.Size(386, 120);
            this.pnlAbout.TabIndex = 0;
            this.pnlAbout.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.Image = global::DeadHash.Properties.Resources.puzzle;
            this.picLogo.Location = new System.Drawing.Point(74, 36);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(48, 48);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 1;
            this.picLogo.TabStop = false;
            this.picLogo.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblAbout
            // 
            this.lblAbout.AutoSize = true;
            this.lblAbout.BackColor = System.Drawing.Color.Transparent;
            this.lblAbout.Location = new System.Drawing.Point(128, 21);
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size(185, 78);
            this.lblAbout.TabIndex = 0;
            this.lblAbout.Text = "DeadHash was created by DeadLine.\r\n\r\nTheme by: SyncFusion\r\nIcons by: paomedia (sm" +
    "all-n-flat)\r\n\r\nCopyright © CodeDead 2016";
            this.lblAbout.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCodeDead
            // 
            this.btnCodeDead.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.btnCodeDead.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCodeDead.BeforeTouchSize = new System.Drawing.Size(75, 23);
            this.btnCodeDead.ForeColor = System.Drawing.Color.White;
            this.btnCodeDead.IsBackStageButton = false;
            this.btnCodeDead.Location = new System.Drawing.Point(299, 126);
            this.btnCodeDead.MetroColor = System.Drawing.Color.SteelBlue;
            this.btnCodeDead.Name = "btnCodeDead";
            this.btnCodeDead.Size = new System.Drawing.Size(75, 23);
            this.btnCodeDead.TabIndex = 3;
            this.btnCodeDead.Text = "CodeDead";
            this.btnCodeDead.UseVisualStyle = true;
            this.btnCodeDead.UseVisualStyleBackColor = true;
            this.btnCodeDead.Click += new System.EventHandler(this.btnCodeDead_Click);
            // 
            // btnClose
            // 
            this.btnClose.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.btnClose.BackColor = System.Drawing.Color.SteelBlue;
            this.btnClose.BeforeTouchSize = new System.Drawing.Size(75, 23);
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.IsBackStageButton = false;
            this.btnClose.Location = new System.Drawing.Point(12, 126);
            this.btnClose.MetroColor = System.Drawing.Color.SteelBlue;
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyle = true;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPaomedia
            // 
            this.btnPaomedia.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.btnPaomedia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.btnPaomedia.BeforeTouchSize = new System.Drawing.Size(75, 23);
            this.btnPaomedia.ForeColor = System.Drawing.Color.White;
            this.btnPaomedia.IsBackStageButton = false;
            this.btnPaomedia.Location = new System.Drawing.Point(218, 126);
            this.btnPaomedia.MetroColor = System.Drawing.Color.SteelBlue;
            this.btnPaomedia.Name = "btnPaomedia";
            this.btnPaomedia.Size = new System.Drawing.Size(75, 23);
            this.btnPaomedia.TabIndex = 2;
            this.btnPaomedia.Text = "Paomedia";
            this.btnPaomedia.UseVisualStyle = true;
            this.btnPaomedia.UseVisualStyleBackColor = true;
            this.btnPaomedia.Click += new System.EventHandler(this.btnPaomedia_Click);
            // 
            // FrmAbout
            // 
            this.AcceptButton = this.btnCodeDead;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderColor = System.Drawing.Color.SteelBlue;
            this.BorderThickness = 2;
            this.CancelButton = this.btnClose;
            this.CaptionBarColor = System.Drawing.Color.SteelBlue;
            this.CaptionButtonColor = System.Drawing.Color.Black;
            this.CaptionButtonHoverColor = System.Drawing.Color.White;
            this.CaptionForeColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(386, 161);
            this.Controls.Add(this.btnPaomedia);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCodeDead);
            this.Controls.Add(this.pnlAbout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MetroColor = System.Drawing.Color.SteelBlue;
            this.Name = "FrmAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeadHash - About";
            this.pnlAbout.ResumeLayout(false);
            this.pnlAbout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAbout;
        private Syncfusion.Windows.Forms.ButtonAdv btnCodeDead;
        private Syncfusion.Windows.Forms.ButtonAdv btnClose;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblAbout;
        private Syncfusion.Windows.Forms.ButtonAdv btnPaomedia;
    }
}