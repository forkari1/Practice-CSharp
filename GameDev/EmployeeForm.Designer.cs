namespace GameDev
{
	partial class EmployeeForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing )
		{
			if ( disposing && ( components != null ) )
			{
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.listView1 = new System.Windows.Forms.ListView();
			this.EmployeeBtn = new System.Windows.Forms.Button();
			this.CloseBtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// listView1
			// 
			this.listView1.FullRowSelect = true;
			this.listView1.GridLines = true;
			this.listView1.Location = new System.Drawing.Point(12, 12);
			this.listView1.MultiSelect = false;
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(299, 234);
			this.listView1.TabIndex = 0;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			this.listView1.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView1_ColumnClick);
			
			// 
			// EmployeeBtn
			// 
			this.EmployeeBtn.Location = new System.Drawing.Point(12, 252);
			this.EmployeeBtn.Name = "EmployeeBtn";
			this.EmployeeBtn.Size = new System.Drawing.Size(75, 23);
			this.EmployeeBtn.TabIndex = 1;
			this.EmployeeBtn.Text = "해고하기";
			this.EmployeeBtn.UseVisualStyleBackColor = true;
			this.EmployeeBtn.Click += new System.EventHandler(this.EmployeeBtn_Click);
			// 
			// CloseBtn
			// 
			this.CloseBtn.Location = new System.Drawing.Point(236, 252);
			this.CloseBtn.Name = "CloseBtn";
			this.CloseBtn.Size = new System.Drawing.Size(75, 23);
			this.CloseBtn.TabIndex = 2;
			this.CloseBtn.Text = "닫기";
			this.CloseBtn.UseVisualStyleBackColor = true;
			this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
			// 
			// EmployeeForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(323, 287);
			this.Controls.Add(this.CloseBtn);
			this.Controls.Add(this.EmployeeBtn);
			this.Controls.Add(this.listView1);
			this.Name = "EmployeeForm";
			this.Text = "EmployeeForm";
			this.Load += new System.EventHandler(this.EmployeeForm_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.Button EmployeeBtn;
		private System.Windows.Forms.Button CloseBtn;
	}
}