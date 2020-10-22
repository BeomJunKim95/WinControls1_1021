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
	public partial class frmCheckBox : Form
	{
		public frmCheckBox()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			StringBuilder sb = new StringBuilder();

			foreach (CheckBox chk in panel1.Controls)//패널안에 체크박스를 넣었을경우
			{
				if (chk.Checked)
					sb.Append(chk.Text + ",");
			}
			//나열이 필요없어짐

			//if (checkBox1.Checked)
			//	sb.Append(checkBox1.Text + ",");
			//if (checkBox2.Checked)
			//	sb.Append(checkBox2.Text);
			//if (checkBox3.Checked)
			//	sb.Append(checkBox3.Text);
			//if (checkBox4.Checked)
			//	sb.Append(checkBox4.Text);
			//else
			//	sb.Append(checkBox5.Text);

			//배열을 사용했을경우
			//CheckBox[] cBox = { checkBox1, checkBox2, checkBox3, checkBox4, checkBox5 }; 

			//foreach (CheckBox chk in cBox)
			//{
			//	if (chk.Checked)
			//		sb.Append(chk.Text + ",");
			//}

			MessageBox.Show(sb.ToString());

		}

		private void button2_Click(object sender, EventArgs e)
		{
			string msg = "영화 ,스포츠, 게임,";
			foreach (CheckBox chk in panel1.Controls)
			{
				if (msg.Contains(chk.Text + ","))
				{
					chk.Checked = true;
				}
			}
		}

		private void radioButton1_CheckedChanged(object sender, EventArgs e)
		{
			//CheckedChanged 에 if else문이 꼭 들어가 줘야함
			if (radioButton1.Checked)
			{
				panel2.Visible = true;
				panel3.Visible = false;
				textBox2.Location = panel3.Location;
			}
			else
			{
				panel2.Visible = false;
				panel3.Visible = true;
				panel3.Location = panel2.Location;
				textBox2.Location = new Point(panel3.Location.X, panel3.Location.Y + panel3.Height);
			}
		}
	}
}
