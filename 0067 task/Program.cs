// Показать натуральные числа от N до 1, N задано

Console.WriteLine("Введите число N: ");
int number = Convert.ToInt16(Console.ReadLine());

int ShowNumber(int n1, int n)
{
    Console.WriteLine($"{n1}");
    if (n1 == n) return n;
    return ShowNumber(n1 - 1, n);
}

ShowNumber(number, 1);