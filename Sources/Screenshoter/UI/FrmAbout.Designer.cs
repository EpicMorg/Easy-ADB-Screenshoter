namespace Screenshoter.UI
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
            this.BtnSite = new System.Windows.Forms.Button();
            this.PicLogo = new System.Windows.Forms.PictureBox();
            this.BtnMIT = new System.Windows.Forms.Button();
            this.LblName = new System.Windows.Forms.Label();
            this.LblVer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSite
            // 
            this.BtnSite.Image = global::Screenshoter.Properties.Resources.github_alt;
            this.BtnSite.Location = new System.Drawing.Point(163, 42);
            this.BtnSite.Name = "BtnSite";
            this.BtnSite.Size = new System.Drawing.Size(64, 44);
            this.BtnSite.TabIndex = 1;
            this.BtnSite.UseVisualStyleBackColor = true;
            this.BtnSite.Click += new System.EventHandler(this.BtnSite_Click);
            // 
            // PicLogo
            // 
            this.PicLogo.Image = global::Screenshoter.Properties.Resources.google_android;
            this.PicLogo.Location = new System.Drawing.Point(12, 12);
            this.PicLogo.Name = "PicLogo";
            this.PicLogo.Size = new System.Drawing.Size(64, 64);
            this.PicLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PicLogo.TabIndex = 0;
            this.PicLogo.TabStop = false;
            // 
            // BtnMIT
            // 
            this.BtnMIT.Image = global::Screenshoter.Properties.Resources.license_manager;
            this.BtnMIT.Location = new System.Drawing.Point(233, 42);
            this.BtnMIT.Name = "BtnMIT";
            this.BtnMIT.Size = new System.Drawing.Size(64, 44);
            this.BtnMIT.TabIndex = 1;
            this.BtnMIT.UseVisualStyleBackColor = true;
            this.BtnMIT.Click += new System.EventHandler(this.BtnMIT_Click);
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblName.Location = new System.Drawing.Point(82, 12);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(203, 20);
            this.LblName.TabIndex = 2;
            this.LblName.Text = "Easy ADB Screenshoter";
            // 
            // LblVer
            // 
            this.LblVer.AutoSize = true;
            this.LblVer.Location = new System.Drawing.Point(83, 42);
            this.LblVer.Name = "LblVer";
            this.LblVer.Size = new System.Drawing.Size(38, 13);
            this.LblVer.TabIndex = 3;
            this.LblVer.Text = "%ver%";
            // 
            // FrmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 98);
            this.Controls.Add(this.LblVer);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.BtnMIT);
            this.Controls.Add(this.BtnSite);
            this.Controls.Add(this.PicLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAbout";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.FrmAbout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicLogo;
        private System.Windows.Forms.Button BtnSite;
        private System.Windows.Forms.Button BtnMIT;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblVer;
    }
}