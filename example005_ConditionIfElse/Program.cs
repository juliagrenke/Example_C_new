Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "маша") //переводит все символы в нижний регистр
{
    Console.WriteLine ("Ой-ой, это же Маша!!!");
}
else 
{
    Console.Write("Привет, ");
    Console.Write (username);
}
