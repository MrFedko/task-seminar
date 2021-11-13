// показать вторую цифру трехзначного числа

Console.WriteLine("Введите натуральное трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if ((num < 100) || (num > 999))
{
    Console.WriteLine("это не трехзначное натуральное число.");
    return;
}

int two( int n)
{
    return (n%100)/10;
}

Console.WriteLine($"Вторая цифра этого числа: {two(num)}");