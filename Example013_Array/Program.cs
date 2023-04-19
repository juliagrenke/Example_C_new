// Упорядочивание данных внутри массива

int[] arr = { 8, 5, 1, 3, 9, 6, 1, 2, 7 };

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

void SelectionSoft(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[j] < array[minPosition]) minPosition = j;
            }
            int temporary = array[i];
            array[i] = array[minPosition];
            array[minPosition] = temporary;
        }
    }
}
PrintArray(arr);
Console.WriteLine();
SelectionSoft(arr);
PrintArray(arr);