// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве

Console.WriteLine("Введите координаты первой точки, X: ");
double x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты первой точки, Y: ");
double y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты первой точки, Z: ");
double z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки, X: ");
double x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки, Y: ");
double y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки, Z: ");
double z2 = Convert.ToInt32(Console.ReadLine());
double result = 0;
double temp = 0;
CalcDistance(x1, y1, z1, x2, y2, z2);
Console.Write("A(" + x1 + "," + y1 + "," + z1 + ")" + "; B(" + x2 + "," + y2 + "," + z2 + ") -> " + (result - result % 0.01));


double CalcDistance(double arg1, double arg2, double arg3, double arg4, double arg5, double arg6)
{
    //temp = (((arg4 - arg1) * (arg4 - arg1)) + ((arg5 - arg2) * (arg5 - arg2)) + ((arg6 - arg3) * (arg6 - arg3)));
    temp =(Math.Pow((arg4 - arg1),2) + Math.Pow((arg5 - arg2),2) + Math.Pow((arg6 - arg3),2));
    //выше записан вариант без метода Math.Pow, но его запись длинее
    //не знаю, какой способ оптимальнее (с точки зрения быстродействия) - с функцией или без
    if (temp < 0)
        temp = temp * -1; //проверка на отрицательное число и преобразование в положительное
    result = Math.Sqrt(temp);
    //чтобы из него можно было извлечь квадратный корень
    return result;
}