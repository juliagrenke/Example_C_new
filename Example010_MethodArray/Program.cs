int [] array = { 1, 32, 15, 76, 32, 91, 13, 32, 72 };
int n = array.Length; // возвращает количество элементов массива
int finde = 32;

int index = 0;

while (index < n)
{
    if (array[index] == finde)
    {
        Console.WriteLine(index);
        break; // прерывает цикл при первом выполнении условия
    }
    index++; //index = index+1;
}