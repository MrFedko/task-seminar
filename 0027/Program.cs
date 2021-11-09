// определить количество цифр в числе

Console.WriteLine("Введите число: ");
double n = Convert.ToDouble(Console.ReadLine());

int howLong(double n)               
{
    n = Math.Abs(n);
    double temp = n;
    int count;
    for (count = 1; (temp /= 10) >= 1; count++);
    int count1;
    for (count1 = 0; n % 1 != 0; count1++)
    {
        n *= 10;
    }
    int result = count + count1;
    return result;
}


Console.WriteLine($"В числе {n} вот столько цифр: {howLong(n)}");