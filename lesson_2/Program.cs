// Третий семинар
Console.Write("Введите число: ");
int x = int.Parse(Console.ReadLine());
int y = 0;
int count = 1;
Console.Write("Число " + x + "\t" + "Таблица квадратов ");

Quadrat(x);

int Quadrat(int x)
{
    while (count <= x)
    {
        y = count * count;
        Console.Write(y + " ");
        count++;
    }
    return y;
}