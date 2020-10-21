namespace WinControls1_1021
{
	partial class frmLogin
	{
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 사용 중인 모든 리소스를 정리합니다.
		/// </summary>
		/// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 디자이너에서 생성한 코드

		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다. 
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
		/// </summary>
		private void InitializeComponent()
		{
			this.button1 = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.menuStrip2 = new System.Windows.Forms.MenuStrip();
			this.회원용ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.관리자용ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.radioButton4 = new System.Windows.Forms.RadioButton();
			this.radioButton5 = new System.Windows.Forms.RadioButton();
			this.button2 = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.menuStrip1.SuspendLayout();
			this.menuStrip2.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(341, 403);
			this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(103, 35);
			this.button1.TabIndex = 0;
			this.button1.Text = "로그인";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.회원용ToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 24);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(484, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// menuStrip2
			// 
			this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.관리자용ToolStripMenuItem});
			this.menuStrip2.Location = new System.Drawing.Point(0, 0);
			this.menuStrip2.Name = "menuStrip2";
			this.menuStrip2.Size = new System.Drawing.Size(484, 24);
			this.menuStrip2.TabIndex = 2;
			this.menuStrip2.Text = "menuStrip2";
			// 
			// 회원용ToolStripMenuItem
			// 
			this.회원용ToolStripMenuItem.Name = "회원용ToolStripMenuItem";
			this.회원용ToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
			this.회원용ToolStripMenuItem.Text = "회원용";
			// 
			// 관리자용ToolStripMenuItem
			// 
			this.관리자용ToolStripMenuItem.Name = "관리자용ToolStripMenuItem";
			this.관리자용ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
			this.관리자용ToolStripMenuItem.Text = "관리자용";
			// 
			// radioButton1
			// 
			this.radioButton1.AutoSize = true;
			this.radioButton1.Location = new System.Drawing.Point(38, 13);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(42, 23);
			this.radioButton1.TabIndex = 3;
			this.radioButton1.TabStop = true;
			this.radioButton1.Tag = "M";
			this.radioButton1.Text = "월";
			this.radioButton1.UseVisualStyleBackColor = true;
			// 
			// radioButton2
			// 
			this.radioButton2.AutoSize = true;
			this.radioButton2.Location = new System.Drawing.Point(105, 13);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(42, 23);
			this.radioButton2.TabIndex = 4;
			this.radioButton2.TabStop = true;
			this.radioButton2.Tag = "T";
			this.radioButton2.Text = "화";
			this.radioButton2.UseVisualStyleBackColor = true;
			// 
			// radioButton3
			// 
			this.radioButton3.AutoSize = true;
			this.radioButton3.Location = new System.Drawing.Point(172, 13);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.Size = new System.Drawing.Size(42, 23);
			this.radioButton3.TabIndex = 5;
			this.radioButton3.TabStop = true;
			this.radioButton3.Tag = "W";
			this.radioButton3.Text = "수";
			this.radioButton3.UseVisualStyleBackColor = true;
			// 
			// radioButton4
			// 
			this.radioButton4.AutoSize = true;
			this.radioButton4.Location = new System.Drawing.Point(239, 13);
			this.radioButton4.Name = "radioButton4";
			this.radioButton4.Size = new System.Drawing.Size(42, 23);
			this.radioButton4.TabIndex = 6;
			this.radioButton4.TabStop = true;
			this.radioButton4.Tag = "H";
			this.radioButton4.Text = "목";
			this.radioButton4.UseVisualStyleBackColor = true;
			// 
			// radioButton5
			// 
			this.radioButton5.AutoSize = true;
			this.radioButton5.Location = new System.Drawing.Point(306, 13);
			this.radioButton5.Name = "radioButton5";
			this.radioButton5.Size = new System.Drawing.Size(42, 23);
			this.radioButton5.TabIndex = 7;
			this.radioButton5.TabStop = true;
			this.radioButton5.Tag = "F";
			this.radioButton5.Text = "금";
			this.radioButton5.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(176, 309);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(100, 29);
			this.button2.TabIndex = 8;
			this.button2.Text = "button2";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.radioButton4);
			this.panel1.Controls.Add(this.radioButton1);
			this.panel1.Controls.Add(this.radioButton5);
			this.panel1.Controls.Add(this.radioButton2);
			this.panel1.Controls.Add(this.radioButton3);
			this.panel1.Location = new System.Drawing.Point(32, 232);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(402, 52);
			this.panel1.TabIndex = 9;
			// 
			// frmLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(484, 461);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.menuStrip2);
			this.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MaximumSize = new System.Drawing.Size(500, 500);
			this.MinimumSize = new System.Drawing.Size(500, 500);
			this.Name = "frmLogin";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.Activated += new System.EventHandler(this.frmLogin_Activated);
			this.Load += new System.EventHandler(this.frmLogin_Load);
			this.Shown += new System.EventHandler(this.frmLogin_Shown);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.menuStrip2.ResumeLayout(false);
			this.menuStrip2.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem 회원용ToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip2;
		private System.Windows.Forms.ToolStripMenuItem 관리자용ToolStripMenuItem;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.RadioButton radioButton4;
		private System.Windows.Forms.RadioButton radioButton5;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Panel panel1;
	}
}

