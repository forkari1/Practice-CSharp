using System;
using System.Windows.Forms;

namespace GameDev
{
	public partial class TitleForm: Form
	{
		public TitleForm()
		{
			InitializeComponent();
			StartPosition = FormStartPosition.CenterScreen;
		}

		private void StartBtn_Click( object sender, EventArgs e )
		{
			Form1 form = new Form1();
			Hide();
			ConnectDB.call().getTablesList( @".//db.accdb" );
			form.ShowDialog();
			Close();
		}

		private void LoadBtn_Click( object sender, EventArgs e )
		{
			Form_Load loadForm = new Form_Load();
			loadForm.ShowDialog();

			if ( ConnectDB.call().m_LTables.Count == 0 )
				return;
			else
			{
				Form1 mainForm = new Form1();
				Hide();
				mainForm.ShowDialog();
				Close();
			}			
		}

		private void CloseBtn_Click( object sender, EventArgs e )
		{
			Close();
		}
	}
}
