/* Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.*/

Console.WriteLine("Введите число, соответсвующее дню недели: ");

int day = Convert.ToInt32(Console.ReadLine());
if (day == 6 || day == 7)
   {
		Console.WriteLine("День выходной");
	}
else
	{
		Console.WriteLine("День будний");
	}