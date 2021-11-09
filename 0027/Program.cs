// определить количество цифр в числе

Console.WriteLine("Введите число: ");
double n = Convert.ToDouble(Console.ReadLine()); //делаем double а не стразу strring, чтобы не ввели слово вместо числа
string number = Convert.ToString(n);


int counter(string howLong)
{
    int result = 0;
    for (int i = 0; i < howLong.Length; i++)
    {
        if (howLong[i] == '-' || howLong[i] == '.' || howLong[i] == ',')
        {
            i++;
        }
        result++;
    }
    return result;
}
Console.WriteLine($"В числе {n} вот столько цифр: {counter(number)}");