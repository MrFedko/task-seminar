// Программа проверяет пятизначное число на палиндромом.

Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 10000 || number > 99999)
{
    Console.WriteLine("Необходимо пятизначное число.");
    return;
}

if (((number / 1000 % 10) == (number / 10 % 10)) && ((number / 10000) == number % 10)) Console.WriteLine($"Число {number} является полиндромом.");
else
{
    Console.WriteLine($"Число {number} не является полиндромом.");
}
