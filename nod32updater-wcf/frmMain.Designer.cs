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
            this.panel1.SuspendLayout();
            this.ssStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbURL
            // 
            this.lbURL.AutoSize = true;
            this.lbURL.Location = new System.Drawing.Point(12, 124);
            this.lbURL.Name = "lbURL";
            this.lbURL.Size = new System.Drawing.Size(29, 13);
            this.lbURL.TabIndex = 0;
            this.lbURL.Text = "URL";
            // 
            // llURL
            // 
            this.llURL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.llURL.Location = new System.Drawing.Point(47, 124);
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
            this.panel1.Controls.Add(this.btGetConfig);
            this.panel1.Location = new System.Drawing.Point(12, 270);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 50);
            this.panel1.TabIndex = 3;
            // 
            // ssStatus
            // 
            this.ssStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.ssStatus.Location = new System.Drawing.Point(0, 335);
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
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Path From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Path To";
            // 
            // textPathTo
            // 
            this.textPathTo.Location = new System.Drawing.Point(73, 41);
            this.textPathTo.Name = "textPathTo";
            this.textPathTo.ReadOnly = true;
            this.textPathTo.Size = new System.Drawing.Size(514, 20);
            this.textPathTo.TabIndex = 7;
            // 
            // textPathFrom
            // 
            this.textPathFrom.Location = new System.Drawing.Point(73, 15);
            this.textPathFrom.Name = "textPathFrom";
            this.textPathFrom.ReadOnly = true;
            this.textPathFrom.Size = new System.Drawing.Size(514, 20);
            this.textPathFrom.TabIndex = 8;
            // 
            // btnPathTo
            // 
            this.btnPathTo.Location = new System.Drawing.Point(593, 41);
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
            this.btnPathFrom.Location = new System.Drawing.Point(593, 15);
            this.btnPathFrom.Name = "btnPathFrom";
            this.btnPathFrom.Size = new System.Drawing.Size(51, 20);
            this.btnPathFrom.TabIndex = 10;
            this.btnPathFrom.Text = "browse";
            this.btnPathFrom.UseVisualStyleBackColor = true;
            this.btnPathFrom.Click += new System.EventHandler(this.btnPathFrom_Click);
            // 
            // btnReadAppConfig
            // 
            this.btnReadAppConfig.Location = new System.Drawing.Point(683, 14);
            this.btnReadAppConfig.Name = "btnReadAppConfig";
            this.btnReadAppConfig.Size = new System.Drawing.Size(113, 23);
            this.btnReadAppConfig.TabIndex = 11;
            this.btnReadAppConfig.Text = "Read App.config";
            this.btnReadAppConfig.UseVisualStyleBackColor = true;
            this.btnReadAppConfig.Click += new System.EventHandler(this.btnReadAppConfig_Click);
            // 
            // btnSaveAppConfig
            // 
            this.btnSaveAppConfig.Location = new System.Drawing.Point(683, 41);
            this.btnSaveAppConfig.Name = "btnSaveAppConfig";
            this.btnSaveAppConfig.Size = new System.Drawing.Size(113, 23);
            this.btnSaveAppConfig.TabIndex = 12;
            this.btnSaveAppConfig.Text = "Save App.config";
            this.btnSaveAppConfig.UseVisualStyleBackColor = true;
            this.btnSaveAppConfig.Click += new System.EventHandler(this.btnSaveAppConfig_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 357);
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
    }
}

