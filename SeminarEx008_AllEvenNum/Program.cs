// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine ("Введите число: ");
int number = int.Parse (Console.ReadLine()!);
int count = 2;
//int remainder = number % 2;
Console.WriteLine ($"Все четные до {number}:");
if (number % 2 == 0)
    {
        while (count <= number)
        {
        Console.WriteLine (count);
        count = count + 2;
        }  
    } 
else
{
    number = number - 1;
    //Console.WriteLine ("не содержит четных");   
}
 while (count <= number)
        {
        Console.WriteLine (count);
        count = count + 2;
        }  
        

