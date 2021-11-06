//Найти максимальное из трех чисел

Console.WriteLine("Введите первое число: ");
long n1 = Convert.ToInt64(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
long n2 = Convert.ToInt64(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
long n3 = Convert.ToInt64(Console.ReadLine());

long MaxNum(long number1, long number2, long number3)
{
    long max = number1;
    if (number2 > max) max = number2;
    if (number3 > max) max = number3;
    return max;
}

Console.WriteLine($"Максимальным числом является {MaxNum(n1, n2, n3)}");