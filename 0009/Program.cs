// показать последнюю цифру трехзначного числа

Console.WriteLine("Введите натуральное трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if ((num < 100) || (num > 999))
{
    Console.WriteLine("это не трехзначное натуральное число.");
    return;
}

int three(int n)
{
    return n%10;
}

Console.WriteLine($"Последняя цифра этого числа: {three(num)}");