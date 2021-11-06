Console.WriteLine("Введите число, квадрат которого необходимо найти: ");
long n = Convert.ToInt64(Console.ReadLine());
long SquareN(long number)
{
    long square = number * number;
    return square;
}
Console.WriteLine($"Квадрат {n} = {SquareN(n)}");