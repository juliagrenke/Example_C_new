/*Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/

Console.WriteLine("Введите число N> ");
int N = Convert.ToInt32(Console.ReadLine()!);
int[] myarray = new int[N + 1];
int i = 1;
while (i <= N)
{
    myarray[i] = i;
    Console.Write(Cub(i));
    Console.Write("  ");
    i++;
}


int Cub(int x)
{
    int result = x * x * x;
    return result;
}