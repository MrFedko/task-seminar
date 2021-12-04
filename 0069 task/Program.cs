// Найти сумму элементов от M до N, N и M заданы

Console.WriteLine("Введите число N: ");
int number = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("Введите число M: ");
int number1 = Convert.ToInt16(Console.ReadLine());

int ShowNumber(int m, int n, int sum)
{
    sum += m;
    if (m == n) return sum;
    if (m > n) return ShowNumber(m - 1, n, sum);
    else return ShowNumber(m + 1, n, sum);
}

int summOfAll = 0;
Console.WriteLine(ShowNumber(number1, number, summOfAll));