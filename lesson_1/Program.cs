// Проверка чисел на квадрат
Console.WriteLine("Введите первое число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int result = number * number;
if  (result ==number2)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}
