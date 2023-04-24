/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

int SumFigure(int a)
{
    int result = 0;
    while (a > 0)
    {
        result += a % 10;
        a /= 10;
    }
    return result;
}


Console.Write("Введите любое число > ");
int n = Convert.ToInt32(Console.ReadLine()!);
Console.Write(SumFigure(n));