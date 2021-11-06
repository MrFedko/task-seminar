// удалить вторую цифру трехзначного числа


Console.WriteLine("Введите натуральное трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if ((num < 100) || (num > 999))
{
    Console.WriteLine("это не трехзначное натуральное число.");
    return;
}
string lastNum = Convert.ToString(num);

string NewNumber(string number)
{
    string result = String.Empty;
    result = result + number[0] + number[2];
    return result;
}

int num2 = Convert.ToInt16(NewNumber(lastNum));

Console.WriteLine($"Получилось число {num2}");