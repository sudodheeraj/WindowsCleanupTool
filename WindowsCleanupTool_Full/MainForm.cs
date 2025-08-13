using System;
using System.IO;
using System.Windows.Forms;

namespace WindowsCleanupTool
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnCleanup_Click(object sender, EventArgs e)
        {
            string logDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Logs");
            Directory.CreateDirectory(logDir);

            string logFile = Path.Combine(logDir, $"cleanup_{DateTime.Now:yyyyMMdd_HHmmss}.log");

            using (StreamWriter log = new StreamWriter(logFile))
            {
                if (chkTemp.Checked)
                {
                    CleanupHelper.DeleteFolder(Path.GetTempPath(), log);
                }
                if (chkPrefetch.Checked)
                {
                    CleanupHelper.DeleteFolder(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Windows), "Prefetch"), log);
                }
                if (chkRecycleBin.Checked)
                {
                    CleanupHelper.EmptyRecycleBin(log);
                }
                if (chkWindowsUpdate.Checked)
                {
                    CleanupHelper.DeleteFolder(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Windows), "SoftwareDistribution", "Download"), log);
                }
            }

            MessageBox.Show($"Cleanup completed.\nLog saved to:\n{logFile}");
        }
    }
}
