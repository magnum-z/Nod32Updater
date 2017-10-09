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
            this.lbURL = new System.Windows.Forms.Label();
            this.llURL = new System.Windows.Forms.LinkLabel();
            this.btGetConfig = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btUnpackBase = new System.Windows.Forms.Button();
            this.ssStatus = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textPathTo = new System.Windows.Forms.TextBox();
            this.textPathFrom = new System.Windows.Forms.TextBox();
            this.btnPathTo = new System.Windows.Forms.Button();
            this.btnPathFrom = new System.Windows.Forms.Button();
            this.folderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.btnReadAppConfig = new System.Windows.Forms.Button();
            this.btnSaveAppConfig = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPageGetUserPassword = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.btnReadUserFromXML = new System.Windows.Forms.Button();
            this.btnUpdateUserFromURL = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBoxUpdateFromURL = new System.Windows.Forms.GroupBox();
            this.btnSaveUserToXML = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.ssStatus.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageGetUserPassword.SuspendLayout();
            this.groupBoxUpdateFromURL.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbURL
            // 
            this.lbURL.AutoSize = true;
            this.lbURL.Location = new System.Drawing.Point(12, 305);
            this.lbURL.Name = "lbURL";
            this.lbURL.Size = new System.Drawing.Size(29, 13);
            this.lbURL.TabIndex = 0;
            this.lbURL.Text = "URL";
            // 
            // llURL
            // 
            this.llURL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.llURL.Location = new System.Drawing.Point(47, 305);
            this.llURL.Name = "llURL";
            this.llURL.Size = new System.Drawing.Size(749, 13);
            this.llURL.TabIndex = 1;
            // 
            // btGetConfig
            // 
            this.btGetConfig.Location = new System.Drawing.Point(20, 12);
            this.btGetConfig.Name = "btGetConfig";
            this.btGetConfig.Size = new System.Drawing.Size(75, 23);
            this.btGetConfig.TabIndex = 2;
            this.btGetConfig.Text = "Get config";
            this.btGetConfig.UseVisualStyleBackColor = true;
            this.btGetConfig.Click += new System.EventHandler(this.btGetConfig_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btUnpackBase);
            this.panel1.Controls.Add(this.btGetConfig);
            this.panel1.Location = new System.Drawing.Point(12, 348);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 50);
            this.panel1.TabIndex = 3;
            // 
            // btUnpackBase
            // 
            this.btUnpackBase.Location = new System.Drawing.Point(101, 12);
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
            this.toolStripStatusLabel1});
            this.ssStatus.Location = new System.Drawing.Point(0, 419);
            this.ssStatus.Name = "ssStatus";
            this.ssStatus.Size = new System.Drawing.Size(808, 22);
            this.ssStatus.TabIndex = 4;
            this.ssStatus.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(81, 17);
            this.toolStripStatusLabel1.Text = "Status bar text";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Path From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Path To";
            // 
            // textPathTo
            // 
            this.textPathTo.Location = new System.Drawing.Point(73, 271);
            this.textPathTo.Name = "textPathTo";
            this.textPathTo.ReadOnly = true;
            this.textPathTo.Size = new System.Drawing.Size(514, 20);
            this.textPathTo.TabIndex = 7;
            // 
            // textPathFrom
            // 
            this.textPathFrom.Location = new System.Drawing.Point(73, 245);
            this.textPathFrom.Name = "textPathFrom";
            this.textPathFrom.ReadOnly = true;
            this.textPathFrom.Size = new System.Drawing.Size(514, 20);
            this.textPathFrom.TabIndex = 8;
            // 
            // btnPathTo
            // 
            this.btnPathTo.Location = new System.Drawing.Point(593, 271);
            this.btnPathTo.Name = "btnPathTo";
            this.btnPathTo.Size = new System.Drawing.Size(51, 20);
            this.btnPathTo.TabIndex = 9;
            this.btnPathTo.Text = "browse";
            this.btnPathTo.UseVisualStyleBackColor = true;
            this.btnPathTo.Click += new System.EventHandler(this.btnPathTo_Click);
            // 
            // btnPathFrom
            // 
            this.btnPathFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPathFrom.Location = new System.Drawing.Point(593, 245);
            this.btnPathFrom.Name = "btnPathFrom";
            this.btnPathFrom.Size = new System.Drawing.Size(51, 20);
            this.btnPathFrom.TabIndex = 10;
            this.btnPathFrom.Text = "browse";
            this.btnPathFrom.UseVisualStyleBackColor = true;
            this.btnPathFrom.Click += new System.EventHandler(this.btnPathFrom_Click);
            // 
            // btnReadAppConfig
            // 
            this.btnReadAppConfig.Location = new System.Drawing.Point(683, 244);
            this.btnReadAppConfig.Name = "btnReadAppConfig";
            this.btnReadAppConfig.Size = new System.Drawing.Size(113, 23);
            this.btnReadAppConfig.TabIndex = 11;
            this.btnReadAppConfig.Text = "Read App.config";
            this.btnReadAppConfig.UseVisualStyleBackColor = true;
            this.btnReadAppConfig.Click += new System.EventHandler(this.btnReadAppConfig_Click);
            // 
            // btnSaveAppConfig
            // 
            this.btnSaveAppConfig.Location = new System.Drawing.Point(683, 271);
            this.btnSaveAppConfig.Name = "btnSaveAppConfig";
            this.btnSaveAppConfig.Size = new System.Drawing.Size(113, 23);
            this.btnSaveAppConfig.TabIndex = 12;
            this.btnSaveAppConfig.Text = "Save App.config";
            this.btnSaveAppConfig.UseVisualStyleBackColor = true;
            this.btnSaveAppConfig.Click += new System.EventHandler(this.btnSaveAppConfig_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPageGetUserPassword);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(808, 227);
            this.tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(800, 50);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(800, 50);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(800, 109);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPageGetUserPassword
            // 
            this.tabPageGetUserPassword.BackColor = System.Drawing.Color.Transparent;
            this.tabPageGetUserPassword.Controls.Add(this.btnSaveUserToXML);
            this.tabPageGetUserPassword.Controls.Add(this.groupBoxUpdateFromURL);
            this.tabPageGetUserPassword.Controls.Add(this.btnReadUserFromXML);
            this.tabPageGetUserPassword.Controls.Add(this.textBoxPassword);
            this.tabPageGetUserPassword.Controls.Add(this.textBoxUser);
            this.tabPageGetUserPassword.Controls.Add(this.label4);
            this.tabPageGetUserPassword.Controls.Add(this.label3);
            this.tabPageGetUserPassword.Location = new System.Drawing.Point(4, 22);
            this.tabPageGetUserPassword.Name = "tabPageGetUserPassword";
            this.tabPageGetUserPassword.Size = new System.Drawing.Size(800, 201);
            this.tabPageGetUserPassword.TabIndex = 3;
            this.tabPageGetUserPassword.Text = "User information";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "User";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Password";
            // 
            // textBoxUser
            // 
            this.textBoxUser.Location = new System.Drawing.Point(67, 15);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(150, 20);
            this.textBoxUser.TabIndex = 2;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(67, 47);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(150, 20);
            this.textBoxPassword.TabIndex = 3;
            // 
            // btnReadUserFromXML
            // 
            this.btnReadUserFromXML.Location = new System.Drawing.Point(271, 13);
            this.btnReadUserFromXML.Name = "btnReadUserFromXML";
            this.btnReadUserFromXML.Size = new System.Drawing.Size(185, 23);
            this.btnReadUserFromXML.TabIndex = 4;
            this.btnReadUserFromXML.Text = "Read user information from XML";
            this.btnReadUserFromXML.UseVisualStyleBackColor = true;
            // 
            // btnUpdateUserFromURL
            // 
            this.btnUpdateUserFromURL.Location = new System.Drawing.Point(41, 51);
            this.btnUpdateUserFromURL.Name = "btnUpdateUserFromURL";
            this.btnUpdateUserFromURL.Size = new System.Drawing.Size(87, 23);
            this.btnUpdateUserFromURL.TabIndex = 5;
            this.btnUpdateUserFromURL.Text = "Update";
            this.btnUpdateUserFromURL.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(41, 25);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(737, 20);
            this.textBox3.TabIndex = 6;
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
            // groupBoxUpdateFromURL
            // 
            this.groupBoxUpdateFromURL.Controls.Add(this.textBox3);
            this.groupBoxUpdateFromURL.Controls.Add(this.label5);
            this.groupBoxUpdateFromURL.Controls.Add(this.btnUpdateUserFromURL);
            this.groupBoxUpdateFromURL.Location = new System.Drawing.Point(8, 91);
            this.groupBoxUpdateFromURL.Name = "groupBoxUpdateFromURL";
            this.groupBoxUpdateFromURL.Size = new System.Drawing.Size(784, 90);
            this.groupBoxUpdateFromURL.TabIndex = 8;
            this.groupBoxUpdateFromURL.TabStop = false;
            this.groupBoxUpdateFromURL.Text = "Update user information from URL";
            // 
            // btnSaveUserToXML
            // 
            this.btnSaveUserToXML.Location = new System.Drawing.Point(271, 45);
            this.btnSaveUserToXML.Name = "btnSaveUserToXML";
            this.btnSaveUserToXML.Size = new System.Drawing.Size(185, 23);
            this.btnSaveUserToXML.TabIndex = 9;
            this.btnSaveUserToXML.Text = "Save user information to XML";
            this.btnSaveUserToXML.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 441);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnSaveAppConfig);
            this.Controls.Add(this.btnReadAppConfig);
            this.Controls.Add(this.btnPathFrom);
            this.Controls.Add(this.btnPathTo);
            this.Controls.Add(this.textPathFrom);
            this.Controls.Add(this.textPathTo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ssStatus);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.llURL);
            this.Controls.Add(this.lbURL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NOD32 Updater";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            this.ssStatus.ResumeLayout(false);
            this.ssStatus.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageGetUserPassword.ResumeLayout(false);
            this.tabPageGetUserPassword.PerformLayout();
            this.groupBoxUpdateFromURL.ResumeLayout(false);
            this.groupBoxUpdateFromURL.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbURL;
        private System.Windows.Forms.LinkLabel llURL;
        private System.Windows.Forms.Button btGetConfig;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.StatusStrip ssStatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textPathTo;
        private System.Windows.Forms.TextBox textPathFrom;
        private System.Windows.Forms.Button btnPathTo;
        private System.Windows.Forms.Button btnPathFrom;
        private System.Windows.Forms.FolderBrowserDialog folderDialog;
        private System.Windows.Forms.Button btnReadAppConfig;
        private System.Windows.Forms.Button btnSaveAppConfig;
        private System.Windows.Forms.Button btUnpackBase;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPageGetUserPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSaveUserToXML;
        private System.Windows.Forms.GroupBox groupBoxUpdateFromURL;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnUpdateUserFromURL;
        private System.Windows.Forms.Button btnReadUserFromXML;
    }
}

