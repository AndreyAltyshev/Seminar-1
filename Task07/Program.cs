﻿//7. Напишите программу, которая принимает на вход
//трёхзначное число и на выходе показывает последнюю цифру
//этого числа.
//456 -> 6
//782 -> 2
//918 -> 8
Console.Write("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99 && number < 1000)
{
    int lastNumber = number % 10;
    Console.Write($"Последняя цифра числа {number} :" + lastNumber);
}
else Console.Write("Введино не трёхзначное число");