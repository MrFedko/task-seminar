// вывести четные числа от 1 до N

Console.WriteLine("Введите натуральное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num <= 0)
{
    Console.WriteLine("это не натуральное число.");
    return;
}
Console.WriteLine();

void PrintEventNum(int n)
{
    for (int i = 1; i <= n; i++)
    {
        if (i % 2 == 0)
        {
            Console.WriteLine($"{i}");
        }
    }
}
PrintEventNum(num);