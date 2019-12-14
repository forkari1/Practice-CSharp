using System;
using System.Windows.Forms;
using GameDev.Library;
using System.Data;
using System.Drawing;

namespace GameDev
{
	public partial class EmployeeForm: Form
	{
		public EmployeeForm()
		{
			InitializeComponent();
			StartPosition = FormStartPosition.CenterScreen;
		}

		private void EmployeeForm_Load( object sender, EventArgs e )
		{
			listView1.ListViewItemSorter = new Sorter();

			DataTable dt = ConnectDB.call().getTable( "직원목록" );

			if ( dt == null ) Close();

			ListviewIO.call().fillListViewWithTable( dt, listView1, "회사", "다락방", true, "직업", "능력치", "회사", "이름" );
		}

		private void EmployeeBtn_Click( object sender, EventArgs e )
		{
			ListviewIO.call().setListViewItem( listView1, "회사", "무직" );
		}

		private void CloseBtn_Click( object sender, EventArgs e )
		{
			Close();
		}

		private void listView1_ColumnClick( object sender, ColumnClickEventArgs e )
		{
			Sorter.setListviewSorterer( listView1, e );
		}
	}
}
