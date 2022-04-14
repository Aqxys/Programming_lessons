// Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int digit2 = (number / 10) % 10;
Console.WriteLine("Для числа " + number + " второе число: " + digit2);
