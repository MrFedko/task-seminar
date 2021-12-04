// Показать натуральные числа от 1 до N, N задано

Console.WriteLine("Введите число N: ");
int number = Convert.ToInt16(Console.ReadLine());

string ShowNumber(int n)
{
    if (n == 1) return "1";
    else return $"{ShowNumber(n - 1)} {n}";
}

Console.WriteLine(ShowNumber(number));