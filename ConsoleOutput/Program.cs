namespace ConsoleOutput
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Напишите своё имя: ");
			string name = Console.ReadLine();
			Console.Write($"Сколько лет {name}: ");
			string age = Console.ReadLine();
			Console.Write($"Какой рост у {name}: ");
			string rost = Console.ReadLine();



			Console.WriteLine($"{name}");
			Console.WriteLine($"Возраст: {age}");
			Console.WriteLine($"Рост: {rost}");



			Console.ReadKey();


			//Console.WriteLine("Сколько лет Пете?");
			//int Petyagrade = Convert.ToInt32(Console.ReadLine());
		

			//int age = Petyagrade - VasyaAgeInt;


			//if (age > 0)
			//{
			//	Console.WriteLine($"Петя старше на {age} лет");
			//}
			//else
			//{
			//	int Secondage = age * -1;
			//	Console.WriteLine($"Вася старше на {Secondage} лет");
			//}
		

					//Метод Convert.ToInt32 хорошая альтернатива int.Parse()


			
		}
	}
}
