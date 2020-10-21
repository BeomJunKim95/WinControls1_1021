using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinControls
{
    public partial class frmMain : Form
    {
        //public frmLogin LoginFrm {   get; set;  }

        private frmLogin login;

        public frmMain()
        {
            InitializeComponent();
        }

        public frmMain(frmLogin login)
        {
            InitializeComponent();
            this.login = login;
        }

        private void 로그아웃ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

            //LoginFrm.Show();

            this.login.Show();
        }

        private void 텍스트박스ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTextBox frm = new frmTextBox();
            frm.Show();
        }
    }
}
