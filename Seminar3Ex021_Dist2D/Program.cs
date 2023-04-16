/*Задача 21. Напишите программу, которая принимает на вход координаты двух точек и 
находит расстояние между ними в 2D пространстве.
A (3,6); B (2,1) -> 5,09
A (7,-5); B (1,-1) -> 7,21*/

double Dist2D(double xa, double ya, double xb, double yb)
{
    double dist = Math.Pow(xa - xb, 2) + Math.Pow(ya - yb, 2);
    dist = Math.Sqrt(dist);
    //dist = Math.Round(dist, 2);
    return dist;
}

Console.Write("Введите Xa > ");
double Xa = Convert.ToInt32(Console.ReadLine()!);
Console.Write("Введите Ya > ");
double Ya = Convert.ToInt32(Console.ReadLine()!);
Console.Write("Введите Xb > ");
double Xb = Convert.ToInt32(Console.ReadLine()!);
Console.Write("Введите Yb > ");
double Yb = Convert.ToInt32(Console.ReadLine()!);
Console.WriteLine($"Расстояние между точками = {Dist2D(Xa, Ya, Xb, Yb):f5}"); //вывод числа до 5 знаков после запятой