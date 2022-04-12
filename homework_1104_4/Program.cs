// На входе число, на выходе все четные от 1 до N
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 0;

while(count < number) 
{
    count +=2;
    Console.Write(count);
    Console.Write(", ");
}

