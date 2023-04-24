/* Задача 30: Напишите программу, которая выводит массив из 8 элементов, 
заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]*/

int[] myArray = new int[8];
Random rnd = new Random();
Console.Write("[ ");
for (int i = 0; i < myArray.Length; i++)
{
    myArray[i] = rnd.Next(0, 2);
    Console.Write(i < myArray.Length - 1 ? (myArray[i] + ", ") : (myArray[i]));//конструкция для печати
    // Console.WriteLine($"{i}=" + $" {myArray[i]}");
    //Console.Write($" {myArray[i]}");

}
Console.Write(" ]");
