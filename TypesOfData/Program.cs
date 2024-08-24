﻿namespace TypesOfData
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string Address = "Вася живет в городе Чертаново, Улица Ташкент 24A, этаж 1, 91 квартира";
			Console.WriteLine(Address);
			       
					//Создаю перемнную Address типа string(строка) в которой хранится адрес васи
			
			Console.WriteLine("На каком этаже вы живёте?");
			string convert = Console.ReadLine();
			
					//Конвертирую переменную convert в int

			int stage = int.Parse(convert);
			int result = stage - 1;

					//Создаю перемнную result в которой хранится результат вычелсения 

			if (result == 0)
			{
				Console.WriteLine("Вася тоже живет на первом этаже!");
			}
			else
			{
				if (result > 4 ) 
				{
					Console.WriteLine($"Вася живет на {result} этажей выше");
				}
				else
				{
					Console.WriteLine($"Вася живет на {result} этажа выше");
				}
			}


						/*Чтобы выдать информацию без ошибок 
						 *правоописания я создаю условие где 
						 *если результат больше 4 то запись
						 *другая
						






			
			/*
			 На этом примере мы можем увидеть что строка не может
			 быть использована в математических операциях. На 17 
			 строке я перевел строку в целочисленную переменную типа
			 int. И совершил арифметическую операцию на 18 строке.
			 */

		}
	}
}


/* 
	Здесь я рассмотрю основные типы данных 
	которые обычно используются в коде.
	Помимо int, string есть ещё очень
	много типов данных которые мы не
	рассмотрели.
 */