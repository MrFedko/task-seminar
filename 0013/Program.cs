// Выяснить кратно ли число заданному. Если нет, вывести остаток.

Console.WriteLine("Введите натуральное число от 100 до 1000: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите натуральное число от 1 до 100: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if ((num < 100) || (num > 1000) || (num2 < 1) || (num2 > 99))
{
    Console.WriteLine("Это число не из заданного отрезка.");
    return;
}

int remainder(int number, int number1)
{
    int result = 0;
    result = number % number1;
    return result;
}

if (num % num2 == 0)
{ 
    Console.WriteLine($"Число {num} делится на {num2} без остатка");
}
else
{
    Console.WriteLine($"Остаток от деления {num} на {num2} = {remainder(num, num2)}");
}