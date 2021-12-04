// Показать треугольник Паскаля *Сделать вывод в виде равнобедренного треугольника

Console.WriteLine("Введите нужное количество строк треугольника Паскаля:");
int line = Convert.ToInt32(Console.ReadLine());

int Factorial(int n)
{
    int x = 1;
    for (int i = 1; i <= n; i++)
    {
        x *= i;
    }
    return x;
}

for (int i = 0; i < line; i++)
{
    for (int c = 0; c <= (line - i); c++)
    {
        Console.Write("-");
    }
    for (int c = 0; c <= i; c++)
    {
        Console.Write("-");
        Console.Write(Factorial(i) / (Factorial(c) * Factorial(i - c)));
    }
    Console.WriteLine();
    Console.WriteLine();
}