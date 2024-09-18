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
				Console.Write("Введите первое число: ");
				string firstString = Console.ReadLine();

				Console.Write("Введите второе число: ");
				string secondString = Console.ReadLine();

				double firstOperand = Convert.ToDouble(firstString);
				double secondOperand = Convert.ToDouble(secondString);

				Console.WriteLine("1(сложить), 2(вычесть), 3(умножить)");
			
				string Sign = Console.ReadLine();

				double result = 0.0;

				if (Sign == "1")
				{
					result = Sum(firstOperand, secondOperand);
				}
				else if (Sign == "2")
				{
					result = Subtract(firstOperand, secondOperand);
				}
				else if (Sign == "3")
				{
					result = Multiply(firstOperand, secondOperand);
				}
				else if (Sign == "Stop")
				{
					break;
				} 
				else
				{
					Console.WriteLine("Следуйте инструкции");
				}

				Console.WriteLine($"Результат: {result}");

			}
			


		}

		static double Sum(double a, double b) 
		{
			double result;
			result = a + b; 
			return result; 
		}
		static double Subtract(double a, double b)
		{
			double result;
			result = a - b;
			return result;
		}
		static double Multiply(double a, double b)
		{
			double result;
			result = a * b;
			return result;
		}
	}
}
