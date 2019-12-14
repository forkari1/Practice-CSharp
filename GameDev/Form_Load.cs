using System;
using GameDev.Library;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Data;

namespace GameDev
{
	public partial class Form_Load: Form
	{
		List<DataTable> datatable;
		public Form_Load()
		{
			InitializeComponent();

			StartPosition = FormStartPosition.CenterScreen;
		}

		private void Form_Load_Load( object sender, EventArgs e )
		{
			button1.Tag = 1;
			button2.Tag = 2;
			button3.Tag = 3;
			button4.Tag = 4;
			button5.Tag = 5;

			FileIO.call().loadSaveFolder();
			FileIO.call().initControl( Controls, "Load" );
        }

		private void button1_Click( object sender, EventArgs e )
		{
			FileIO.call().loadSaveData( sender, ref datatable );   // 2번째 매개변수에 있는 데이터를 불러오겠다.
			ConnectDB.call().m_LTables = datatable;
			Close();
		}

		private void button2_Click( object sender, EventArgs e )
		{
			FileIO.call().loadSaveData( sender, ref datatable );
			ConnectDB.call().m_LTables = datatable;
			Close();
		}

		private void button3_Click( object sender, EventArgs e )
		{
			FileIO.call().loadSaveData( sender, ref datatable );
			ConnectDB.call().m_LTables = datatable;
			Close();
		}

		private void button4_Click( object sender, EventArgs e )
		{
			FileIO.call().loadSaveData( sender, ref datatable );
			ConnectDB.call().m_LTables = datatable;
			Close();
		}

		private void button5_Click( object sender, EventArgs e )
		{
			FileIO.call().loadSaveData( sender, ref datatable );
			ConnectDB.call().m_LTables = datatable;
			Close();
		}
	}
}
