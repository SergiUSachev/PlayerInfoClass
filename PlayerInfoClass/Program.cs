namespace PlayerInfoClass
{
	internal class Program
	{
		static void Main(string[] args)
		{
			PlayerInfo playerinfo = new PlayerInfo("Sergey", "Ork", 24, "Helicopter");
			playerinfo.ShowPlayerInfo();
		}
	}
	public class PlayerInfo
	{
		public string Name;
		public string Race;
		public int Age;
		public string Gender;

		public PlayerInfo(string name, string race, int age, string gender)
		{
			Name=name;
			Race=race;
			Age=age;
			Gender=gender;
		}

		public void ShowPlayerInfo()
		{
			Console.WriteLine($"Информация об игроке:\nИмя: {Name} \nРаса: {Race} \nВозраст: {Age} \nПол: {Gender}");
		}
	}
}