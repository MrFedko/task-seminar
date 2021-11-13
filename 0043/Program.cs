// Написать программу преобразования десятичного числа в двоичное

Console.WriteLine("Введите натуральное число: ");
long number = Convert.ToInt64(Console.ReadLine());

string doubleCalc(long n)
{
    string doublenumber = string.Empty;

while (n != 0)
{
    if (n % 2 == 1) doublenumber = doublenumber + $"{1}";
    else doublenumber = doublenumber + $"{0}";
    n /= 2;
}

Console.WriteLine(doublenumber);
string result = string.Empty;
for (int j = doublenumber.Length - 1; j >= 0; j--) result = result + doublenumber[j];

return result;
}
Console.WriteLine($"В двоичном коде {number} = {doubleCalc(number)}");