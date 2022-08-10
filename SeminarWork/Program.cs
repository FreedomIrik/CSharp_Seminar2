/* Задача №9. Напсать программу, которая выводит случайное число из отрезка
[10, 99] и показывает наибольшую цифру числа.
78 -> 8
12 -> 2 

int number = new Random().Next(10,100);

System.Console.WriteLine($"Рандомное число: {number}");

int firstDigit = number / 10;
int secondDigit = number % 10;

int maximum = firstDigit;
if (maximum < secondDigit) maximum = secondDigit;

System.Console.WriteLine($"Максимальная цифра в числе {number} - это {maximum}");*/

/* Задача №11. Напишите программу, которая выводит случайное трёхзначное число
 и удаляет вторую цифру этого числа. 
 456 -> 46 
 782 -> 72 
 918 -> 98 

int number = new Random().Next(100,1000);

System.Console.WriteLine($"Рандомное число: {number}");

int firstDigit = number / 100;
int secondDigit = number % 10;
int result = firstDigit*10 + secondDigit;

System.Console.WriteLine(result);*/

/* Напишите программу, которая будет принимать на вход два числа и выводить,
является ли второе число кратным первому. Если число 2 не кратно числу 1, 
то программа выводит остаток от деления. 
34, 5 -> не кратно, остаток 4 
16, 4 -> кратно */

System.Console.WriteLine("Введите первое число: ");
int firstnumber = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите второе число: ");
int secondnumber = Convert.ToInt32(Console.ReadLine());

if (firstnumber % secondnumber == 0 )
{
    System.Console.WriteLine("Кратно");
}
else
{
    int remain = firstnumber % secondnumber;
    System.Console.WriteLine($"Не кратно, остаток {remain}");
}