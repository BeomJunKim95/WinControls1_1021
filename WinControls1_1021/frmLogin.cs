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
	public partial class frmLogin : Form
	{
		public frmLogin()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			//입력된 사용자아이디와 비밀번호가 유효한지 체크

			//입력된 데이터로 DB조회

			//로그인 성공시 메인 화면을 보여준다.
			frmMain frm = new frmMain(this); //생성자로 전달하는 경우
			//frm.LoginFrm = this; //속성으로 전달하는 경우
			frm.Show();

			//this.Close(); //시작개체를 닫으려면 이미 메인에 new가 되있어 new를 하는게 아니고 같은 클래스기때문에 this사용
						  //close를 쓰면 시작개체일 경우 프로그램이 종료 되어 버림
			this.Hide();
		}

		private void frmLogin_Load(object sender, EventArgs e)
		{
			MessageBox.Show("Load");
			for (int i = 0; i < 5; i++)
			{
				Button btn1 = new Button();
				btn1.Name = $"btn{i+1}";
				btn1.Text = (i+1).ToString();
				btn1.Location = new Point((i * 40) + 20, 50);
				btn1.Size = new Size(30, 30);
				btn1.Click += Btn1_Click;

				this.Controls.Add(btn1); //this는 폼 폼에다가 이렇게 동적버튼 btn1을 추가
			}

			//로그인한 결과가 회원인 경우
			//menuStrip2.Visible = false;//관리자용 메뉴를 안보이게 해줌

			//관리자인 경우
			menuStrip1.Visible = false;
		}

		private void Btn1_Click(object sender, EventArgs e)
		{
			MessageBox.Show("버튼 1 클릭");
		}

		private void button2_Click(object sender, EventArgs e)
		{
			//태그 사용
			string msg = string.Empty;

			//if (radioButton1.Checked)
			//	msg = $"{radioButton1.Text} / {radioButton1.Tag.ToString()}";
			//else if (radioButton2.Checked)
			//	msg = $"{radioButton2.Text} / {radioButton2.Tag.ToString()}";

			foreach(Control ctrl in this.Controls)
			{

				if(ctrl is RadioButton)
				{
					RadioButton temp = (RadioButton)ctrl;
					if(temp.Checked)
					{
						msg = $"{temp.Text} / {temp.Tag.ToString()}";
						break;
					}
				}
			}
			//라디오박스를 패널안에 넣어놓으면 라디오박스 체크 이프문을 써줄필요없어 포문도 더 적게돌고 좋아짐
			foreach (Control ctrl in panel1.Controls)
			{
				RadioButton temp = (RadioButton)ctrl;
				if (temp.Checked)
				{
					msg = $"{temp.Text} / {temp.Tag.ToString()}";
					break;
				}
			}
			MessageBox.Show(msg);
		}

		private void frmLogin_Activated(object sender, EventArgs e)
		{
			MessageBox.Show("Activate");
		}

		private void frmLogin_Shown(object sender, EventArgs e)
		{
			MessageBox.Show("Shown");
		}
	}
}
