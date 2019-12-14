using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace GameDev
{
	public class Sorter : IComparer
	{
		public int Column = 0;
		public SortOrder Order = SortOrder.Ascending;
		public int Compare( object x, object y )    // IComparer Member
		{
			if ( !(x is ListViewItem) ) return (0);
			if ( !(y is ListViewItem) ) return (0);

			ListViewItem l1 = (ListViewItem)x;
			ListViewItem l2 = (ListViewItem)y;

			if ( l1.ListView.Columns[Column].Tag == null ) l1.ListView.Columns[Column].Tag = "Text";
			if ( l1.ListView.Columns[Column].Tag.ToString() == "Numeric" )
			{
				float fl1 = float.Parse( l1.SubItems[Column].Text );
				float fl2 = float.Parse( l2.SubItems[Column].Text );

				if ( Order == SortOrder.Ascending ) return fl1.CompareTo( fl2 );
				else return fl2.CompareTo( fl1 );
			}
			else
			{
				string str1 = l1.SubItems[Column].Text;
				string str2 = l2.SubItems[Column].Text;

				if ( Order == SortOrder.Ascending ) return str1.CompareTo( str2 );
				else return str2.CompareTo( str1 );
			}
		}

		public static void setListviewSorterer( ListView listvew, ColumnClickEventArgs e )
		{
			Sorter s = ( Sorter )listvew.ListViewItemSorter;
			s.Column = e.Column;

			if ( s.Order == SortOrder.Ascending )
				s.Order = SortOrder.Descending;
			else
				s.Order = SortOrder.Ascending;

			listvew.Sort();
		}
	}
}
