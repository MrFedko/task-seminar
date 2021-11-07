// Программа проверяет пятизначное число на палиндромом.

Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 10000 || number > 99999)
{
    Console.WriteLine("Необходимо пятизначное число.");
    return;
}

int n1 = number % 100;
int n2 = number % 10000 / 1000 * 10 + number / 10000;

if (n1 == n2) Console.WriteLine($"Число {number} является полиндромом.");
else
{
    Console.WriteLine($"Число {number} не является полиндромом.");
}
