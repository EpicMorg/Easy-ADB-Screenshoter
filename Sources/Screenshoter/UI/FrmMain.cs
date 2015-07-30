using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Text; 
using System.Windows.Forms;

namespace Screenshoter.UI
{
    public sealed partial class FrmMain : Form
    {
        private string _adbPath;
        private FormWindowState _oldFormState;
        private int _procId;

        public FrmMain()
        {
            InitializeComponent();
            Text = Text + @" " + AssemblyVersion;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            notifyIcon.Text = Text;
            notifyIcon.MouseClick += notifyIcon_MouseClick;
            Resize += FormForTray_Resize;
            AdbCheck();
        }

        #region Core Magic 

        private void AdbCheck()
        {
            if (!File.Exists(TxtAdbPath.Text))
            {
                ChkAdb.Checked = false;
                ChkAdb.Text = @"Adb not found!";
                var openFileDialog = new OpenFileDialog
                {
                    FileName = "adb.exe",
                    CheckFileExists = true,
                    Multiselect = false,
                    AutoUpgradeEnabled = true,
                    AddExtension = true
                };
                openFileDialog.AutoUpgradeEnabled = true;
                openFileDialog.Filter = @"ADB|adb.exe";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    TxtAdbPath.Text = openFileDialog.FileName;
                    ChkAdb.Checked = true;
                    ChkAdb.Text = @"Adb founded!";
                    notifyIcon.BalloonTipIcon = ToolTipIcon.Info;
                    notifyIcon.BalloonTipTitle = Text;
                    notifyIcon.BalloonTipText =
                        @"Готово к работе.";
                    notifyIcon.ShowBalloonTip(30000);
                }
                else
                {
                    AdbCheck();
                }
            }
            else
            {
                TxtAdbPath.Text = Path.Combine(Application.StartupPath, "adb.exe");
                ChkAdb.Checked = true;
                ChkAdb.Text = @"Adb founded!";
            }
        }

        #endregion

        private void BtnCustomDeviceSelect_Click(object sender, EventArgs e)
        {
            var frmadb = new FrmAdb(TxtAdbPath.Text);
            frmadb.ShowDialog();
        }

