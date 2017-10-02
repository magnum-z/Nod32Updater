using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nod32updater_wcf
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btGetConfig_Click(object sender, EventArgs e)
        {
            llURL.Text = "";
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

            llURL.Text = Program.fConfig;
        }
    }
}
