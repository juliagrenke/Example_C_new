/* Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5*/

int QuantFigure(string n)
{
    int lenght = n.Length;
    return lenght++;

}

Console.Write("Введите число > ");
int n = Convert.ToInt32(Console.ReadLine()!);
int n1 = Math.Abs (n);
string n2 = Convert.ToString(n1);
Console.WriteLine(QuantFigure(n2));
