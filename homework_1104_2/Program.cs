// На входе три числа, на выходе показать наибольшее
Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int number3 = Convert.ToInt32(Console.ReadLine());
int max = number1;
if(number2 > number1)
{ 
    max = number2;
} 
if(number3 > number2)
{
     max = number3;
}
Console.Write("Наибольшее число: ");
Console.WriteLine(max);