/* Напсать программу, которая выводит случайное число из отрезка
[10, 99] и показывает наибольшую цифру числа.
78 -> 8
12 -> 2 */

int number = new Random().Next(10,100);

System.Console.WriteLine($"Рандомное число: {number}");

int firstDigit = number / 10;
int secondDigit = number % 10;

int maximum = firstDigit;
if (maximum < secondDigit) maximum = secondDigit;

System.Console.WriteLine($"Максимальная цифра в числе {number} - это {maximum}");