namespace nod32updater_wcf
{
    partial class frmMain
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
            this.btUnpackBase = new System.Windows.Forms.Button();
            this.ssStatus = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.folderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageMain = new System.Windows.Forms.TabPage();
            this.tabPageSettings = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnOpenPathBase = new System.Windows.Forms.Button();
            this.btnOpenPathArh = new System.Windows.Forms.Button();
            this.textBoxPathBase = new System.Windows.Forms.TextBox();
            this.textBoxPathArh = new System.Windows.Forms.TextBox();
            this.textBoxNod32Fn = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNod32User = new System.Windows.Forms.TextBox();
            this.textBoxNod32Pass = new System.Windows.Forms.TextBox();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.groupBoxUpdateFromURL = new System.Windows.Forms.GroupBox();
            this.textBoxURLKey = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnUpdateUserFromURL = new System.Windows.Forms.Button();
            this.btnReadSettings = new System.Windows.Forms.Button();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.textBoxURLNod32Base = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDownloadNod32Base = new System.Windows.Forms.Button();
            this.ssStatus.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageMain.SuspendLayout();
            this.tabPageSettings.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxUpdateFromURL.SuspendLayout();
            this.SuspendLayout();
            // 
            // btUnpackBase
            // 
            this.btUnpackBase.Location = new System.Drawing.Point(307, 316);
            this.btUnpackBase.Name = "btUnpackBase";
            this.btUnpackBase.Size = new System.Drawing.Size(75, 23);
            this.btUnpackBase.TabIndex = 3;
            this.btUnpackBase.Text = "Unpack zip";
            this.btUnpackBase.UseVisualStyleBackColor = true;
            this.btUnpackBase.Click += new System.EventHandler(this.btUnpackBase_Click);
            // 
            // ssStatus
            // 
            this.ssStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripProgressBar1});
            this.ssStatus.Location = new System.Drawing.Point(0, 460);
            this.ssStatus.Name = "ssStatus";
            this.ssStatus.Size = new System.Drawing.Size(808, 22);
            this.ssStatus.TabIndex = 4;
            this.ssStatus.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.AutoSize = false;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(180, 17);
            this.toolStripStatusLabel1.Text = "Status bar text";
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageMain);
            this.tabControl1.Controls.Add(this.tabPageSettings);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(808, 396);
            this.tabControl1.TabIndex = 13;
            // 
            // tabPageMain
            // 
            this.tabPageMain.BackColor = System.Drawing.Color.Transparent;
            this.tabPageMain.Controls.Add(this.btnDownloadNod32Base);
            this.tabPageMain.Controls.Add(this.btUnpackBase);
            this.tabPageMain.Location = new System.Drawing.Point(4, 22);
            this.tabPageMain.Name = "tabPageMain";
            this.tabPageMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMain.Size = new System.Drawing.Size(800, 370);
            this.tabPageMain.TabIndex = 0;
            this.tabPageMain.Text = "Main";
            // 
            // tabPageSettings
            // 
            this.tabPageSettings.BackColor = System.Drawing.Color.Transparent;
            this.tabPageSettings.Controls.Add(this.textBoxURLNod32Base);
            this.tabPageSettings.Controls.Add(this.label1);
            this.tabPageSettings.Controls.Add(this.groupBox2);
            this.tabPageSettings.Controls.Add(this.groupBox1);
            this.tabPageSettings.Controls.Add(this.btnSaveSettings);
            this.tabPageSettings.Controls.Add(this.groupBoxUpdateFromURL);
            this.tabPageSettings.Controls.Add(this.btnReadSettings);
            this.tabPageSettings.Location = new System.Drawing.Point(4, 22);
            this.tabPageSettings.Name = "tabPageSettings";
            this.tabPageSettings.Size = new System.Drawing.Size(800, 370);
            this.tabPageSettings.TabIndex = 3;
            this.tabPageSettings.Text = "Settings";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnOpenPathBase);
            this.groupBox2.Controls.Add(this.btnOpenPathArh);
            this.groupBox2.Controls.Add(this.textBoxPathBase);
            this.groupBox2.Controls.Add(this.textBoxPathArh);
            this.groupBox2.Controls.Add(this.textBoxNod32Fn);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(272, 108);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(520, 116);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Path";
            // 
            // btnOpenPathBase
            // 
            this.btnOpenPathBase.Location = new System.Drawing.Point(472, 81);
            this.btnOpenPathBase.Name = "btnOpenPathBase";
            this.btnOpenPathBase.Size = new System.Drawing.Size(42, 23);
            this.btnOpenPathBase.TabIndex = 4;
            this.btnOpenPathBase.Text = "Open";
            this.btnOpenPathBase.UseVisualStyleBackColor = true;
            this.btnOpenPathBase.Click += new System.EventHandler(this.btnOpenPathBase_Click);
            // 
            // btnOpenPathArh
            // 
            this.btnOpenPathArh.Location = new System.Drawing.Point(472, 49);
            this.btnOpenPathArh.Name = "btnOpenPathArh";
            this.btnOpenPathArh.Size = new System.Drawing.Size(42, 23);
            this.btnOpenPathArh.TabIndex = 2;
            this.btnOpenPathArh.Text = "Open";
            this.btnOpenPathArh.UseVisualStyleBackColor = true;
            this.btnOpenPathArh.Click += new System.EventHandler(this.btnOpenPathArh_Click);
            // 
            // textBoxPathBase
            // 
            this.textBoxPathBase.Location = new System.Drawing.Point(74, 83);
            this.textBoxPathBase.Name = "textBoxPathBase";
            this.textBoxPathBase.Size = new System.Drawing.Size(392, 20);
            this.textBoxPathBase.TabIndex = 3;
            // 
            // textBoxPathArh
            // 
            this.textBoxPathArh.Location = new System.Drawing.Point(74, 51);
            this.textBoxPathArh.Name = "textBoxPathArh";
            this.textBoxPathArh.Size = new System.Drawing.Size(392, 20);
            this.textBoxPathArh.TabIndex = 1;
            // 
            // textBoxNod32Fn
            // 
            this.textBoxNod32Fn.Location = new System.Drawing.Point(74, 19);
            this.textBoxNod32Fn.Name = "textBoxNod32Fn";
            this.textBoxNod32Fn.Size = new System.Drawing.Size(440, 20);
            this.textBoxNod32Fn.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "From";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "To";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "FileName";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxNod32User);
            this.groupBox1.Controls.Add(this.textBoxNod32Pass);
            this.groupBox1.Location = new System.Drawing.Point(8, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 88);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Info";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "User";
            // 
            // textBoxNod32User
            // 
            this.textBoxNod32User.Location = new System.Drawing.Point(74, 19);
            this.textBoxNod32User.Name = "textBoxNod32User";
            this.textBoxNod32User.Size = new System.Drawing.Size(150, 20);
            this.textBoxNod32User.TabIndex = 0;
            // 
            // textBoxNod32Pass
            // 
            this.textBoxNod32Pass.Location = new System.Drawing.Point(74, 51);
            this.textBoxNod32Pass.Name = "textBoxNod32Pass";
            this.textBoxNod32Pass.Size = new System.Drawing.Size(150, 20);
            this.textBoxNod32Pass.TabIndex = 1;
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.Location = new System.Drawing.Point(607, 340);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(185, 23);
            this.btnSaveSettings.TabIndex = 1;
            this.btnSaveSettings.Text = "Save settings";
            this.btnSaveSettings.UseVisualStyleBackColor = true;
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // groupBoxUpdateFromURL
            // 
            this.groupBoxUpdateFromURL.Controls.Add(this.textBoxURLKey);
            this.groupBoxUpdateFromURL.Controls.Add(this.label5);
            this.groupBoxUpdateFromURL.Controls.Add(this.btnUpdateUserFromURL);
            this.groupBoxUpdateFromURL.Location = new System.Drawing.Point(8, 12);
            this.groupBoxUpdateFromURL.Name = "groupBoxUpdateFromURL";
            this.groupBoxUpdateFromURL.Size = new System.Drawing.Size(784, 90);
            this.groupBoxUpdateFromURL.TabIndex = 8;
            this.groupBoxUpdateFromURL.TabStop = false;
            this.groupBoxUpdateFromURL.Text = "URL for nod32key";
            // 
            // textBoxURLKey
            // 
            this.textBoxURLKey.Location = new System.Drawing.Point(41, 25);
            this.textBoxURLKey.Name = "textBoxURLKey";
            this.textBoxURLKey.Size = new System.Drawing.Size(737, 20);
            this.textBoxURLKey.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "URL";
            // 
            // btnUpdateUserFromURL
            // 
            this.btnUpdateUserFromURL.Location = new System.Drawing.Point(41, 51);
            this.btnUpdateUserFromURL.Name = "btnUpdateUserFromURL";
            this.btnUpdateUserFromURL.Size = new System.Drawing.Size(124, 23);
            this.btnUpdateUserFromURL.TabIndex = 1;
            this.btnUpdateUserFromURL.Text = "Update from URL";
            this.btnUpdateUserFromURL.UseVisualStyleBackColor = true;
            // 
            // btnReadSettings
            // 
            this.btnReadSettings.Location = new System.Drawing.Point(607, 311);
            this.btnReadSettings.Name = "btnReadSettings";
            this.btnReadSettings.Size = new System.Drawing.Size(185, 23);
            this.btnReadSettings.TabIndex = 0;
            this.btnReadSettings.Text = "Read settings";
            this.btnReadSettings.UseVisualStyleBackColor = true;
            this.btnReadSettings.Click += new System.EventHandler(this.btnReadSettings_Click);
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(200, 16);
            // 
            // textBoxURLNod32Base
            // 
            this.textBoxURLNod32Base.Location = new System.Drawing.Point(8, 236);
            this.textBoxURLNod32Base.Name = "textBoxURLNod32Base";
            this.textBoxURLNod32Base.Size = new System.Drawing.Size(784, 20);
            this.textBoxURLNod32Base.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "URL Nod32 base";
            // 
            // btnDownloadNod32Base
            // 
            this.btnDownloadNod32Base.Location = new System.Drawing.Point(195, 316);
            this.btnDownloadNod32Base.Name = "btnDownloadNod32Base";
            this.btnDownloadNod32Base.Size = new System.Drawing.Size(75, 23);
            this.btnDownloadNod32Base.TabIndex = 4;
            this.btnDownloadNod32Base.Text = "Download";
            this.btnDownloadNod32Base.UseVisualStyleBackColor = true;
            this.btnDownloadNod32Base.Click += new System.EventHandler(this.btnDownloadNod32Base_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 482);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.ssStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NOD32 Updater";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ssStatus.ResumeLayout(false);
            this.ssStatus.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageMain.ResumeLayout(false);
            this.tabPageSettings.ResumeLayout(false);
            this.tabPageSettings.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxUpdateFromURL.ResumeLayout(false);
            this.groupBoxUpdateFromURL.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip ssStatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.FolderBrowserDialog folderDialog;
        private System.Windows.Forms.Button btUnpackBase;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageMain;
        private System.Windows.Forms.TabPage tabPageSettings;
        private System.Windows.Forms.TextBox textBoxNod32Pass;
        private System.Windows.Forms.TextBox textBoxNod32User;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSaveSettings;
        private System.Windows.Forms.GroupBox groupBoxUpdateFromURL;
        private System.Windows.Forms.TextBox textBoxURLKey;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnUpdateUserFromURL;
        private System.Windows.Forms.Button btnReadSettings;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnOpenPathBase;
        private System.Windows.Forms.Button btnOpenPathArh;
        private System.Windows.Forms.TextBox textBoxPathBase;
        private System.Windows.Forms.TextBox textBoxPathArh;
        private System.Windows.Forms.TextBox textBoxNod32Fn;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.TextBox textBoxURLNod32Base;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDownloadNod32Base;
    }
}

