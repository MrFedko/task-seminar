// Возведите число А в натуральную степень В используя цикл

Console.WriteLine("Введите число: ");
int A = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("Введите натуральную степень в которую необходимо возвести первое число: ");
int B = Convert.ToInt16(Console.ReadLine());

if (B < 1)
{
    Console.WriteLine($"Число {B} не является натуральным.");
    return;
}

if (B == 1)
{
    Console.WriteLine($"{A}^{B} = {A}.");
    return;
}

int degree(int num, int num1)
{
    int temp = num;
    int result = 0;
    for (int i = 2; i <= num1; i++)
    {
        result = temp * num;
        temp = result;
    }
    return result;
}

Console.WriteLine($"{A}^{B} = {degree(A, B)}.");