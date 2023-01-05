namespace PlayerInfoClass
{
	internal class Program
	{
		static void Main(string[] args)
		{
			PlayerInfo playerinfo = new PlayerInfo("Sergey", "Ork", 24, "Helicopter");
			playerinfo.ShowInfo();
		}
	}
	public class PlayerInfo
	{
		private string _name;
		private string _race;
		private int _age;
		private string _gender;

		public PlayerInfo(string name, string race, int age, string gender)
		{
			_name=name;
			_race=race;
			_age=age;
			_gender=gender;
		}

		public void ShowInfo()
		{
			Console.WriteLine($"Информация об игроке:\nИмя: {_name} \nРаса: {_race} \nВозраст: {_age} \nПол: {_gender}");
		}
	}
}