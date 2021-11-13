

// Найти сумму чисело от 1 до А

// Console.WriteLine("Введите натуральное число: ");
// int N = Convert.ToInt16(Console.ReadLine());

// if (N < 1)
// {
//     Console.WriteLine($"Число {N} не является натуральным.");
//     return;
// }

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
Console.WriteLine($"Сумма чисел от 1 до 1000000000  = {summ2(1000000000)}");
Console.WriteLine((DateTime.Now - dt).TotalMilliseconds);
dt = DateTime.Now;
Console.WriteLine($"Сумма чисел от 1 до 1000000000  = {summ(1000000000)}");
Console.WriteLine((DateTime.Now - dt).TotalMilliseconds);