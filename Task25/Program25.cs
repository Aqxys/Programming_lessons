// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
int number1, number2;
Console.WriteLine("Input first number: ");
while (!int.TryParse(Console.ReadLine(), out number1) || number1 < 0)
    Console.WriteLine("Wrong input, try again: ");
Console.WriteLine("Input second number: ");
while (!int.TryParse(Console.ReadLine(), out number2) || number2 < 0)
    Console.WriteLine("Wrong input, try again: ");

int Power(int arg1, int arg2)
{
    int result = arg1;
    for (int i = 1; i < arg2; i++)
    {
        result = result * arg1;
    }
    return result;
}

int res = Power(number1, number2);
Console.WriteLine($"Result of {number1} to power {number2} is: {res}");