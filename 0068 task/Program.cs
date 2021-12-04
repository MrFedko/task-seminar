// Показать натуральные числа от M до N, N и M заданы

Console.WriteLine("Введите число N: ");
int number = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("Введите число M: ");
int number1 = Convert.ToInt16(Console.ReadLine());

string ShowNumber(int m, int n)
{
    if (m == n) return $"{n}";
    else
    {
        if (m > n) return $"{m} {ShowNumber((m - 1), n)}";
        else return $"{m} {ShowNumber((m + 1), n)}";
    }
}

Console.WriteLine(ShowNumber(number1, number));