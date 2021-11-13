

// Найти сумму чисело от 1 до А

Console.WriteLine("Введите натуральное число: ");
double N = Convert.ToDouble(Console.ReadLine());

if (N < 1)
{
    Console.WriteLine($"Число {N} не является натуральным.");
    return;
}

double summ(double number)
{
    double result = 0;
    for (int i = 1; i <= number; i++) result = i + result;
    return result;
}

double summ2(double number)
{
    return (number*(number+1))/2;
}
DateTime dt = DateTime.Now;
Console.WriteLine($"Сумма чисел от 1 до {N}  = {summ(N)}");
Console.WriteLine((DateTime.Now - dt).TotalMilliseconds);
dt = DateTime.Now;
Console.WriteLine($"Сумма чисел от 1 до {N}  = {summ2(N)}");
Console.WriteLine((DateTime.Now - dt).TotalMilliseconds);