// показать таблицу квадратов чисел от 1 до N

Console.WriteLine("Введите натуральное число: ");
int N = Convert.ToInt16(Console.ReadLine());

if (N < 1)
{
    Console.WriteLine($"Число {N} не является натуральным.");
    return;
}
for ( int i = 1; i <= N; i++)
{
    Console.WriteLine($"{i}^2 = {Math.Pow(i, 2)}");
}