// Написать программу вычисления произведения чисел от 1 до N

Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 1)
{
    Console.WriteLine($"Число {number} не является натуральным.");
    return;
}

int summ = 1;
for (int i = 1; i <= number; i++)
{
    summ = summ * i;
}
Console.WriteLine($"Произведение чисел от 1 до {number} = {summ}");