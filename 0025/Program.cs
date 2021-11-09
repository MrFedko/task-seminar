// Найти сумму чисело от 1 до А

Console.WriteLine("Введите натуральное число: ");
int N = Convert.ToInt16(Console.ReadLine());

if (N < 1)
{
    Console.WriteLine($"Число {N} не является натуральным.");
    return;
}

int summ(int number)
{
    int result = 0;
    for (int i = 1; i <= number; i++) result = i + result;
    return result;
}

Console.WriteLine($"Сумма чисел от 1 до {N} = {summ(N)}");