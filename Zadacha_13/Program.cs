/* Задача 13: Напишите программу, которая выводит третью цифру заданного
числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

System.Console.WriteLine("Введите число: ");

int[] array = {Convert.ToInt32(Console.ReadLine())};

int n = array.Length;


if (n < 3)
{
    System.Console.WriteLine("третьей цифры нет");
}
else
{
    System.Console.WriteLine(array[2]);
}
