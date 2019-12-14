
namespace GameDev.Library
{
	public class Calender
	{
		public int Money
		{
			set; get;
		}
		public int TimeYear
		{
			set; get;
		}
		public int TimeMonth
		{
			set; get;
		}
		public int TimeWeek
		{
			set; get;
		}
		public string TimeTick
		{
			set; get;
		}

		public Calender()
		{
			Money = 1000;
			TimeTick = "■";
			TimeYear = 1;
			TimeMonth = 1;
			TimeWeek = 1;
		}

		public void calculateCalender()
		{
			TimeTick += "■";
			if ( TimeTick == "■■■■■■■" )
			{
				TimeTick = "■";
				TimeWeek += 1;
			}
			if ( TimeWeek == 5 )
			{
				TimeWeek = 1;
				TimeMonth += 1;
			}
			if ( TimeMonth == 13 )
			{
				TimeMonth = 1;
				TimeYear += 1;
			}
		}
	}
}
