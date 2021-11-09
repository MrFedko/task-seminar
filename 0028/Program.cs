// подсчитать сумму цифр в числе

Console.WriteLine("Введите число: ");
double number = Convert.ToDouble(Console.ReadLine());

int howLong(double n)               //необходимо понять насколько длинное число до запятой
{
    n = Math.Abs(n);
    int count;
    for (count = 1; (n /= 10) >= 1; count++) ;
    return count;
}

int FractionalDigitCount(double n)          //находим число знаков после запятой
{
    n = Math.Abs(n);
    int count = 0;
    while (n % 1 != 0)
    {
        count++;
        n *= 10;
    }
    return count;
}
int length = howLong(number);                    // получаем длинну числа до запятой
int fractional = FractionalDigitCount(number);   //получаем количество знаков после запятой   

Console.WriteLine($" длинна числа = {length + fractional}");

int summ(double n, int l, int f)                       //вводим число, его длинну до и после запятой
{
    int result = 0;
    double divider = 1;
    double temp = 0;
    if (f > 0)
    {
        for (int i = 0; i < f; i++)
        {
            double temp1 = 0;
            temp1 = divider / 10;
            divider = temp1;
        }
    }
    for (int j = 0; j < (f + l); j++)
    {
        temp = (n / divider) % 10;
        result = Convert.ToInt16(result + temp);
        divider *= 10;
    }
    return Math.Abs(result);
}

Console.WriteLine($"Сумма цифр числа {number} = {summ(number, length, fractional)}");