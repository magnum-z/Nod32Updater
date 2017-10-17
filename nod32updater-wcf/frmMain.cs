using System;
using System.ComponentModel;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Windows.Forms;

namespace nod32updater_wcf
{
    public partial class frmMain : Form
    {
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

        private void ReadSettings()
        {
            Config.url_key = SettingsApp.ReadSetting("url_key");
            Config.nod32_user = SettingsApp.ReadSetting("nod32_user");
            Config.nod32_pass = SettingsApp.ReadSetting("nod32_pass");
            Config.nod32_fn = SettingsApp.ReadSetting("nod32_fn");
            Config.path_arh = SettingsApp.ReadSetting("path_arh");
            Config.path_base = SettingsApp.ReadSetting("path_base");
            Config.url_base = SettingsApp.ReadSetting("url_base");
        }

        private void SaveSettings()
        {
            SettingsApp.SaveSetting("url_key", Config.url_key);
            SettingsApp.SaveSetting("nod32_user", Config.nod32_user);
            SettingsApp.SaveSetting("nod32_pass", Config.nod32_pass);
            SettingsApp.SaveSetting("nod32_fn", Config.nod32_fn);
            SettingsApp.SaveSetting("path_arh", Config.path_arh);
            SettingsApp.SaveSetting("path_base", Config.path_base);
            SettingsApp.SaveSetting("url_base", Config.url_base);
        }

        private void UpdateControlsFromSettings()
        {
            textBoxURLKey.Text = Config.url_key;
            textBoxNod32User.Text = Config.nod32_user;
            textBoxNod32Pass.Text = Config.nod32_pass;
            textBoxNod32Fn.Text = Config.nod32_fn;
            textBoxPathArh.Text = Config.path_arh;
            textBoxPathBase.Text = Config.path_base;
            textBoxURLNod32Base.Text = Config.url_base;
        }

        private void UpdateSettingsFromControls()
        {
            Config.url_key = textBoxURLKey.Text;
            Config.nod32_user = textBoxNod32User.Text;
            Config.nod32_pass = textBoxNod32Pass.Text;
            Config.nod32_fn = textBoxNod32Fn.Text;
            Config.path_arh = textBoxPathArh.Text;
            Config.path_base = textBoxPathBase.Text;
            Config.url_base = textBoxURLNod32Base.Text;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            ReadSettings();
            UpdateControlsFromSettings();
        }        

        private void btUnpackBase_Click(object sender, EventArgs e)
        {            
            Array.ForEach(Directory.GetFiles(Config.path_base), File.Delete);
            ZipFile.ExtractToDirectory(Config.path_arh + Config.nod32_fn, Config.path_base);            
        }

        private void btnOpenPathArh_Click(object sender, EventArgs e)
        {
            SelectFolder(textBoxPathArh, "Select folder which containes " + Config.nod32_fn);
        }

        private void btnOpenPathBase_Click(object sender, EventArgs e)
        {
            SelectFolder(textBoxPathBase, "Select folder where need unpack nod32 base");
        }

        private void btnReadSettings_Click(object sender, EventArgs e)
        {
            ReadSettings();
            UpdateControlsFromSettings();
        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            UpdateSettingsFromControls();
            SaveSettings();
        }

        private void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            double bytesIn = double.Parse(e.BytesReceived.ToString());
            double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
            double percentage = bytesIn / totalBytes * 100;

            toolStripProgressBar1.Value = int.Parse(Math.Truncate(percentage).ToString());
        }

        private void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            toolStripStatusLabel1.Text = "Download completed";
            btnDownloadNod32Base.Enabled = true;
        }
        
        private void btnDownloadNod32Base_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(Config.path_arh))
            {
                //try
                {
                    toolStripStatusLabel1.Text = "Downloading ...";
                    toolStripProgressBar1.Value = 0;
                    string filename;

                    WebClient client = new WebClient();
                    client.Credentials = null;
                    Uri uri = new Uri(Config.url_base);
                    filename = Path.GetFileName(uri.LocalPath);

                    client.Credentials = new NetworkCredential(Config.nod32_user, Config.nod32_pass);
                    
                    client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
                    client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
                    client.DownloadFileAsync(uri, Config.path_arh + Config.nod32_fn);
                    btnDownloadNod32Base.Enabled = false;
                }
                //catch
                {
                    //  toolStripStatusLabel1.Text = "Error downloading file";
                }
            }
        }
    }
}
