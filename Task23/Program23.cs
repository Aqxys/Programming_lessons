// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = 0;
int count = 1;

Console.Write(number + " -> ");
Coubline(number);

int Coubline(int arg)
{
    while (count <= number)
    {
        result = count * count * count;
        Console.Write(result + " ");
        count++;
    }
    return result;
}
