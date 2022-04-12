// Проверка числа на четность, на выводе результат проверки
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int checknumber = number % 2;
if(checknumber == 0) 
{
    Console.WriteLine("Четное");
}
else
{
    Console.WriteLine("Нечетное");
}