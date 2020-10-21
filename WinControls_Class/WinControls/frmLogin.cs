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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //입력된 사용자아이디와 비밀번호가 유효한지 체크

            //입력된 데이터로 DB 조회

            //로그인성공시 메인화면을 보여준다.
            frmMain frm = new frmMain(this);
            //frm.LoginFrm = this;
            frm.Show();

            this.Hide();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Load");
            for (int i = 0; i < 5; i++)
            {
                Button btn1 = new Button();
                btn1.Name = $"btn{i+1}";
                btn1.Text = (i + 1).ToString();
                btn1.Location = new Point((i * (20 + 20)) + 20, 50);
                btn1.Size = new Size(20, 20);
                btn1.Click += Btn1_Click;

                this.Controls.Add(btn1);
            }

            //회원인경우
            //menuStrip2.Visible = false;

            //관리자인 경우
            menuStrip1.Visible = false;
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("btn1 클릭");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string msg = string.Empty;

            //if (radioButton1.Checked)
            //    msg = $"{radioButton1.Text} / {radioButton1.Tag.ToString()}";
            //else if (radioButton2.Checked)
            //    msg = $"{radioButton2.Text} / {radioButton2.Tag.ToString()}";

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is RadioButton)
                {
                    RadioButton temp = (RadioButton)ctrl;
                    if (temp.Checked)
                    {
                        msg = $"{temp.Text} / {temp.Tag.ToString()}";
                        break;
                    }
                }
            }

            foreach (RadioButton temp in panel1.Controls)
            {
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
            //MessageBox.Show("Activate");
        }

        private void frmLogin_Shown(object sender, EventArgs e)
        {
            MessageBox.Show("Shown");
        }
    }
}
