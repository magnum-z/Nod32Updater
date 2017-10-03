using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace nod32updater_wcf
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void SelectFolder(TextBox textBox)
        {
            string initialFolder = textBox.Text;

            if (!Directory.Exists(initialFolder))
            {
                initialFolder = Application.StartupPath;
            }

            folderDialog.ShowNewFolderButton = false;
            folderDialog.SelectedPath = initialFolder;
            DialogResult dlgResult = folderDialog.ShowDialog();
            if (dlgResult == DialogResult.OK)
            {
                textBox.Text = folderDialog.SelectedPath;
            }
        }

        private void ReadAppConfig()
        {
            textPathFrom.Text = SettingsApp.ReadSetting("PathFrom");
            textPathTo.Text = SettingsApp.ReadSetting("PathTo");
        }

        private void btGetConfig_Click(object sender, EventArgs e)
        {
            llURL.Text = "";
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            llURL.Text = Program.fConfig;            
            ReadAppConfig();
        }

        private void btnPathFrom_Click(object sender, EventArgs e)
        {
            SelectFolder(textPathFrom);
        }

        private void btnPathTo_Click(object sender, EventArgs e)
        {
            SelectFolder(textPathTo);
        }

        private void btnReadAppConfig_Click(object sender, EventArgs e)
        {
            ReadAppConfig();
        }

        private void btnSaveAppConfig_Click(object sender, EventArgs e)
        {
            SettingsApp.SaveSetting("PathFrom", textPathFrom.Text);
            SettingsApp.SaveSetting("PathTo", textPathTo.Text);
        }
    }
}
