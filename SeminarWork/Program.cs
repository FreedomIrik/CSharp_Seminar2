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

