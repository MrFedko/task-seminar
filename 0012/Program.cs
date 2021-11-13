// удалить вторую цифру трехзначного числа


Console.WriteLine("Введите натуральное трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if ((num < 100) || (num > 999))
{
    Console.WriteLine("это не трехзначное натуральное число.");
    return;
}
int secondDelete(int n)
{
    return n/100*10+n%10;
}

Console.WriteLine($"Получилось число {secondDelete(num)}");