namespace ConsoleOutput
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Привет Вася!");
			Console.Write("Сколько лет Васе: ");


					//Помимо привычного метода WriteLine также есть Write
			
			string VasyaAge = Console.ReadLine();  
			Console.WriteLine($"Васе {VasyaAge} лет");

					//Отличается он тем что при выполнении он не переходит на новую строку

			int VasyaAgeInt = int.Parse(VasyaAge);


					//Также тут я хотел закрепить метод Convert.ToInt32

			Console.WriteLine("Сколько лет Пете?");
			int Petyagrade = Convert.ToInt32(Console.ReadLine());
		

			int age = Petyagrade - VasyaAgeInt;


			if (age > 0)
			{
				Console.WriteLine($"Петя старше на {age} лет");
			}
			else
			{
				int Secondage = age * -1;
				Console.WriteLine($"Вася старше на {Secondage} лет");
			}
		

			//Метод Convert.ToInt32 хорошая альтернатива int.Parse()


			
		}
	}
}
