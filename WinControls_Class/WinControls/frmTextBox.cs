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
    public partial class frmTextBox : Form
    {
        bool bChange = false;

        public frmTextBox()
        {
            InitializeComponent();
        }

        private void NumericCheck(object sender, KeyPressEventArgs e)
        {
            bool bCheck = char.IsNumber(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == '\b';

            TextBox temp = (TextBox)sender;

            if (!bCheck)
            {
                //MessageBox.Show("숫자를 입력하세요");
                errorProvider1.SetError(temp, "숫자를 입력하세요");
                e.Handled = true;
            }
            else
            {
                errorProvider1.SetError(temp, "");
            }
        }

        private void RangeCheck(object sender, EventArgs e)
        {
            TextBox temp = (TextBox)sender;
            if (temp.Text.Length < 1) return;

            if (int.Parse(temp.Text) > 100)
            {
                MessageBox.Show("100점 이내의 점수를 입력하세요.");
                //temp.Focus();
                //temp.Select(0, temp.Text.Length);
                temp.Focus();
            }
        }

        private void txtKor_Enter(object sender, EventArgs e)
        {
            txtKor.Select(0, txtKor.Text.Length);
        }

        private void txtKor_TextChanged(object sender, EventArgs e)
        {
            bChange = true;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            bChange = false;
            double kor = double.Parse(txtKor.Text);
            double math = double.Parse(txtMath.Text);
            double eng = double.Parse(txtEng.Text);

            double sum = kor + math + eng;
            double avg = sum / 3;

            txtTotal.Text = sum.ToString();
            txtAvg.Text = avg.ToString("0.0");
        }

        private void frmTextBox_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (bChange)
            {
                DialogResult result = MessageBox.Show("계산되지 않은 점수가 있습니다. 계산하시겠습니까?", "계산확인", MessageBoxButtons.YesNoCancel);

                if (result == DialogResult.Yes)
                {
                    btnCalc.PerformClick();
                }
                else if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        private void frmTextBox_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("closed");
        }
    }
}
