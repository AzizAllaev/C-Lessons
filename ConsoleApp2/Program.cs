namespace ConsoleApp2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Унарная операция

			int a = 5;
			int b = +a;


			Console.WriteLine($"Результат унарной операции сложения: {b}");



			//Бинарная 

			int c = 5;
			int d = 4;

			int result = c + d;



			Console.WriteLine($"Результат бинарной операции сложения: {result}");




			//Тернарная



			int ac = 5;
			int bc = 4;
			int cb = 5;

			int SecondResult = ac + bc / cb;

			Console.WriteLine($"Результат тернарной арифметической операции: {SecondResult}");




			Console.ReadKey();

		}
	}
}
