namespace ConsoleApp2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Унарная операция
			Console.Write("Напишите первое число: ");
			int a = Convert.ToInt32(Console.ReadLine());

			int result = a + 1;

			
			Console.WriteLine(result);


		



			//Бинарная 


			Console.Write("Напишите первое число: ");
			int ab = Convert.ToInt32(Console.ReadLine());

			Console.Write("Напишите второе число: ");
			int ac = Convert.ToInt32(Console.ReadLine());	

			int secondResult = ab + ac;


			Console.WriteLine($"{ab} + {ac} = {secondResult}");




		
			//Тернарная



			Console.Write("Напишите первое число: ");
			int abc = Convert.ToInt32(Console.ReadLine());

			Console.Write("Напишите второе число: ");
			int abf = Convert.ToInt32(Console.ReadLine());

			Console.Write("Напишите третье число: ");
			int acb = Convert.ToInt32(Console.ReadLine());


			int thirdResult = acb + abc + abf;

			Console.WriteLine($"{acb} + {abc} + {abf} = {thirdResult}");

			Console.ReadKey();




			
		}
	}
}
