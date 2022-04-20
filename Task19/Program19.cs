// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом
string number1;
for (;;)
{
    Console.WriteLine("Введите пятизначное число: ");
    number1 = Console.ReadLine();
        if (number1.Length > 5 || number1.Length < 5) //проверка, что длина числа именно 5 цифр
        {
            Console.WriteLine("Некорректный ввод, попробуйте еще раз");
        }
        else break;
        
}
int number = Convert.ToInt32(number1);
int digit1 = number / 10000;
int digit2 = (number / 1000) % 10;
int digit4 = (number / 10) % 10;
int digit5 = number % 10;
if ((digit1 == digit5) && (digit2 == digit4))
    //вариант без лишних переменных 
    //if (((number / 10000) == (number % 10)) && (((number / 1000) % 10) == ((number / 10) % 10))))
    //но в нем много скобок, в них легко запутаться
    Console.WriteLine(number + "-> да");
else
    Console.WriteLine(number + "-> нет");