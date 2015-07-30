using System; 
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Screenshoter.UI
{
    public partial class FrmAdb : Form
    {
        readonly string _adbPath;
        public FrmAdb(string adbPath)
        {
            _adbPath = adbPath;
            InitializeComponent();
          
        }

        private void FrmAdb_Load(object sender, EventArgs e)
        {
            var p = new Process
            {
                StartInfo =
                {
                    Arguments = "devices",
                    UseShellExecute = false,
                    FileName = _adbPath,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true,
                    StandardOutputEncoding = Encoding.GetEncoding(866)
                }
            };

            p.Start();
            p.WaitForExit();
            var sr = p.StandardOutput;
            var line = sr.ReadToEnd();
            richTextBox1.Text = line; 

            //MessageBox.Show(_adbPath);
            //Process.Start(_adbPath).WaitForExit();

        }
    }
}
