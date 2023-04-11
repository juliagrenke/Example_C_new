/*Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

456 -> 46
782 -> 72
918 -> 98 */

int GetRandomThreeInt(int minDigit = 100, int maxDigit = 999)
{
    int result = new Random().Next(minDigit, maxDigit + 1);
    return result;
}

int DeletSecondDigit(int number)
{
    int number1 = number % 10;
    int number2 = number / 100;
    number = number1 + number2 * 10;
    return number;
}

int number = GetRandomThreeInt();
Console.WriteLine(number);
Console.WriteLine(DeletSecondDigit(number));