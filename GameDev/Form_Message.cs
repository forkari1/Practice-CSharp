using System;
using System.Windows.Forms;
using System.Drawing;


namespace GameDev
{
	public partial class Form_Message: Form
	{
		// 클래스화 하려고 했으나 Form_Message 폼 자체가 사용되는 폼이라서 그냥 놔둔다.
		public string Msg
		{
			set; get;
		}

		public int MaxLength
		{
			set; get;
		}

		private bool isClosed = false;
		private bool timerState = false;

		public Form_Message()
		{
			InitializeComponent();
			StartPosition = FormStartPosition.CenterScreen;
			MaxLength = 80;
			TopMost = true;
		}

		private void Form_Message_Shown( object sender, EventArgs e )
		{
			timer1.Interval = 70;
			timer1.Start();
			timerState = true;
			timer2.Interval = 250;
		}

		int count = 0;

		private void timer1_Tick( object sender, EventArgs e )
		{
			if ( Msg == null )
			{
				timer1.Stop();
				isClosed = true;
				return;
			}

			if ( Msg.Length - 1 == count )
			{
				timer1.Stop();
				isClosed = true;
				timer2.Start();
				return;
			}

			if ( label1.Text.Length == MaxLength )
			{
				timer1.Stop();
				timerState = false;
				timer2.Start();
			}
			
			label1.Text += Msg[count];
			count++;
		}

		private void Form_Message_MouseDown( object sender, MouseEventArgs e )
		{
			lblStopState();
		}

		private void label1_Click( object sender, EventArgs e )
		{
			lblStopState();
		}

		private void lblStopState()
		{
			if ( isClosed )
			{
				Close();
			}

			if ( timerState == false )
			{
				label1.Text = null;
				timer1.Start();
				timerState = true;
				timer2.Stop();
				label2.Text = null;
			}
		}

		private void timer2_Tick( object sender, EventArgs e )
		{
			if ( label2.Text == null || label2.Text == "▽" )
				label2.Text = "▼";
			else
				label2.Text = "▽";
		}		
	}
}