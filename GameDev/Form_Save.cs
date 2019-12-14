using System;
using System.Windows.Forms;
using GameDev.Library;

namespace GameDev
{
	public partial class Form_Save: Form
	{
		public Form_Save()
		{
			InitializeComponent();
			StartPosition = FormStartPosition.CenterScreen;
		}

		private void Form_Save_Load( object sender, EventArgs e )
		{
			button1.Tag = 1;
			button2.Tag = 2;
			button3.Tag = 3;
			button4.Tag = 4;
			button5.Tag = 5;

			FileIO.call().loadSaveFolder();
			FileIO.call().initControl( Controls, "Save" );
		}

		private void button1_Click( object sender, EventArgs e )
		{
			FileIO.call().saveFile( sender, ConnectDB.call().m_LTables );	// 2번째 매개변수에 있는 데이터를 저장하겠다.
		}

		private void button2_Click( object sender, EventArgs e )
		{
			FileIO.call().saveFile( sender, ConnectDB.call().m_LTables );
		}

		private void button3_Click( object sender, EventArgs e )
		{
			FileIO.call().saveFile( sender, ConnectDB.call().m_LTables );
		}

		private void button4_Click( object sender, EventArgs e )
		{
			FileIO.call().saveFile( sender, ConnectDB.call().m_LTables );
		}

		private void button5_Click( object sender, EventArgs e )
		{
			FileIO.call().saveFile( sender, ConnectDB.call().m_LTables );
		}
	}
}