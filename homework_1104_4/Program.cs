// На входе число, на выходе все четные от 1 до N
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 0;
while(count < number) 
{
    count +=1;
        if(count % 2 == 0)
        {
            Console.Write(count);
            Console.Write(", ");
        }
        else
        {
            Console.Write("");
        }
}

