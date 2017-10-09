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
using System.IO.Compression;

namespace nod32updater_wcf
{
    public partial class frmMain : Form
    {
        string strPathFrom;
        string strPathTo;
        string strZip;

        public frmMain()
        {
            InitializeComponent();
        }

        private void SelectFolder(TextBox textBox, string description)
        {
            string initialFolder = textBox.Text;

            if (!Directory.Exists(initialFolder))
            {
                initialFolder = Application.StartupPath;
            }

            folderDialog.ShowNewFolderButton = false;
            folderDialog.SelectedPath = initialFolder;
            folderDialog.Description = description;
            DialogResult dlgResult = folderDialog.ShowDialog();
            if (dlgResult == DialogResult.OK)
            {
                textBox.Text = folderDialog.SelectedPath;
            }
        }

        private void ReadAppConfig()
        {
            strPathFrom = SettingsApp.ReadSetting("PathFrom");
            strPathTo = SettingsApp.ReadSetting("PathTo");
            strZip = SettingsApp.ReadSetting("nod32_zip");
        }

        private void btGetConfig_Click(object sender, EventArgs e)
        {
            llURL.Text = "";
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            llURL.Text = Program.fConfig;

            textBoxUser.Text = Program.AuthUser;
            textBoxPassword.Text = Program.AuthPassword;

            //ReadAppConfig();
            btnReadAppConfig_Click(btnReadAppConfig, null);
        }

        private void btnPathFrom_Click(object sender, EventArgs e)
        {
            SelectFolder(textPathFrom, "Select folder which containes offline_update_eav.zip");
        }

        private void btnPathTo_Click(object sender, EventArgs e)
        {
            SelectFolder(textPathTo, "Select folder where need unpack nod32 base");
        }

        private void btnReadAppConfig_Click(object sender, EventArgs e)
        {
            ReadAppConfig();

            textPathFrom.Text = strPathFrom;
            textPathTo.Text = strPathTo;
        }

        private void btnSaveAppConfig_Click(object sender, EventArgs e)
        {
            SettingsApp.SaveSetting("PathFrom", textPathFrom.Text);
            SettingsApp.SaveSetting("PathTo", textPathTo.Text);            
        }

        private void btUnpackBase_Click(object sender, EventArgs e)
        {            
            Array.ForEach(Directory.GetFiles(strPathTo), File.Delete);
            ZipFile.ExtractToDirectory(strPathFrom + "\\" + strZip, strPathTo);            
        }
    }
}
