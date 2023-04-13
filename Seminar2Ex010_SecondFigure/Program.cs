/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает 
вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1*/

int SecondDigit(int number)
{
    int result1 = number % 100;
    int result2 = number % 10;
    number = ((result1 - result2) / 10);
    return number;
}

Console.WriteLine("Введите любое трехзначное число:");
int number = int.Parse(Console.ReadLine()!);
Console.WriteLine(SecondDigit(number));


