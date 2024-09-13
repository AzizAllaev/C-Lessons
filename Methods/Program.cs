namespace Calculator
{
	/// <summary>
	/// Проект консольного арифметического калькулятора 
	/// </summary>

	internal class Program
	{
		static void Main(string[] args)
		{
			while (true)
			{
				Console.WriteLine("Если вы хотите сложить напишиете: +");
				Console.WriteLine("Если вы хотите отнять напишите: -");
				Console.WriteLine("Если вы хотите умножить напишите: *");
				Console.WriteLine("Если вы хотите разделить напишите: /");
				Console.Write("Какое действие вас интересует: ");
				string check = Console.ReadLine();

				if (check == "+")
				{
					Console.Write("Напишите первое число: ");
					string convpl1 = Console.ReadLine();
					int firstPl = Convert.ToInt32(convpl1);

					Console.Write("Напишите второе число: ");
					string convpl2 = Console.ReadLine();
					int secondPl = Convert.ToInt32(convpl2);

					int resultPl = Plus(secondPl, firstPl);

					Console.WriteLine($"Результат: {firstPl} + {secondPl} = {resultPl}");
				}
				else if (check == "-")
				{
					Console.Write("Напишите первое число: ");
					string convmin1 = Console.ReadLine();
					int firstMin = Convert.ToInt32(convmin1);

					Console.Write("Напишите второе число:");
					string convmin2 = Console.ReadLine();
					int secondMin = Convert.ToInt32(convmin2);

					int resultMin = Minus(firstMin, secondMin);

					Console.WriteLine($"Результат: {firstMin} - {secondMin} = {resultMin}");
				}
				else if (check == "*")
				{
					Console.Write("Напишите первое число: ");
					string convmul = Console.ReadLine();
					int firstMul = Convert.ToInt32(convmul);

					Console.Write("Напишите второе число: ");
					string convmul2 = Console.ReadLine();
					int secondMul = Convert.ToInt32(convmul2);

					int resultMul = Multiply(firstMul, secondMul);

					Console.WriteLine($"Результат: {firstMul} * {secondMul} = {resultMul}");
				}
				else if (check == "/")
				{
					Console.Write("Напишите первое число: ");
					string convsp1 = Console.ReadLine();
					int firstSp = Convert.ToInt32(convsp1);

					Console.Write("Напишите второе число: ");
					string convsp2 = Console.ReadLine();
					int secondSp = Convert.ToInt32(convsp2);


					int resultSp = Split(firstSp, secondSp);

					Console.WriteLine($"Результат: {firstSp} / {secondSp} = {resultSp}");
				}
				else 
				{
					Console.WriteLine("Следуйте инструкции сверху, если хотите закончить работу программы напишите Stop");
					string stop = Console.ReadLine();
					if (stop == "Stop")
					{
						break;
					}
				}







				//Методы

				static int Plus(int a, int b)
				{
					return a + b;
				}
				static int Minus(int ab, int bc)
				{
					return ab - bc;
				}
				static int Multiply(int abc, int abd)
				{
					return abc * abd;
				}
				static int Split(int bca, int bda)
				{
					return bca / bda;
				}
			}
			






		}
	}
}
