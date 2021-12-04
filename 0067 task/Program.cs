// Показать натуральные числа от N до 1, N задано

Console.WriteLine("Введите число N: ");
int number = Convert.ToInt16(Console.ReadLine());

string ShowNumber(int n)
{
    if (n == 1) return "1";
    else return $"{n} {ShowNumber(n - 1)}";
}

Console.WriteLine(ShowNumber(number));