using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System;
using System.Data;

namespace GameDev.Library
{
	[Serializable]
	struct SaveData
	{
		public List<DataTable> L_dataTable
		{
			set; get;
		}
		public string saveFilePath
		{
			set; get;
		}
		public string saveTitle
		{
			set; get;
		}
		public string saveNumber
		{
			set; get;
		}
	};

	class FileIO
	{
		private static FileIO instance = null;
		public static FileIO call()
		{
			if ( instance == null )
				instance = new FileIO();
			return instance;
		}

		private string saveFolder;
		private string saveFileName;
		private string saveFileExtension;

		private List<string> l_filePath = new List<string>();
		private List<SaveData> l_saveData = new List<SaveData>();
		Control.ControlCollection controls;

		public FileIO()
		{
			saveFolder = @".//save";
			saveFileName = @"data";
			saveFileExtension = @".sav";
		}

		private void writeData<T>( string _filePath, T _data )
		{
			FileStream fs = new FileStream( _filePath, FileMode.Create, FileAccess.Write );
			BinaryFormatter formatter = new BinaryFormatter();

			formatter.Serialize( fs, _data );
			fs.Close();
		}

		private T loadData<T>( string _filePath )
		{
			FileStream fs = new FileStream( _filePath, FileMode.Open );
			BinaryFormatter formatter = new BinaryFormatter();
           
			T data = ( T )formatter.Deserialize( fs );

			fs.Close();
			return data;
		}

		public void loadSaveFolder()
		{
			l_filePath.Clear();
			l_saveData.Clear();

			DirectoryInfo di = new DirectoryInfo( saveFolder );
			FileInfo[] fi = di.GetFiles();

			for ( int i = 0 ; i < fi.Length ; i++ )
			{
				bool b = fi[i].Name.Contains( saveFileExtension );
				if ( b )
				{
					l_filePath.Add( fi[i].FullName );
				}
			}

			for ( int i = 0 ; i < l_filePath.Count ; i++ )
			{
				l_saveData.Add( loadData<SaveData>( l_filePath[i] ) );
			}
		}

		public void initControl( Control.ControlCollection _controls, string _style )
		{
			controls = null;
			controls = _controls;

			for ( int i = 0 ; i < controls.Count ; i++ )
			{
				if ( controls[i].GetType() == typeof( Button ) )
				{
					for ( int j = 0 ; j < l_saveData.Count ; j++ )
					{
						if ( ( ( Button )controls[i] ).Tag.ToString() == l_saveData[j].saveNumber )
						{
							( ( Button )controls[i] ).Text = l_saveData[j].saveTitle;
						}
					}
					if ( ( ( Button )controls[i] ).Text == "" )
					{
						( ( Button )controls[i] ).Text = "비어 있음";
					}
				}
			}

			for ( int i = 0 ; i < controls.Count ; i++ )
			{
				if ( controls[i].GetType() == typeof( Button ) )
				{
					if ( controls[i].Text == "비어 있음" )
					{
						switch ( _style )
						{
						case "Save":
							break;
						case "Load":
							controls[i].Enabled = false;
							break;
						}						
					}
				}
			}
		}

		public void saveFile( object _sender, List<DataTable> _datatable )
		{
			if ( _datatable == null )
			{
				MessageBox.Show( "저장할 데이터가 없습니다." );
				return;
			}
			if ( _datatable.Count == 0 )
			{
				MessageBox.Show( "저장할 데이터가 없습니다." );
				return;
			}

			Button btn = ( Button )_sender;
			if ( btn.Text == "비어 있음" )
			{
				if ( MessageBox.Show( "저장하시겠습니까", "질문", MessageBoxButtons.YesNo ) == DialogResult.No )      // 비어있는 슬롯일 경우
					return;
				else
				{
					SaveData sd = new SaveData();
					sd.L_dataTable = _datatable;
					sd.saveTitle = DateTime.Now.ToString();		// 큰 의미 없음
					sd.saveNumber = btn.Tag.ToString();
					sd.saveFilePath = saveFolder + @"\" + saveFileName + btn.Tag.ToString() + saveFileExtension;
					try
					{
						writeData( sd.saveFilePath, sd );
					}
					catch ( Exception ex )
					{
						MessageBox.Show( "게임 저장에 실패 했습니다." + ex.Message, "실패" );
						return;
					}
					btn.Text = sd.saveTitle;
					MessageBox.Show( "게임이 저장되었습니다." );
				}
			}
			else
			{
				if ( MessageBox.Show( "이미 데이터가 존재합니다. 덮어쓰기 할까요? ( 기존의 데이터는 사라집니다. )", "경고", MessageBoxButtons.YesNo ) == DialogResult.No )
					return;
				else
				{
					SaveData sd = new SaveData();
					sd.L_dataTable = _datatable;
					sd.saveTitle = DateTime.Now.ToString();
					sd.saveNumber = btn.Tag.ToString();
					sd.saveFilePath = saveFolder + @"\" + saveFileName + btn.Tag.ToString() + saveFileExtension;
					try
					{
						writeData( sd.saveFilePath, sd );
					}
					catch ( Exception ex )
					{
						MessageBox.Show( "게임 저장에 실패 했습니다." + ex.Message, "실패" );
						return;
					}
					btn.Text = sd.saveTitle;
					MessageBox.Show( "게임이 저장되었습니다." );
				}
			}
		}

		public void loadSaveData( object _sender, ref List<DataTable> _datatable )
		{
			if ( MessageBox.Show( "세이브 파일을 불러 오시겠습니까?", "불러오기", MessageBoxButtons.YesNo ) == DialogResult.No )
			{
				return;
			}
			else
			{
				for ( int i = 0 ; i < l_saveData.Count ; i++ )
				{
					if ( l_saveData[i].saveNumber == ( ( Button )_sender ).Tag.ToString() )
					{
						_datatable = l_saveData[i].L_dataTable;
						MessageBox.Show( "세이브 파일 불러오기 성공!", "불러오기" );
						return;
					}
				}
			}
			MessageBox.Show( "세이브 파일 불러오기 실패!!", "불러오기" );
		}
	}
}
