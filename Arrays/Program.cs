namespace Arrays
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] human = { 1, 2, 3 };
			Console.Write("Какой у вас вес: ");
			string ConvertConsole = Console.ReadLine();
			int weight = Convert.ToInt32(ConvertConsole);
			human[0] = weight;

			Console.Write("Какой у вас рост: ");
			string ConvertHeight = Console.ReadLine();
			int height = Convert.ToInt32(ConvertHeight);
			human[1] = height;

			Console.Write("Какой у вас возраст: ");
			string ConvertAge = Console.ReadLine();
			int age = Convert.ToInt32(ConvertAge);
			human[2] = age;

			Console.WriteLine($"Возраст: {human[0]}");
			Console.WriteLine($"Вес: {human[1]}");
			Console.WriteLine($"Рост: {human[2]}");

			
		}
	}
}
