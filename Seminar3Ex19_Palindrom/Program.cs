/* Задача 19
Напишите программу, которая принимает на вход (пятизначное) ЛЮБОЕ число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

int ReversNumber(int number)
{
    int result = 0;
    while (number > 0)
    {
        result *= 10;           //Console.WriteLine($"result = {result}");
        result += number % 10;  //Console.WriteLine($"result = {result}");
        number /= 10;           //Console.WriteLine($"number = {number}");
    }
    return result;
}

Console.WriteLine("Введите любое число >");
int number = int.Parse(Console.ReadLine()!);
int revnumber = ReversNumber(number);
if (revnumber == number) Console.WriteLine("Заданное число - палиндром");
else Console.WriteLine("Заданное число не является палиндромом");
