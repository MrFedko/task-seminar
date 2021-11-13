//  дано число из отрезка [10, 99]. Показать наибольшую цифру числа

Console.WriteLine("Введите натуральное числоот 10 до 99: ");
int num = Convert.ToInt32(Console.ReadLine());

if ((num > 99) || (num < 9))
{
    Console.WriteLine("Это число не принадлежит к данному отрезку");
    return;
}
int max(int n)
{
    int result = 0;
    if (n % 10 > (n % 100) / 10) result = n % 10;
    if (n % 10 < (n % 100) / 10) result = (n % 100) / 10;
    return result;
}

if (max(num) == 0) Console.WriteLine($"Цифры числа {num} равны");
else 
{
    Console.WriteLine($"Наибольшей цифрой является {max(num)}");
}
