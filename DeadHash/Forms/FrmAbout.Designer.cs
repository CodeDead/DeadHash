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
            this.pnlAbout = new System.Windows.Forms.Panel();
            this.btnCodeDead = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnClose = new Syncfusion.Windows.Forms.ButtonAdv();
            this.SuspendLayout();
            // 
            // pnlAbout
            // 
            this.pnlAbout.BackColor = System.Drawing.Color.LightGray;
            this.pnlAbout.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAbout.Location = new System.Drawing.Point(0, 0);
            this.pnlAbout.Name = "pnlAbout";
            this.pnlAbout.Size = new System.Drawing.Size(386, 120);
            this.pnlAbout.TabIndex = 0;
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
            this.btnCodeDead.TabIndex = 1;
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
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyle = true;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmAbout
            // 
            this.AcceptButton = this.btnCodeDead;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderColor = System.Drawing.Color.SteelBlue;
            this.BorderThickness = 4;
            this.CancelButton = this.btnClose;
            this.CaptionBarColor = System.Drawing.Color.SteelBlue;
            this.CaptionButtonColor = System.Drawing.Color.Black;
            this.CaptionButtonHoverColor = System.Drawing.Color.White;
            this.CaptionForeColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(386, 161);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCodeDead);
            this.Controls.Add(this.pnlAbout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MetroColor = System.Drawing.Color.SteelBlue;
            this.Name = "FrmAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeadHash - About";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAbout;
        private Syncfusion.Windows.Forms.ButtonAdv btnCodeDead;
        private Syncfusion.Windows.Forms.ButtonAdv btnClose;
    }
}