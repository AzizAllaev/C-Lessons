namespace VeriableAndConstans
{
	internal class Program
	{
		//Объявили константу вне метода Main это важно
		public const double Pi = 3.14;


		//Выводим константу Pi
		static void Main(string[] args)
		{ 
			Console.WriteLine($"Константа Pi равна {Pi}");
		}

		


			
	}
}


/*Объявлять константу обязательно за всеми метода и классами 
  Потому что это общее значение которое не меняется в коде
 */
