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
            resources.ApplyResources(this.GbAdb, "GbAdb");
            this.GbAdb.Controls.Add(this.TxtScreenFilename);
            this.GbAdb.Controls.Add(this.TxtScreenPath);
            this.GbAdb.Controls.Add(this.LblScreenFilename);
            this.GbAdb.Controls.Add(this.LblScreenPath);
            this.GbAdb.Controls.Add(this.BtnAdbPath);
            this.GbAdb.Controls.Add(this.TxtAdbPath);
            this.GbAdb.Controls.Add(this.ChkAdb);
            this.GbAdb.Name = "GbAdb";
            this.GbAdb.TabStop = false;
            // 
            // TxtScreenFilename
            // 
            resources.ApplyResources(this.TxtScreenFilename, "TxtScreenFilename");
            this.TxtScreenFilename.Name = "TxtScreenFilename";
            // 
            // TxtScreenPath
            // 
            resources.ApplyResources(this.TxtScreenPath, "TxtScreenPath");
            this.TxtScreenPath.Name = "TxtScreenPath";
            // 
            // LblScreenFilename
            // 
            resources.ApplyResources(this.LblScreenFilename, "LblScreenFilename");
            this.LblScreenFilename.Name = "LblScreenFilename";
            // 
            // LblScreenPath
            // 
            resources.ApplyResources(this.LblScreenPath, "LblScreenPath");
            this.LblScreenPath.Name = "LblScreenPath";
            // 
            // BtnAdbPath
            // 
            resources.ApplyResources(this.BtnAdbPath, "BtnAdbPath");
            this.BtnAdbPath.Name = "BtnAdbPath";
            this.BtnAdbPath.UseVisualStyleBackColor = true;
            this.BtnAdbPath.Click += new System.EventHandler(this.BtnAdbPath_Click);
            // 
            // TxtAdbPath
            // 
            resources.ApplyResources(this.TxtAdbPath, "TxtAdbPath");
            this.TxtAdbPath.Name = "TxtAdbPath";
            this.TxtAdbPath.ReadOnly = true;
            // 
            // ChkAdb
            // 
            resources.ApplyResources(this.ChkAdb, "ChkAdb");
            this.ChkAdb.ForeColor = System.Drawing.Color.Black;
            this.ChkAdb.Name = "ChkAdb";
            this.ChkAdb.UseVisualStyleBackColor = true;
            this.ChkAdb.CheckedChanged += new System.EventHandler(this.ChkAdb_CheckedChanged);
            // 
            // IpCustomDeviceIp
            // 
            resources.ApplyResources(this.IpCustomDeviceIp, "IpCustomDeviceIp");
            this.IpCustomDeviceIp.AllowInternalTab = false;
            this.IpCustomDeviceIp.AutoHeight = true;
            this.IpCustomDeviceIp.BackColor = System.Drawing.SystemColors.Window;
            this.IpCustomDeviceIp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.IpCustomDeviceIp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.IpCustomDeviceIp.Name = "IpCustomDeviceIp";
            this.IpCustomDeviceIp.ReadOnly = false;
            // 
            // GbCustomDevice
            // 
            resources.ApplyResources(this.GbCustomDevice, "GbCustomDevice");
            this.GbCustomDevice.Controls.Add(this.BtnCustomDeviceSelect);
            this.GbCustomDevice.Controls.Add(this.IpCustomDeviceIp);
            this.GbCustomDevice.Controls.Add(this.TxtCustomDevicePort);
            this.GbCustomDevice.Name = "GbCustomDevice";
            this.GbCustomDevice.TabStop = false;
            // 
            // BtnCustomDeviceSelect
            // 
            resources.ApplyResources(this.BtnCustomDeviceSelect, "BtnCustomDeviceSelect");
            this.BtnCustomDeviceSelect.Name = "BtnCustomDeviceSelect";
            this.BtnCustomDeviceSelect.UseVisualStyleBackColor = true;
            this.BtnCustomDeviceSelect.Click += new System.EventHandler(this.BtnCustomDeviceSelect_Click);
            // 
            // TxtCustomDevicePort
            // 
            resources.ApplyResources(this.TxtCustomDevicePort, "TxtCustomDevicePort");
            this.TxtCustomDevicePort.Name = "TxtCustomDevicePort";
            // 
            // ChkCustomDevice
            // 
            resources.ApplyResources(this.ChkCustomDevice, "ChkCustomDevice");
            this.ChkCustomDevice.Name = "ChkCustomDevice";
            this.ChkCustomDevice.UseVisualStyleBackColor = true;
            this.ChkCustomDevice.CheckedChanged += new System.EventHandler(this.ChkCustomDevice_CheckedChanged);
            // 
            // ChkCustomPath
            // 
            resources.ApplyResources(this.ChkCustomPath, "ChkCustomPath");
            this.ChkCustomPath.Name = "ChkCustomPath";
            this.ChkCustomPath.UseVisualStyleBackColor = true;
            this.ChkCustomPath.CheckedChanged += new System.EventHandler(this.ChkCustomPath_CheckedChanged);
            // 
            // GbCustomPath
            // 
            resources.ApplyResources(this.GbCustomPath, "GbCustomPath");
            this.GbCustomPath.Controls.Add(this.BtnCustomPath);
            this.GbCustomPath.Controls.Add(this.TxtCustomPath);
            this.GbCustomPath.Name = "GbCustomPath";
            this.GbCustomPath.TabStop = false;
            // 
            // BtnCustomPath
            // 
            resources.ApplyResources(this.BtnCustomPath, "BtnCustomPath");
            this.BtnCustomPath.Name = "BtnCustomPath";
            this.BtnCustomPath.UseVisualStyleBackColor = true;
            this.BtnCustomPath.Click += new System.EventHandler(this.BtnCustomPath_Click);
            // 
            // TxtCustomPath
            // 
            resources.ApplyResources(this.TxtCustomPath, "TxtCustomPath");
            this.TxtCustomPath.Name = "TxtCustomPath";
            this.TxtCustomPath.ReadOnly = true;
            // 
            // notifyIcon
            // 
            resources.ApplyResources(this.notifyIcon, "notifyIcon");
            this.notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseClick);
            // 
            // BtnTakeMeToChurch
            // 
            resources.ApplyResources(this.BtnTakeMeToChurch, "BtnTakeMeToChurch");
            this.BtnTakeMeToChurch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnTakeMeToChurch.Image = global::Screenshoter.Properties.Resources.photo;
            this.BtnTakeMeToChurch.Name = "BtnTakeMeToChurch";
            this.BtnTakeMeToChurch.UseVisualStyleBackColor = true;
            this.BtnTakeMeToChurch.Click += new System.EventHandler(this.BtnTakeMeToChurch_Click);
            // 
            // FrmMain
            // 
            this.AcceptButton = this.BtnTakeMeToChurch;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnTakeMeToChurch);
            this.Controls.Add(this.ChkCustomPath);
            this.Controls.Add(this.GbCustomPath);
            this.Controls.Add(this.ChkCustomDevice);
            this.Controls.Add(this.GbAdb);
            this.Controls.Add(this.GbCustomDevice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
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

