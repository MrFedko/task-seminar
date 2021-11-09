// По двум заданным числам проверять является ли одно квадратом другого

Console.WriteLine("Введите первое число: ");
long n1 = Convert.ToInt64(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
long n2 = Convert.ToInt64(Console.ReadLine());

bool square(long number1, long number2)
{
    return number1 / number2 == number2;
}

if(square(n1, n2) == true)
{
    Console.WriteLine($"Число {n1} является квадратом числа {n2}");
}
else 
{
    if (square(n2, n1) == true)
    {
        Console.WriteLine($"Число {n2} является квадратом числа {n1}");
        return;
    }
    Console.WriteLine($"Число {n1} не является квадратом числа {n2} а число {n2} не является квадратом числа {n1}");
}
