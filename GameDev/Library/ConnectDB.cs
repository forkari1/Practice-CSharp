using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

namespace GameDev
{
	public class ConnectDB      /// Singleton Patern
	{
		private static ConnectDB _instance = null;
		public static ConnectDB call()
		{
			if ( _instance == null )
				_instance = new ConnectDB();
			return _instance;
		}

		private OleDbConnection DBConnection;
		public List<DataTable> m_LTables
		{ set; get; }
		public List<string> m_LTablesName
		{ set; get; }       // TableName을 자동으로 불러옴

		public ConnectDB()
		{
			DBConnection = new OleDbConnection();
			m_LTables = new List<DataTable>();
			m_LTablesName = new List<string>();
		}

		public void getTablesList( string _ConnectFilePath )        // .accdb
		{
			DBConnection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + _ConnectFilePath + ";Extended Properties=;Persist Security Info=False;";

			try
			{
				DBConnection.Open();                 // Open을 언제 어떻게 왜 사용하는지 아직 아해가 안감
			}
			catch ( OleDbException ex )
			{
				MessageBox.Show( ex.Message );
			}
			catch ( InvalidOperationException ex )
			{
				MessageBox.Show( ex.Message );
			}

			if ( DBConnection.State != ConnectionState.Open )
			{				
				MessageBox.Show( "DataBase와 연결에 실패 했습니다." );
				return;
			}				

			loadTablesName( DBConnection );     // MS Access DB 파일로 부터 모든 Table의 이름을 읽어온다.
			fillWithTables( DBConnection );     // 읽어온 이름을 바탕으로 쿼리문으로 테이블의 데이터를 읽어온다.

			DBConnection.Close();
		}

		private void loadTablesName( OleDbConnection _connection )
		{
			m_LTablesName.Clear();

			foreach ( DataRow r in _connection.GetSchema( "Tables" ).Select( "TABLE_TYPE = 'TABLE'" ) )
			{
				m_LTablesName.Add( r["TABLE_NAME"].ToString() );        // TableName을 List에 추가한다.
			}
		}

		private void fillWithTables( OleDbConnection _connection )      // Table, Adapter 인덱스를 매칭 ( update, delete, insert ) 등을 하기 위해서
		{
			DataTable datatable;
			OleDbDataAdapter Adapter;

			m_LTables.Clear();      // 중복 Load시에 데이터가 겹치는 걸 방지

			for ( int i = 0 ; i < m_LTablesName.Count ; i++ )
			{
				datatable = new DataTable();
				Adapter = new OleDbDataAdapter( "select * from  " + m_LTablesName[i], _connection );

				datatable.TableName = m_LTablesName[i];

				Adapter.Fill( datatable );
				
				m_LTables.Add( datatable );
			}
		}

		public int getTableIndex( string _tablename )
		{
			for ( int i = 0 ; i < m_LTables.Count ; i++ )
			{
				if ( m_LTables[i].TableName == _tablename )
					return i;
			}
			MessageBox.Show( "일치하는 테이블 이름이 없습니다." );
			return -1;
		}

		public DataTable getTable( string _tablename )
		{
			for ( int i = 0 ; i < m_LTables.Count ; i++ )
			{
				if ( m_LTables[i].TableName == _tablename )
					return m_LTables[i];
			}
			MessageBox.Show( "일치하는 테이블 이름이 없습니다." );
			return null;
		}
	}
}