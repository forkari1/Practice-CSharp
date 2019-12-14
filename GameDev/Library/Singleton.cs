using System;
using System.Windows.Forms;


namespace GameDev
{
	class Singleton
	{
		private static Singleton _instance = null;
		public static Singleton call()
		{
			if ( _instance == null ) _instance = new Singleton();
			return _instance;
		}

		public DateTime Delay( int MS )
		{
			DateTime ThisMoment = DateTime.Now;
			TimeSpan duration = new TimeSpan( 0, 0, 0, 0, MS );
			DateTime AfterWards = ThisMoment.Add( duration );
			while ( AfterWards >= ThisMoment )
			{
				Application.DoEvents();
				ThisMoment = DateTime.Now;
			}
			return DateTime.Now;
		}

		public void MessageBox( string Msg )
		{
			Form_Message fm = new Form_Message();
			fm.Msg = Msg;
			fm.Show();
			
		}
	}
}

/*
		private void initImageArray()
		{
			imageArray = new int[94, 16, 2];

			int x = 0;		// 아틀라스 이미지 시작 x좌표
			int y = 0;		// 아틀라스 이미지 시작 y좌표
			int w = 24;		// 이미지 하나의 가로길이

			for ( int i = 0 ; i < 94 ; ++i )		// 세로 이미지 갯수
			{
				for ( int j = 0 ; j < 16 ; ++j )	// 가로 이미지 갯수
				{
					imageArray[i, j, 0] = x;
					imageArray[i, j, 1] = y;
					if ( j == 15 )					// 가로줄의 마지막 이미지일 경우
					{
						x = 0;						// x좌표 처음으로
						y += 24;					// y좌표 이미지 크기만큼 더해서 다음 가로줄로
					}
					else
						x += w;						// 그 이외의 모든 경우는 x좌표 + 이미지 가로 
				}
			}
		}
		
		public void loadImage()
		{
			for ( int i = 0 ; i < 94 ; ++i )
			{
				for ( int j = 0 ; j < 16 ; j++ )
				{
					Image image = Resources.icons3.Clone( new Rectangle(imageArray[i, j, 0], imageArray[i, j, 1], 24, 24), Resources.icons3.PixelFormat );
					l_image.Add( image );
				}
			}
		}
*/