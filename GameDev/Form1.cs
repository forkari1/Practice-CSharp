using System;
using System.Drawing;
using System.Windows.Forms;
using GameDev.Library;

namespace GameDev
{
	[Serializable]
	public partial class Form1: Form
	{
		private Calender calender;		

		public Form1()
		{
			InitializeComponent();
			StartPosition = FormStartPosition.CenterScreen;
			KeyPreview = true;

			calender = new Calender();
		}

		private void Form1_Load( object sender, EventArgs e )
		{
			displayCalender();
			timer1.Interval = 1000;
			timer1.Start();
		}

		private void Btn_Develop_Click( object sender, EventArgs e )
		{
			Develop_menu.Show( getControlScreenPoint( Btn_Develop ) );
		}

		private void Btn_Employee_Click( object sender, EventArgs e )
		{
			Employee_menu.Show( getControlScreenPoint( Btn_Employee ) );
		}

		private void Btn_Setting_Click( object sender, EventArgs e )
		{
			Setting_menu.Show( getControlScreenPoint( Btn_Setting ) );
		}

		private void toolStripMenuItem3_Click( object sender, EventArgs e )
		{
			timer1.Stop();
			Form_Save form_save = new Form_Save();
			form_save.ShowDialog();
			timer1.Start();
		}

		private void toolStripMenuItem4_Click( object sender, EventArgs e )
		{
			timer1.Stop();
			Form_Load form_load = new Form_Load();
			form_load.ShowDialog();
			timer1.Start();
		}

		public Point getControlScreenPoint( Control _control )      // static으로
		{
			Point p = _control.Location;
			p = _control.Parent.PointToScreen( p );
			p.X += _control.Width;
			return p;
		}

		private void 신규개발ToolStripMenuItem_Click( object sender, EventArgs e )
		{
			timer1.Stop();
			DevelopForm form = new DevelopForm();
			form.ShowDialog();
			timer1.Start();
		}

		private void timer1_Tick( object sender, EventArgs e )
		{
			calender.calculateCalender();
			displayCalender();
		}

		private void displayCalender()
		{
			MoneyLabel.Text = calender.Money.ToString() + "만원";
			TickLabel.Text = calender.TimeTick.ToString();
			TimeLabel.Text = calender.TimeYear.ToString() + " 년 " + calender.TimeMonth.ToString() + " 월 " + calender.TimeWeek.ToString() + " 주 ";
		}

		private void HireMenuItem_Click( object sender, EventArgs e )
		{
			timer1.Stop();

			HireForm hireForm = new HireForm();
			hireForm.ShowDialog();

			timer1.Start();
		}

		private void EmployeeMenuItem_Click( object sender, EventArgs e )
		{
			timer1.Stop();

			EmployeeForm hireForm = new EmployeeForm();
			hireForm.ShowDialog();

			timer1.Start();
		}	
	}
}

