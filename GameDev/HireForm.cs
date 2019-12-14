using System;
using System.Windows.Forms;
using System.Data;
using GameDev.Library;

namespace GameDev
{
	public partial class HireForm: Form
	{      
		public HireForm()
		{			
			InitializeComponent();
		}

		private void Form2_Load( object sender, EventArgs e )
		{
			StartPosition = FormStartPosition.CenterScreen;
			listView1.ListViewItemSorter = new Sorter();

			DataTable dt = ConnectDB.call().getTable( "직원목록" );

			if ( dt == null ) Close();
			
			ListviewIO.call().fillListViewWithTable( dt, listView1,"회사","다락방",false, "직업", "능력치", "회사", "이름" );			
		}

		private void Btn_Close_Click( object sender, EventArgs e )
		{
			Close();
		}

		private void listView1_ColumnClick( object sender, ColumnClickEventArgs e )
		{
			Sorter.setListviewSorterer( listView1, e );
		}

		private void button1_Click( object sender, EventArgs e )
		{
			ListviewIO.call().setListViewItem( listView1, "회사", "다락방" );
		}
	}
}