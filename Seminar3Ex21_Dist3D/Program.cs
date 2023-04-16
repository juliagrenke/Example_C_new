/*Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

double Dist3D(double xa, double ya, double xb, double yb, double za, double zb)
{
    double dist = (xa - xb) * (xa - xb) + (ya - yb) * (ya - yb) + (za - zb) * (za - zb);
    dist = Math.Sqrt(dist);
    //dist = Math.Round(dist, 2);
    return dist;
}

Console.Write("Введите Xa > ");
double Xa = Convert.ToInt32(Console.ReadLine()!);
Console.Write("Введите Ya > ");
double Ya = Convert.ToInt32(Console.ReadLine()!);
Console.Write("Введите Za > ");
double Za = Convert.ToInt32(Console.ReadLine()!);

Console.Write("Введите Xb > ");
double Xb = Convert.ToInt32(Console.ReadLine()!);
Console.Write("Введите Yb > ");
double Yb = Convert.ToInt32(Console.ReadLine()!);
Console.Write("Введите Zb > ");
double Zb = Convert.ToInt32(Console.ReadLine()!);

Console.WriteLine($"Расстояние между точками = {Dist3D(Xa, Ya, Xb, Yb, Za, Zb):f2}"); //f2 - вывод числа до 2 знаков после запятой
