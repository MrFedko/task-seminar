﻿// показать вторую цифру трехзначного числа

Console.WriteLine("Введите натуральное трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if ((num < 100) || (num > 999))
{
    Console.WriteLine("это не трехзначное натуральное число.");
    return;
}
string lastNum = Convert.ToString(num);

string LastNum(string number)
{
    string result = String.Empty;
    result = result + number[1];
    return result;
}

Console.WriteLine($"Вторая цифра этого числа: {LastNum(lastNum)}");