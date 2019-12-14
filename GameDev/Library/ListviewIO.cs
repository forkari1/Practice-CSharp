using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace GameDev.Library
{
	class ListviewIO
	{
		private static ListviewIO _instance = null;
		public static ListviewIO call()
		{
			if ( _instance == null )
				_instance = new ListviewIO();
			return _instance;
		}

		public void fillListViewWithTable( DataTable _datatable, ListView _listview )
		{
			if ( _datatable == null )
				return;
			
			_listview.Tag = _datatable.TableName;
			for ( int i = 0 ; i < _datatable.Columns.Count ; i++ )          // Column 추가
			{
				_listview.Columns.Add( _datatable.Columns[i].ToString() );
				if ( _datatable.Columns[i].DataType == typeof( Int32 ) )
					_listview.Columns[i].Tag = "Numeric";
			}
			addListviewItem( _listview, _datatable );
			setColumnHeaderSpace( _listview );
		}

		public void fillListViewWithTable( DataTable _datatable, ListView _listview, params string[] _columnNames )
		{
			if ( _datatable == null )
				return;
			if ( _columnNames.Length == 0 )
				return;

			_listview.Tag = _datatable.TableName;
			for ( int i = 0 ; i < _datatable.Columns.Count ; i++ )      // Column 추가
			{
				for ( int j = 0 ; j < _columnNames.Length ; j++ )
				{
					if ( _datatable.Columns[i].ColumnName == _columnNames[j] )
					{
						_listview.Columns.Add( _columnNames[j] );
						if ( _datatable.Columns[i].DataType == typeof( Int32 ) )
						{
							int index = getListviewColumnHeader( _listview, _columnNames[j] );
							_listview.Columns[index].Tag = "Numeric";
						}
					}
				}
			}

			addListviewItem( _listview, _datatable );		// Item 추가
			setColumnHeaderSpace( _listview );				// 칼럼 헤더 간격 조정
        }

		public void fillListViewWithTable( DataTable _datatable, ListView _listview, string _columnHeader, string _item, bool _style, params string[] _columnNames )
		{
			// Column Header 취사선택

			if ( _datatable == null )
				return;
			if ( _columnNames.Length == 0 )
				return;

			_listview.Tag = _datatable.TableName;
			for ( int i = 0 ; i < _datatable.Columns.Count ; i++ )		// Column 추가
			{
				for ( int j = 0 ; j < _columnNames.Length ; j++ )
				{
					if ( _datatable.Columns[i].ColumnName == _columnNames[j] )
					{
						_listview.Columns.Add( _columnNames[j] );
						if ( _datatable.Columns[i].DataType == typeof( Int32 ) )
						{
							int index = getListviewColumnHeader( _listview, _columnNames[j] );
							_listview.Columns[index].Tag = "Numeric";
						}
					}
				}
			}

			for ( int i = 0 ; i < _datatable.Rows.Count ; i++ )			// Item 추가
			{
				switch ( _style )
				{
				case true:      // 특정 열의 값을 포함하도록
					{
						if ( _datatable.Rows[i][_columnHeader].ToString() != _item )
							continue;
						break;
					}
				case false:     // 포함하지 않도록
					{
						if ( _datatable.Rows[i][_columnHeader].ToString() == _item )
							continue;
						break;
					}
				}

				ListViewItem item = new ListViewItem( _datatable.Rows[i][_listview.Columns[0].Text].ToString() );
				for ( int j = 1 ; j < _listview.Columns.Count ; j++ )
				{
					item.SubItems.Add( _datatable.Rows[i][_listview.Columns[j].Text].ToString() );
				}

				_listview.Items.Add( item );
			}
			setColumnHeaderSpace( _listview );			
		}

		public void addListviewItem( ListView _listview, DataTable _datatable )
		{
			for ( int i = 0 ; i < _datatable.Rows.Count ; i++ )             // Item 추가
			{
				ListViewItem item = new ListViewItem( _datatable.Rows[i][_listview.Columns[0].Text].ToString() );
				for ( int j = 1 ; j < _listview.Columns.Count ; j++ )
				{
					item.SubItems.Add( _datatable.Rows[i][_listview.Columns[j].Text].ToString() );
				}
				_listview.Items.Add( item );
			}
		}

		public void setColumnHeaderSpace( ListView _listview )
		{
			for ( int i = 0 ; i < _listview.Columns.Count ; i++ )       // Column 간격 조정
			{
				_listview.Columns[i].TextAlign = HorizontalAlignment.Center;
				for ( int j = 0 ; j < _listview.Items.Count ; j++ )
				{
					if ( _listview.Columns[i].Text.Length < _listview.Items[j].SubItems[i].Text.Length )
						_listview.Columns[i].AutoResize( ColumnHeaderAutoResizeStyle.ColumnContent );
					else
						_listview.Columns[i].AutoResize( ColumnHeaderAutoResizeStyle.HeaderSize );
				}
			}
		}

		private int getListviewColumnHeader( ListView _listview, string _columnHeader )
		{
			for ( int i = 0 ; i < _listview.Columns.Count ; i++ )
			{
				if ( _listview.Columns[i].Text == _columnHeader )
				{
					return i;
				}
			}
			MessageBox.Show( "일치하는 ColumnHeader Index가 존재 하지 않습니다." );
			return -1;
		}

		public void setListViewItem( ListView _listview, string _column, string _item )    
		{
			// Listview의 특정 열에 있는 값을 변경

			if ( _listview.SelectedItems.Count == 0 )
			{
				MessageBox.Show( "선택된 항목이 없습니다." );
				return;
			}

			DataTable dt = ConnectDB.call().getTable( _listview.Tag.ToString() );

			for ( int i = 0 ; i < dt.Rows.Count ; i++ )
			{
				if ( dt.Rows[i][1].ToString() == _listview.SelectedItems[0].Text )
				{
					dt.Rows[i][_column] = _item;
					_listview.SelectedItems[0].SubItems[ getListviewColumnHeader( _listview, _column ) ].Text = _item;

					if ( _listview.Columns[getListviewColumnHeader( _listview, _column )].Text.Length < _listview.SelectedItems[0].SubItems[getListviewColumnHeader( _listview, _column )].Text.Length )
						_listview.Columns[getListviewColumnHeader( _listview, _column )].AutoResize( ColumnHeaderAutoResizeStyle.ColumnContent );
					else
						_listview.Columns[getListviewColumnHeader( _listview, _column )].AutoResize( ColumnHeaderAutoResizeStyle.HeaderSize );
					return;
				}
			}			
		}
	}
}
