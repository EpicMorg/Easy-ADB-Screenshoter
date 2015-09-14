using System;
using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;

namespace Screenshoter.UI
{
    public partial class FrmAbout : Form
    {
        public FrmAbout()
        {
            InitializeComponent();
        }

        private static string AssemblyVersion => Assembly.GetExecutingAssembly().GetName().Version.ToString();

        private void FrmAbout_Load(object sender, EventArgs e)
        {
            LblVer.Text = AssemblyVersion;
        }

        private void BtnSite_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/stamepicmorg/Easy-ADB-Screenshoter");
        }

        private void BtnMIT_Click(object sender, EventArgs e)
        {
            var frmmit = new FrmMit();
            frmmit.ShowDialog();
        }
    }
}
