﻿// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным 
//(делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine ("Введите число: ");
int number;
number = int.Parse (Console.ReadLine()!);
int remainder = number % 2;
if (remainder > 0) 
{
    Console.WriteLine ("Введенное число нечетное");
}
else
{
    Console.WriteLine ("Введенное число четное");
}
