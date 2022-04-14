// Напишите программу, которая выводит случайное трёхзначное число
// и удаляет вторую цифру этого числа

int number = new Random().Next(1, 1000);
int result = ((number / 100)*10) + (number % 10);
Console.WriteLine(number + " -> " + result);
