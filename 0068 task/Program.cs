// Показать натуральные числа от M до N, N и M заданы

Console.WriteLine("Введите число N: ");
int number = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("Введите число M: ");
int number1 = Convert.ToInt16(Console.ReadLine());

int ShowNumber(int n1, int n)
{
    Console.WriteLine($"{n1}");
    if (n1 == n) return n;
    if (n1 > n) return ShowNumber(n1 - 1, n);
    else return ShowNumber(n1 + 1, n);
}

ShowNumber(number1, number);