        private void BtnAdbPath_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog
            {
                FileName = "adb.exe",
                CheckFileExists = true,
                Multiselect = false,
                AutoUpgradeEnabled = true,
                AddExtension = true
            };
            openFileDialog.AutoUpgradeEnabled = true;
            openFileDialog.Filter = @"ADB|adb.exe";
            if (openFileDialog.ShowDialog() != DialogResult.OK) return;
            TxtAdbPath.Text = openFileDialog.FileName;
            ChkAdb.Checked = true;
            ChkAdb.Text = @"Adb founded!";
        }

        private void BtnTakeMeToChurch_Click(object sender, EventArgs e)
        {
            BtnTakeMeToChurch.Enabled = false;
            _adbPath = TxtAdbPath.Text;
            var ip = IpCustomDeviceIp.Text;
            var port = TxtCustomDevicePort.Text;
            var rnd = new Random();
            var addToName = rnd.Next(1, 9999);
            var path = TxtScreenPath.Text;
            var screenshot = TxtScreenFilename.Text;
            var finalfilepath = TxtCustomPath.Text;
            if (ChkCustomDevice.Checked)
            {
                if (!string.IsNullOrWhiteSpace(ip) && !string.IsNullOrWhiteSpace(port))
                {
                    // adb connect [host:port]

                    try
                    {
                        var p0 = new Process
                        {
                            StartInfo =
                            {
                                Arguments = "connect " + ip + ":" + port,
                                UseShellExecute = false,
                                FileName = _adbPath,
                                RedirectStandardOutput = true,
                                CreateNoWindow = true,
                                StandardOutputEncoding = Encoding.GetEncoding(866)
                            }
                        };
                        p0.Start();
                        p0.WaitForExit();
                       
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), @"Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show(@"Enter IP and Port!", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            //adb shell screencap -p / sdcard / screenshot_%random%.png
            //MessageBox.Show(_adbPath + " shell screencap -p " + path + screenshot + "_" + addToName + ".png");
            try
            {
                var p1 = new Process
                {
                    StartInfo =
                    {
                        Arguments = "shell screencap -p " + path + screenshot + "_" + addToName + ".png",
                        UseShellExecute = false,
                        FileName = _adbPath,
                        RedirectStandardOutput = true,
                        CreateNoWindow = true,
                        StandardOutputEncoding = Encoding.GetEncoding(866)
                    }
                };
                p1.Start();
                p1.WaitForExit();
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.ToString(), @"Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            //adb pull / sdcard / screenshot_%random%.png
            //MessageBox.Show(_adbPath + " pull " + path + screenshot + "_" + addToName + ".png");
            try
            {
                var p2 = new Process
                {
                    StartInfo =
                    {
                        Arguments = "pull " + path + screenshot + "_" + addToName + ".png",
                        UseShellExecute = false,
                        FileName = _adbPath,
                        RedirectStandardOutput = true,
                        CreateNoWindow = true,
                        StandardOutputEncoding = Encoding.GetEncoding(866)
                    }
                };
                p2.Start();
                p2.WaitForExit();
            }
            catch (Exception ex2)
            {
                MessageBox.Show(ex2.ToString(), @"Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            //adb shell rm / sdcard / screen_10_ % _rand %.png
            //MessageBox.Show(_adbPath + " shell rm " + path + screenshot + "_" + addToName + ".png");
            try
            {
                var p3 = new Process
                {
                    StartInfo =
                    {
                        Arguments = "shell rm " + path + screenshot + "_" + addToName + ".png",
                        UseShellExecute = false,
                        FileName = _adbPath,
                        RedirectStandardOutput = true,
                        CreateNoWindow = true,
                        StandardOutputEncoding = Encoding.GetEncoding(866)
                    }
                };
                p3.Start();
                p3.WaitForExit();
            }
            catch (Exception ex3)
            {
                MessageBox.Show(ex3.ToString(), @"Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if (ChkCustomPath.Checked)
            {
                if (string.IsNullOrWhiteSpace(finalfilepath))
                {
                    MessageBox.Show(@"File was saved but not copied 'cause you not selected your putput directory!",
                        @"Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else
                {
                    //MessageBox.Show(Path.Combine(finalfilepath, screenshot + "_" + addToName + ".png"));
                    try
                    {
                        File.Move(screenshot + "_" + addToName + ".png",
                            Path.Combine(finalfilepath, screenshot + "_" + addToName + ".png")); // Try to move
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), @"Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            notifyIcon.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon.BalloonTipTitle = Text;
            notifyIcon.BalloonTipText = @"Скриншот сделан!";
            notifyIcon.ShowBalloonTip(10000);
            BtnTakeMeToChurch.Enabled = true;
        }

        private void BtnCustomPath_Click(object sender, EventArgs e)
        {
            var folderBrowserDialog = new FolderBrowserDialog
            {
                RootFolder = Environment.SpecialFolder.Desktop,
                ShowNewFolderButton = true
            };
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                TxtCustomPath.Text = folderBrowserDialog.SelectedPath;
            }
        }

        #region UI Magic

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            notifyIcon.Visible = false;
        }

        private static string AssemblyVersion => Assembly.GetExecutingAssembly().GetName().Version.ToString();

        private void notifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            FromMinimize();
        }

        private void FormForTray_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized != WindowState) return;
            notifyIcon.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon.BalloonTipText = @"Программа была свернута. Найти ее можно здесь.";
            notifyIcon.ShowBalloonTip(30000);
            Hide();
        }

        private void FromMinimize()
        {
            if (WindowState == FormWindowState.Normal || WindowState == FormWindowState.Maximized)
            {
                _oldFormState = WindowState;
            }
            else
            {
                Show();
                WindowState = _oldFormState;
            }
        }

        private void ChkCustomDevice_CheckedChanged(object sender, EventArgs e)
        {
            IpCustomDeviceIp.Enabled = TxtCustomDevicePort.Enabled = ChkCustomDevice.Checked;
        }

        private void ChkCustomPath_CheckedChanged(object sender, EventArgs e)
        {
            GbCustomPath.Enabled = ChkCustomPath.Checked;
        }

        #endregion

        
    }
}