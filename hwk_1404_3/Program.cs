// Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int number3 = (number / 100) % 10;
if (number < 100)
    Console.WriteLine(number + " -> третьей цифры нет");
else
    Console.WriteLine(number + " -> " + number3);