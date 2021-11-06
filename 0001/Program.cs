// // по двум заданным числам проверять, является первое квадратом второго.

Console.WriteLine("Введите первое число: ");
long n1 = Convert.ToInt64(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
long n2 = Convert.ToInt64(Console.ReadLine());

void True()
{
    Console.WriteLine($"Число {n1} является квадратом числа {n2}");
}
void False()
{
    Console.WriteLine($"Число {n1} не вляется квадратом числа {n2}");
}

if (n1 <= 0 || n2 <= 0) Console.WriteLine("Введите натуральные числа.");

if (n2 * n2 == n1) 
{
    True();
}
else 
{
    False();
}