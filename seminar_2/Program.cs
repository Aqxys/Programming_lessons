// Поиск в массиве чисел кратных 7 и 23
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    int count = 0;
    while (index < length)
    {
        count += 1;
        collection[index] = count;
        index++;
    }
}
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(col[position] + " ");
        position++;
    }
}
int[] array = new int[10000];
int counter = 0;
int lenarr = array.Length;
int index = 0;

FillArray(array);
while (counter < lenarr)
{
    if ((array[index] % 7 == 0) && (array[index] % 23 == 0))
    {
        Console.Write(array[index] + " ");
        index++;
    }
    else
    {
        index++;
    }
    counter++;
}