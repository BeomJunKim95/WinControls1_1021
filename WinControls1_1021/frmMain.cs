using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinControls1_1021
{
	public partial class frmMain : Form
	{
		//public frmLogin LoginFrm { get; set; } //속성사용
		private frmLogin login; //생성자 사용

		public frmMain()
		{
			InitializeComponent();
		}
		public frmMain(frmLogin login)
		{
			InitializeComponent(); // 반드시 이니셜라이즈 아래다 코딩해야함
			this.login = login;
		}

		private void 로그아웃ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();

			//frmLogin frm = new frmLogin();
			//frm.Show();
			//이렇게 해도 동작은 되는거 같지만 하지만 new를 또했기 때문에 알고보면 login창이 두개가 떠있는거임

			//LoginFrm.Show(); //속성사용
			this.login.Show();
		}

		private void 텍스트박스ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmTextBox frm = new frmTextBox();
			frm.Show();
		}

		private void 체크박스ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmCheckBox frm = new frmCheckBox();
			frm.MdiParent = this;
			frm.Show();
		}
	}
}
