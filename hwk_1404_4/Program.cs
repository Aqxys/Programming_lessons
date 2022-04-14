//  Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет,является ли этот день выходным 
A:
Console.WriteLine("Введите число: ");
int day = Convert.ToInt16(Console.ReadLine());
if ((day < 1) ^ (day > 7)) //Проверка на корректность ввода
    {
        Console.WriteLine("Введите корректное число от 1 до 7");
        goto A;
    }
else if (day > 5)
    Console.WriteLine(day + " -> Да");
else
    Console.WriteLine(day + " -> Нет");