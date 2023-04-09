void FillArray(int[] collection)
{
    int lengh = collection.Length;
    int index = 0;
    while (index < lengh)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

int IndexOff(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1; //если присвоить position = -1 (вместо 0), то при 
                       //поиске заведомо не входящего в массив числа будем получать -1 и трактовать, 
                       //что искомое число не входит в массив
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10];

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

FillArray(array);
PrintArray(array);
Console.WriteLine();
int pos = IndexOff(array, 445);
Console.WriteLine(pos);