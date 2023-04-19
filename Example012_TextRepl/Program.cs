﻿/* Дан текст. В тексте нужно все пробелы заменить черточками, маленькие буквы "к" заменить большими "К",
а большие "С" маленикими "с"
*/
string text = "Я думаю, - сказал князь, улыбаясь, что, ежели бы вас послали вместо нашего "
                + "милого Винценгероде, вы бы взяли приступом согласие прусского короля."
                + "Вы так красноречивы. Вы дадите мне чаю?";


// string = "querty"
//           012345
// s [3] = r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
    else result = result + $"{text[i]}";
}
return result;
}

string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
string newText1 = Replace(newText, 'к', 'К');
Console.WriteLine(newText1);
Console.WriteLine();
string newText2 = Replace(newText1, 'с', 'С');
Console.WriteLine(newText2);