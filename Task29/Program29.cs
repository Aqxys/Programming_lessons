// Напишите программу, которая задаёт массив из 8 случайных целых чисел
// и выводит их на экран. Диапазон - любое целое число
int[] array = new int[8];

void FillArray(int[] arg1)
{
    int length = arg1.Length;
    int count = 0;
    while (count < length)
    {
        arg1[count] = new Random().Next();
        count++;
    }
}

void PrintArray(int[] arg1)
{
    int length = arg1.Length;
    int count = 0;
    Console.Write("Array contains: [ ");
    while (count < length)
    {
        Console.Write(arg1[count] + ", ");
        count++;
    }
    Console.Write("]");
}

FillArray(array);
PrintArray(array);