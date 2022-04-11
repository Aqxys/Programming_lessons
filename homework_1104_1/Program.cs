// На входе два числа, на выходе показать наибольшее и наименьшее
Console.WriteLine("Введите первое число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if(number > number2)
{
    Console.Write("Наибольшее число: ");
    Console.WriteLine(number);
    Console.Write("Наименьшее число: ");
    Console.WriteLine(number2);
}
else
{
    Console.Write("Наибольшее число: ");
    Console.WriteLine(number2);
    Console.Write("Наименьшее число: ");
    Console.WriteLine(number);
}