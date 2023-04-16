/*Задача 22. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел
от 1 до N*/

Console.WriteLine("Введите число N> ");
int N = Convert.ToInt32(Console.ReadLine()!);
int[] myarray = new int[N+1];
int i = 1;
while (i <= N)
{
    myarray[i] = i;
    Console.Write(Square(i));
    Console.Write("  ");
    i++;
}


int Square(int x)
{
    int result = x * x;
    return result;
}


