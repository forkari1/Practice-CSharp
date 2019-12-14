
namespace GameDev
{
	partial class Form1
	{
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 사용 중인 모든 리소스를 정리합니다.
		/// </summary>
		/// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
		protected override void Dispose( bool disposing )
		{
			if ( disposing && (components != null) )
			{
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Windows Form 디자이너에서 생성한 코드

		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다. 
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.Btn_Setting = new System.Windows.Forms.Button();
			this.Btn_Develop = new System.Windows.Forms.Button();
			this.Btn_Employee = new System.Windows.Forms.Button();
			this.Develop_menu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.DevelopMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.SubcontractToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.Employee_menu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.HireMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.EmployeeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.Setting_menu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.MoneyLabel = new System.Windows.Forms.Label();
			this.TimeLabel = new System.Windows.Forms.Label();
			this.TickLabel = new System.Windows.Forms.Label();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.groupBox1.SuspendLayout();
			this.Develop_menu.SuspendLayout();
			this.Employee_menu.SuspendLayout();
			this.Setting_menu.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.Btn_Setting);
			this.groupBox1.Controls.Add(this.Btn_Develop);
			this.groupBox1.Controls.Add(this.Btn_Employee);
			this.groupBox1.Location = new System.Drawing.Point(12, 132);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(109, 193);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Menu";
			// 
			// Btn_Setting
			// 
			this.Btn_Setting.Location = new System.Drawing.Point(16, 164);
			this.Btn_Setting.Name = "Btn_Setting";
			this.Btn_Setting.Size = new System.Drawing.Size(75, 23);
			this.Btn_Setting.TabIndex = 8;
			this.Btn_Setting.Text = "기능";
			this.Btn_Setting.UseVisualStyleBackColor = true;
			this.Btn_Setting.Click += new System.EventHandler(this.Btn_Setting_Click);
			// 
			// Btn_Develop
			// 
			this.Btn_Develop.Location = new System.Drawing.Point(16, 20);
			this.Btn_Develop.Name = "Btn_Develop";
			this.Btn_Develop.Size = new System.Drawing.Size(75, 23);
			this.Btn_Develop.TabIndex = 6;
			this.Btn_Develop.Text = "개발";
			this.Btn_Develop.UseVisualStyleBackColor = true;
			this.Btn_Develop.Click += new System.EventHandler(this.Btn_Develop_Click);
			// 
			// Btn_Employee
			// 
			this.Btn_Employee.Location = new System.Drawing.Point(16, 96);
			this.Btn_Employee.Name = "Btn_Employee";
			this.Btn_Employee.Size = new System.Drawing.Size(75, 23);
			this.Btn_Employee.TabIndex = 7;
			this.Btn_Employee.Text = "직원";
			this.Btn_Employee.UseVisualStyleBackColor = true;
			this.Btn_Employee.Click += new System.EventHandler(this.Btn_Employee_Click);
			// 
			// Develop_menu
			// 
			this.Develop_menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.Develop_menu.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.Develop_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DevelopMenuItem,
            this.SubcontractToolStripMenuItem});
			this.Develop_menu.Name = "Develop_menu";
			this.Develop_menu.Size = new System.Drawing.Size(127, 48);
			// 
			// DevelopMenuItem
			// 
			this.DevelopMenuItem.Name = "DevelopMenuItem";
			this.DevelopMenuItem.Size = new System.Drawing.Size(126, 22);
			this.DevelopMenuItem.Text = "신규 개발";
			this.DevelopMenuItem.Click += new System.EventHandler(this.신규개발ToolStripMenuItem_Click);
			// 
			// SubcontractToolStripMenuItem
			// 
			this.SubcontractToolStripMenuItem.Name = "SubcontractToolStripMenuItem";
			this.SubcontractToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
			this.SubcontractToolStripMenuItem.Text = "수주 개발";
			// 
			// Employee_menu
			// 
			this.Employee_menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.Employee_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HireMenuItem,
            this.EmployeeMenuItem});
			this.Employee_menu.Name = "Develop_menu";
			this.Employee_menu.Size = new System.Drawing.Size(127, 48);
			// 
			// HireMenuItem
			// 
			this.HireMenuItem.Name = "HireMenuItem";
			this.HireMenuItem.Size = new System.Drawing.Size(126, 22);
			this.HireMenuItem.Text = "고용";
			this.HireMenuItem.Click += new System.EventHandler(this.HireMenuItem_Click);
			// 
			// EmployeeMenuItem
			// 
			this.EmployeeMenuItem.Name = "EmployeeMenuItem";
			this.EmployeeMenuItem.Size = new System.Drawing.Size(126, 22);
			this.EmployeeMenuItem.Text = "직원 명단";
			this.EmployeeMenuItem.Click += new System.EventHandler(this.EmployeeMenuItem_Click);
			// 
			// Setting_menu
			// 
			this.Setting_menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.Setting_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
			this.Setting_menu.Name = "Develop_menu";
			this.Setting_menu.Size = new System.Drawing.Size(111, 48);
			// 
			// toolStripMenuItem3
			// 
			this.toolStripMenuItem3.Name = "toolStripMenuItem3";
			this.toolStripMenuItem3.Size = new System.Drawing.Size(110, 22);
			this.toolStripMenuItem3.Text = "세이브";
			this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
			// 
			// toolStripMenuItem4
			// 
			this.toolStripMenuItem4.Name = "toolStripMenuItem4";
			this.toolStripMenuItem4.Size = new System.Drawing.Size(110, 22);
			this.toolStripMenuItem4.Text = "로드";
			this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// MoneyLabel
			// 
			this.MoneyLabel.AutoSize = true;
			this.MoneyLabel.BackColor = System.Drawing.SystemColors.Control;
			this.MoneyLabel.Location = new System.Drawing.Point(656, 23);
			this.MoneyLabel.Name = "MoneyLabel";
			this.MoneyLabel.Size = new System.Drawing.Size(38, 12);
			this.MoneyLabel.TabIndex = 6;
			this.MoneyLabel.Text = "label1";
			// 
			// TimeLabel
			// 
			this.TimeLabel.AutoSize = true;
			this.TimeLabel.Location = new System.Drawing.Point(30, 23);
			this.TimeLabel.Name = "TimeLabel";
			this.TimeLabel.Size = new System.Drawing.Size(38, 12);
			this.TimeLabel.TabIndex = 7;
			this.TimeLabel.Text = "label2";
			// 
			// TickLabel
			// 
			this.TickLabel.AutoSize = true;
			this.TickLabel.BackColor = System.Drawing.SystemColors.Control;
			this.TickLabel.Location = new System.Drawing.Point(135, 23);
			this.TickLabel.Name = "TickLabel";
			this.TickLabel.Size = new System.Drawing.Size(38, 12);
			this.TickLabel.TabIndex = 8;
			this.TickLabel.Text = "label1";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(743, 476);
			this.Controls.Add(this.TickLabel);
			this.Controls.Add(this.TimeLabel);
			this.Controls.Add(this.MoneyLabel);
			this.Controls.Add(this.groupBox1);
			this.Name = "Form1";
			this.Text = "게임 발전국";
			this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.Develop_menu.ResumeLayout(false);
			this.Employee_menu.ResumeLayout(false);
			this.Setting_menu.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button Btn_Setting;
		private System.Windows.Forms.Button Btn_Develop;
		private System.Windows.Forms.Button Btn_Employee;
		private System.Windows.Forms.ContextMenuStrip Develop_menu;
		private System.Windows.Forms.ToolStripMenuItem DevelopMenuItem;
		private System.Windows.Forms.ToolStripMenuItem SubcontractToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip Employee_menu;
		private System.Windows.Forms.ToolStripMenuItem HireMenuItem;
		private System.Windows.Forms.ContextMenuStrip Setting_menu;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
		private System.Windows.Forms.ToolStripMenuItem EmployeeMenuItem;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label MoneyLabel;
		private System.Windows.Forms.Label TimeLabel;
		private System.Windows.Forms.Label TickLabel;
		private System.Windows.Forms.ToolTip toolTip1;
	}
}

