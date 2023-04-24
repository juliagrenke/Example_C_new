/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵) => 3*3*3*3*3
2, 4 -> 16   => 2*2*2*2 */

int StepAToB(int a, int b)
{
    int step = a;
    for (int i = 1; i < b; i++)
    {
        step = step * a;
    }
    return step;
}

Console.Write("Введите основание > ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите степень > ");
int b = int.Parse(Console.ReadLine()!);
Console.WriteLine(StepAToB(a, b));


