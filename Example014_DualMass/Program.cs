﻿
/*string[,] table = new string[2, 5];
table[1, 2] = "слово";

for (int rows = 0; rows < 2; rows++)
{
    for (int columns = 0; columns < 5; columns++)
    {
        Console.Write($"-{table[rows, columns]}-");
    }
    Console.WriteLine ();
}*/

/*
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++) //метод определения кол-ва строк
    {
        for (int j = 0; j < matr.GetLength(1); j++)//метод определения кол-ва столбцов
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1,10); // [ 1; 10) - полуинтервал
        }
    }
}

    int[,] matrix = new int[3, 4];
    PrintArray(matrix);
    FillArray (matrix);
    Console.WriteLine();
    PrintArray(matrix);*/

/*double Factorial(int n)
{
    if (n == 1) return 1;    //1! = 1, 0! = 1
    else return n * Factorial(n - 1);
}

for (int i = 0; i< 3; i++)
{
    Console.WriteLine($"{i}! = {Factorial(i)}");
}
*/

int Fibonacci(int n)
{
    if (n == 1 || n == 2) return 1;
    else return Fibonacci(n - 1) + Fibonacci(n - 2);
}

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(Fibonacci(i));
}
