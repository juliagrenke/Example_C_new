﻿/*Задача 13: Напишите программу, которая выводит третью цифру заданного 
числа или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6*/


int TreeFigure(int number)
{
    while (number > 999)
        number = number / 10;
    return number % 10;
}

Console.WriteLine("Введите любое число> ");
int number = int.Parse(Console.ReadLine()!);
if (number < 100)
{
    Console.WriteLine("Третьей цифры нет!");
}
else
{
    Console.WriteLine($"Третья цифра > {TreeFigure(number)}");
}


