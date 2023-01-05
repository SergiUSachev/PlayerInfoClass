namespace PlayerInfoClass
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Player playerinfo = new Player("Sergey", "Ork", 24, "Helicopter");
			playerinfo.ShowInfo();
		}
	}
	public class Player
	{
		private string _name;
		private string _race;
		private int _age;
		private string _gender;

		public Player(string name, string race, int age, string gender)
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