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
		private string Name;
		private string Race;
		private int Age;
		private string Gender;

		public PlayerInfo(string name, string race, int age, string gender)
		{
			Name=name;
			Race=race;
			Age=age;
			Gender=gender;
		}

		public void ShowInfo()
		{
			Console.WriteLine($"Информация об игроке:\nИмя: {Name} \nРаса: {Race} \nВозраст: {Age} \nПол: {Gender}");
		}
	}
}