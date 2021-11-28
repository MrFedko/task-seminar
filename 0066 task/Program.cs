// Показать натуральные числа от 1 до N, N задано

Console.WriteLine("Введите число N: ");
int number = Convert.ToInt16(Console.ReadLine());
int number1 = 1;

int ShowNumber(int n1, int n)
{
    Console.WriteLine($"{n1}");
    if (n1 == n) return n;
    return ShowNumber(n1 + 1, n);
}

ShowNumber(1, number);