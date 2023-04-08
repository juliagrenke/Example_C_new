//написать программу, которая на вход принимает число, на выход выводит его квадрат
//Например
// -3->9
// -4->16
// -7->49

int number;

Console.Write ("Введите число: ");
string input = Console.ReadLine ()!; //! добавляем для того, чтобы при пустом вводе не было ошибки

number = int.Parse (input);
int Square = number*number;
Console.Write ("Квадрат числа = ");
Console.Write (Square);