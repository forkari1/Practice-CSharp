using System.Windows.Forms;

namespace GameDev
{
	/*
	public struct GameData
	{
		int Number;
		string Name;
		string Platform;
		string Genre;
		string Topic;
		int Score;
		int Story;
		int Design;
		int Sound;
		int Graphic;
		int Originality;
	}
	*/

	public partial class DevelopForm: Form
	{
		public DevelopForm()
		{
			InitializeComponent();
			StartPosition = FormStartPosition.CenterScreen;
		}
	}
}

// 장르에 따라서 design sound등의 비율을 다르게 한다.
// design은 각 능려치들의 Max능력치를 결정한다.