/* Задача 18. Напишите программу, 
которая по заданному номеру четверти, 
показывает диапазон возможных координат точек в этой четверти (x и y).*/

string RangeOfValues(int q)
{
    string interval = "Неверный ввод. Должно быть 1, 2, 3, 4";

    if (q == 1) interval = "0 <= X < inf, 0 <= Y < inf";
    else if (q == 2) interval = "0 >= X > -inf, 0 <= Y < inf";
    else if (q == 3) interval = "- inf < X <= 0, - inf < Y <= 0";
    else if (q == 4) interval = "0 <= X < inf, -inf < Y < 0";

    return interval;
}

Console.Write("Введите номер четверти (1, 2, 3, 4) > ");
int q = Convert.ToInt32(Console.ReadLine()!);
Console.WriteLine (RangeOfValues(q));