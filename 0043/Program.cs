// Написать программу преобразования десятичного числа в двоичное

Console.WriteLine("Введите натуральное число: ");
long number = Convert.ToInt64(Console.ReadLine());

string doubleCalc(long n)
{
    string doublenumber = string.Empty;
    while (n != 0)
    {
        doublenumber = doublenumber + $"{n % 2}";
        n /= 2;
    }

    string result = string.Empty;
    for (int j = doublenumber.Length - 1; j >= 0; j--) result = result + doublenumber[j];
    return result;
}
Console.WriteLine($"В двоичном коде {number} = {doubleCalc(number)}");