// Написать программу вычисления произведения чисел от 1 до N

Console.WriteLine("Введите натуральное число: ");
double number = Convert.ToInt32(Console.ReadLine());

if (number < 1)
{
    Console.WriteLine($"Число {number} не является натуральным.");
    return;
}

double Factorial(double n)
{
    if (n == 1) return 1;
 
    return n * Factorial(n - 1);
}
Console.WriteLine($"Произведение чисел от 1 до {number} = {Factorial(number)}");