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
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbURL
            // 
            this.lbURL.AutoSize = true;
            this.lbURL.Location = new System.Drawing.Point(12, 30);
            this.lbURL.Name = "lbURL";
            this.lbURL.Size = new System.Drawing.Size(29, 13);
            this.lbURL.TabIndex = 0;
            this.lbURL.Text = "URL";
            // 
            // llURL
            // 
            this.llURL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.llURL.Location = new System.Drawing.Point(47, 30);
            this.llURL.Name = "llURL";
            this.llURL.Size = new System.Drawing.Size(749, 13);
            this.llURL.TabIndex = 1;
            // 
            // btGetConfig
            // 
            this.btGetConfig.Location = new System.Drawing.Point(15, 12);
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
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 283);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(808, 50);
            this.panel1.TabIndex = 3;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 333);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.llURL);
            this.Controls.Add(this.lbURL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NOD32 Updater";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbURL;
        private System.Windows.Forms.LinkLabel llURL;
        private System.Windows.Forms.Button btGetConfig;
        private System.Windows.Forms.Panel panel1;
    }
}

