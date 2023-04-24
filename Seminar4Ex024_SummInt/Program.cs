// Задача 24. Найти сумму чисел от 1 до А. На входе число (А).
//7->28
//4->10
//8->36

int SumFrom1ToN(int n)
{
    int sum = 0;
    for (int i = 0; i <= n; i++)
    {
        sum += i;
    }
    return sum;
}

int FastSumFrom1ToN(int n)
{
    return n * (n + 1) / 2;
}


Console.WriteLine(
    SumFrom1ToN(280)
    );
Console.WriteLine(
    FastSumFrom1ToN(280)
    );
