// найти третью цифру числа или сообщить что её нет
Console.WriteLine("Введите натуральное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 1)
{
    Console.WriteLine("Это число не натуральное.");
    return;
}

if (num < 100 && num > -100)
{
    Console.WriteLine("У этого числа нет третьей цифры.");
    return;
}

string ourNum = Convert.ToString(num);

string search3(string text)
{
    string result = String.Empty;

    result = result + text[2];
    Console.WriteLine($"Третьей цифрой этого числа является {result}");

    return result;
}
search3(ourNum);