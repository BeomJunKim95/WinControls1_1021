namespace WinControls1_1021
{
	partial class frmTextBox
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
			this.components = new System.ComponentModel.Container();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtKor = new System.Windows.Forms.TextBox();
			this.txtMath = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtEng = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.txtAvg = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtTotal = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.btnCal = new System.Windows.Forms.Button();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtEng);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txtMath);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txtKor);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(13, 43);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.groupBox1.Size = new System.Drawing.Size(242, 206);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "성적입력";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(28, 38);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(39, 19);
			this.label1.TabIndex = 0;
			this.label1.Text = "국어";
			// 
			// txtKor
			// 
			this.txtKor.Location = new System.Drawing.Point(102, 38);
			this.txtKor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtKor.Name = "txtKor";
			this.txtKor.Size = new System.Drawing.Size(87, 26);
			this.txtKor.TabIndex = 0;
			this.txtKor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.txtKor.TextChanged += new System.EventHandler(this.txtKor_TextChanged);
			this.txtKor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericCheck);
			this.txtKor.Leave += new System.EventHandler(this.RangeCheck);
			// 
			// txtMath
			// 
			this.txtMath.Location = new System.Drawing.Point(102, 95);
			this.txtMath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtMath.Name = "txtMath";
			this.txtMath.Size = new System.Drawing.Size(87, 26);
			this.txtMath.TabIndex = 1;
			this.txtMath.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.txtMath.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericCheck);
			this.txtMath.Leave += new System.EventHandler(this.RangeCheck);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(28, 97);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(39, 19);
			this.label2.TabIndex = 2;
			this.label2.Text = "수학";
			// 
			// txtEng
			// 
			this.txtEng.Location = new System.Drawing.Point(102, 152);
			this.txtEng.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtEng.Name = "txtEng";
			this.txtEng.Size = new System.Drawing.Size(87, 26);
			this.txtEng.TabIndex = 2;
			this.txtEng.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.txtEng.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericCheck);
			this.txtEng.Leave += new System.EventHandler(this.RangeCheck);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(28, 156);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(39, 19);
			this.label3.TabIndex = 4;
			this.label3.Text = "영어";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.txtAvg);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.txtTotal);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Location = new System.Drawing.Point(321, 43);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.groupBox2.Size = new System.Drawing.Size(242, 206);
			this.groupBox2.TabIndex = 9;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "결과";
			// 
			// txtAvg
			// 
			this.txtAvg.Location = new System.Drawing.Point(107, 93);
			this.txtAvg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtAvg.Name = "txtAvg";
			this.txtAvg.ReadOnly = true;
			this.txtAvg.Size = new System.Drawing.Size(87, 26);
			this.txtAvg.TabIndex = 3;
			this.txtAvg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(37, 98);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(39, 19);
			this.label5.TabIndex = 2;
			this.label5.Text = "평균";
			// 
			// txtTotal
			// 
			this.txtTotal.Location = new System.Drawing.Point(107, 35);
			this.txtTotal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtTotal.Name = "txtTotal";
			this.txtTotal.ReadOnly = true;
			this.txtTotal.Size = new System.Drawing.Size(87, 26);
			this.txtTotal.TabIndex = 1;
			this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(37, 40);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(39, 19);
			this.label6.TabIndex = 0;
			this.label6.Text = "총점";
			// 
			// btnCal
			// 
			this.btnCal.Location = new System.Drawing.Point(204, 273);
			this.btnCal.Name = "btnCal";
			this.btnCal.Size = new System.Drawing.Size(165, 50);
			this.btnCal.TabIndex = 3;
			this.btnCal.Text = "계산";
			this.btnCal.UseVisualStyleBackColor = true;
			this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// frmTextBox
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(597, 346);
			this.Controls.Add(this.btnCal);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "frmTextBox";
			this.Text = "frmTextBox";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTextBox_FormClosing);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmTextBox_FormClosed);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtEng;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtMath;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtKor;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox txtAvg;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtTotal;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button btnCal;
		private System.Windows.Forms.ErrorProvider errorProvider1;
	}
}