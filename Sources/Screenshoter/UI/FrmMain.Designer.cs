namespace Screenshoter.UI
{
    sealed partial class FrmMain
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.GbAdb = new System.Windows.Forms.GroupBox();
            this.TxtScreenFilename = new System.Windows.Forms.TextBox();
            this.TxtScreenPath = new System.Windows.Forms.TextBox();
            this.LblScreenFilename = new System.Windows.Forms.Label();
            this.LblScreenPath = new System.Windows.Forms.Label();
            this.BtnAdbPath = new System.Windows.Forms.Button();
            this.TxtAdbPath = new System.Windows.Forms.TextBox();
            this.ChkAdb = new System.Windows.Forms.CheckBox();
            this.IpCustomDeviceIp = new IPAddressControlLib.IPAddressControl();
            this.GbCustomDevice = new System.Windows.Forms.GroupBox();
            this.BtnCustomDeviceSelect = new System.Windows.Forms.Button();
            this.TxtCustomDevicePort = new System.Windows.Forms.TextBox();
            this.ChkCustomDevice = new System.Windows.Forms.CheckBox();
            this.ChkCustomPath = new System.Windows.Forms.CheckBox();
            this.GbCustomPath = new System.Windows.Forms.GroupBox();
            this.BtnCustomPath = new System.Windows.Forms.Button();
            this.TxtCustomPath = new System.Windows.Forms.TextBox();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.BtnTakeMeToChurch = new System.Windows.Forms.Button();
            this.GbAdb.SuspendLayout();
            this.GbCustomDevice.SuspendLayout();
            this.GbCustomPath.SuspendLayout();
            this.SuspendLayout();
            // 
            // GbAdb
            // 
            this.GbAdb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GbAdb.Controls.Add(this.TxtScreenFilename);
            this.GbAdb.Controls.Add(this.TxtScreenPath);
            this.GbAdb.Controls.Add(this.LblScreenFilename);
            this.GbAdb.Controls.Add(this.LblScreenPath);
            this.GbAdb.Controls.Add(this.BtnAdbPath);
            this.GbAdb.Controls.Add(this.TxtAdbPath);
            this.GbAdb.Controls.Add(this.ChkAdb);
            this.GbAdb.Location = new System.Drawing.Point(12, 12);
            this.GbAdb.Name = "GbAdb";
            this.GbAdb.Size = new System.Drawing.Size(460, 134);
            this.GbAdb.TabIndex = 0;
            this.GbAdb.TabStop = false;
            // 
            // TxtScreenFilename
            // 
            this.TxtScreenFilename.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtScreenFilename.Location = new System.Drawing.Point(6, 101);
            this.TxtScreenFilename.Name = "TxtScreenFilename";
            this.TxtScreenFilename.Size = new System.Drawing.Size(448, 20);
            this.TxtScreenFilename.TabIndex = 4;
            this.TxtScreenFilename.Text = "screenshot";
            // 
            // TxtScreenPath
            // 
            this.TxtScreenPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtScreenPath.Location = new System.Drawing.Point(6, 62);
            this.TxtScreenPath.Name = "TxtScreenPath";
            this.TxtScreenPath.Size = new System.Drawing.Size(448, 20);
            this.TxtScreenPath.TabIndex = 4;
            this.TxtScreenPath.Text = "/sdcard/";
            // 
            // LblScreenFilename
            // 
            this.LblScreenFilename.AutoSize = true;
            this.LblScreenFilename.Location = new System.Drawing.Point(6, 85);
            this.LblScreenFilename.Name = "LblScreenFilename";
            this.LblScreenFilename.Size = new System.Drawing.Size(254, 13);
            this.LblScreenFilename.TabIndex = 3;
            this.LblScreenFilename.Text = "File name (.png extension will be added automaticly):";
            // 
            // LblScreenPath
            // 
            this.LblScreenPath.AutoSize = true;
            this.LblScreenPath.Location = new System.Drawing.Point(6, 46);
            this.LblScreenPath.Name = "LblScreenPath";
            this.LblScreenPath.Size = new System.Drawing.Size(138, 13);
            this.LblScreenPath.TabIndex = 3;
            this.LblScreenPath.Text = "Screenshot path on device:";
            // 
            // BtnAdbPath
            // 
            this.BtnAdbPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAdbPath.Location = new System.Drawing.Point(379, 21);
            this.BtnAdbPath.Name = "BtnAdbPath";
            this.BtnAdbPath.Size = new System.Drawing.Size(75, 23);
            this.BtnAdbPath.TabIndex = 2;
            this.BtnAdbPath.Text = "Browse";
            this.BtnAdbPath.UseVisualStyleBackColor = true;
            this.BtnAdbPath.Click += new System.EventHandler(this.BtnAdbPath_Click);
            // 
            // TxtAdbPath
            // 
            this.TxtAdbPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtAdbPath.Location = new System.Drawing.Point(6, 23);
            this.TxtAdbPath.Name = "TxtAdbPath";
            this.TxtAdbPath.ReadOnly = true;
            this.TxtAdbPath.Size = new System.Drawing.Size(367, 20);
            this.TxtAdbPath.TabIndex = 1;
            this.TxtAdbPath.Text = "adb.exe";
            // 
            // ChkAdb
            // 
            this.ChkAdb.AutoSize = true;
            this.ChkAdb.ForeColor = System.Drawing.Color.DarkRed;
            this.ChkAdb.Location = new System.Drawing.Point(6, 0);
            this.ChkAdb.Name = "ChkAdb";
            this.ChkAdb.Size = new System.Drawing.Size(96, 17);
            this.ChkAdb.TabIndex = 0;
            this.ChkAdb.Text = "Adb not found!";
            this.ChkAdb.UseVisualStyleBackColor = true;
            // 
            // IpCustomDeviceIp
            // 
            this.IpCustomDeviceIp.AllowInternalTab = false;
            this.IpCustomDeviceIp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IpCustomDeviceIp.AutoHeight = true;
            this.IpCustomDeviceIp.BackColor = System.Drawing.SystemColors.Window;
            this.IpCustomDeviceIp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.IpCustomDeviceIp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.IpCustomDeviceIp.Enabled = false;
            this.IpCustomDeviceIp.Location = new System.Drawing.Point(6, 23);
            this.IpCustomDeviceIp.MinimumSize = new System.Drawing.Size(87, 20);
            this.IpCustomDeviceIp.Name = "IpCustomDeviceIp";
            this.IpCustomDeviceIp.ReadOnly = false;
            this.IpCustomDeviceIp.Size = new System.Drawing.Size(296, 20);
            this.IpCustomDeviceIp.TabIndex = 1;
            this.IpCustomDeviceIp.Text = "...";
            // 
            // GbCustomDevice
            // 
            this.GbCustomDevice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GbCustomDevice.Controls.Add(this.BtnCustomDeviceSelect);
            this.GbCustomDevice.Controls.Add(this.IpCustomDeviceIp);
            this.GbCustomDevice.Controls.Add(this.TxtCustomDevicePort);
            this.GbCustomDevice.Location = new System.Drawing.Point(12, 153);
            this.GbCustomDevice.Name = "GbCustomDevice";
            this.GbCustomDevice.Size = new System.Drawing.Size(460, 58);
            this.GbCustomDevice.TabIndex = 2;
            this.GbCustomDevice.TabStop = false;
            // 
            // BtnCustomDeviceSelect
            // 
            this.BtnCustomDeviceSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCustomDeviceSelect.Location = new System.Drawing.Point(379, 21);
            this.BtnCustomDeviceSelect.Name = "BtnCustomDeviceSelect";
            this.BtnCustomDeviceSelect.Size = new System.Drawing.Size(75, 23);
            this.BtnCustomDeviceSelect.TabIndex = 2;
            this.BtnCustomDeviceSelect.Text = "Devices";
            this.BtnCustomDeviceSelect.UseVisualStyleBackColor = true;
            this.BtnCustomDeviceSelect.Click += new System.EventHandler(this.BtnCustomDeviceSelect_Click);
            // 
            // TxtCustomDevicePort
            // 
            this.TxtCustomDevicePort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtCustomDevicePort.Enabled = false;
            this.TxtCustomDevicePort.Location = new System.Drawing.Point(308, 23);
            this.TxtCustomDevicePort.Name = "TxtCustomDevicePort";
            this.TxtCustomDevicePort.Size = new System.Drawing.Size(65, 20);
            this.TxtCustomDevicePort.TabIndex = 1;
            // 
            // ChkCustomDevice
            // 
            this.ChkCustomDevice.AutoSize = true;
            this.ChkCustomDevice.Location = new System.Drawing.Point(18, 152);
            this.ChkCustomDevice.Name = "ChkCustomDevice";
            this.ChkCustomDevice.Size = new System.Drawing.Size(164, 17);
            this.ChkCustomDevice.TabIndex = 0;
            this.ChkCustomDevice.Text = "Select custom device (via IP)";
            this.ChkCustomDevice.UseVisualStyleBackColor = true;
            this.ChkCustomDevice.CheckedChanged += new System.EventHandler(this.ChkCustomDevice_CheckedChanged);
            // 
            // ChkCustomPath
            // 
            this.ChkCustomPath.AutoSize = true;
            this.ChkCustomPath.Location = new System.Drawing.Point(18, 216);
            this.ChkCustomPath.Name = "ChkCustomPath";
            this.ChkCustomPath.Size = new System.Drawing.Size(166, 17);
            this.ChkCustomPath.TabIndex = 3;
            this.ChkCustomPath.Text = "Save screenshos at this path:";
            this.ChkCustomPath.UseVisualStyleBackColor = true;
            this.ChkCustomPath.CheckedChanged += new System.EventHandler(this.ChkCustomPath_CheckedChanged);
            // 
            // GbCustomPath
            // 
            this.GbCustomPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GbCustomPath.Controls.Add(this.BtnCustomPath);
            this.GbCustomPath.Controls.Add(this.TxtCustomPath);
            this.GbCustomPath.Enabled = false;
            this.GbCustomPath.Location = new System.Drawing.Point(12, 217);
            this.GbCustomPath.Name = "GbCustomPath";
            this.GbCustomPath.Size = new System.Drawing.Size(460, 58);
            this.GbCustomPath.TabIndex = 4;
            this.GbCustomPath.TabStop = false;
            // 
            // BtnCustomPath
            // 
            this.BtnCustomPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCustomPath.Location = new System.Drawing.Point(379, 21);
            this.BtnCustomPath.Name = "BtnCustomPath";
            this.BtnCustomPath.Size = new System.Drawing.Size(75, 23);
            this.BtnCustomPath.TabIndex = 2;
            this.BtnCustomPath.Text = "Browse";
            this.BtnCustomPath.UseVisualStyleBackColor = true;
            this.BtnCustomPath.Click += new System.EventHandler(this.BtnCustomPath_Click);
            // 
            // TxtCustomPath
            // 
            this.TxtCustomPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtCustomPath.Location = new System.Drawing.Point(6, 23);
            this.TxtCustomPath.Name = "TxtCustomPath";
            this.TxtCustomPath.ReadOnly = true;
            this.TxtCustomPath.Size = new System.Drawing.Size(367, 20);
            this.TxtCustomPath.TabIndex = 1;
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "notifyIcon1";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseClick);
            // 
            // BtnTakeMeToChurch
            // 
            this.BtnTakeMeToChurch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnTakeMeToChurch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnTakeMeToChurch.Image = global::Screenshoter.Properties.Resources.photo;
            this.BtnTakeMeToChurch.Location = new System.Drawing.Point(320, 281);
            this.BtnTakeMeToChurch.Name = "BtnTakeMeToChurch";
            this.BtnTakeMeToChurch.Size = new System.Drawing.Size(152, 112);
            this.BtnTakeMeToChurch.TabIndex = 5;
            this.BtnTakeMeToChurch.UseVisualStyleBackColor = true;
            this.BtnTakeMeToChurch.Click += new System.EventHandler(this.BtnTakeMeToChurch_Click);
            // 
            // FrmMain
            // 
            this.AcceptButton = this.BtnTakeMeToChurch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 405);
            this.Controls.Add(this.BtnTakeMeToChurch);
            this.Controls.Add(this.ChkCustomPath);
            this.Controls.Add(this.GbCustomPath);
            this.Controls.Add(this.ChkCustomDevice);
            this.Controls.Add(this.GbAdb);
            this.Controls.Add(this.GbCustomDevice);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(500, 350);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Android ADB Screenshoter";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.GbAdb.ResumeLayout(false);
            this.GbAdb.PerformLayout();
            this.GbCustomDevice.ResumeLayout(false);
            this.GbCustomDevice.PerformLayout();
            this.GbCustomPath.ResumeLayout(false);
            this.GbCustomPath.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GbAdb;
        private System.Windows.Forms.CheckBox ChkAdb;
        private IPAddressControlLib.IPAddressControl IpCustomDeviceIp;
        private System.Windows.Forms.Button BtnAdbPath;
        private System.Windows.Forms.TextBox TxtAdbPath;
        private System.Windows.Forms.GroupBox GbCustomDevice;
        private System.Windows.Forms.Button BtnCustomDeviceSelect;
        private System.Windows.Forms.TextBox TxtCustomDevicePort;
        private System.Windows.Forms.CheckBox ChkCustomDevice;
        private System.Windows.Forms.CheckBox ChkCustomPath;
        private System.Windows.Forms.GroupBox GbCustomPath;
        private System.Windows.Forms.Button BtnCustomPath;
        private System.Windows.Forms.TextBox TxtCustomPath;
        private System.Windows.Forms.Button BtnTakeMeToChurch;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Label LblScreenPath;
        private System.Windows.Forms.TextBox TxtScreenFilename;
        private System.Windows.Forms.TextBox TxtScreenPath;
        private System.Windows.Forms.Label LblScreenFilename;
    }
}

