//  дано число из отрезка [10, 99]. Показать наибольшую цифру числа

Console.WriteLine("Введите натуральное числоот 10 до 99: ");
int num = Convert.ToInt32(Console.ReadLine());

if ((num > 99) || (num < 9))
{
    Console.WriteLine("Это число не принадлежит к данному отрезку");
    return;
}

string ourNum = Convert.ToString(num);

string numPosition(string number, int position)
{
    string result = String.Empty;
    result = result + number[position];
    return result;
}

int FN = Convert.ToInt16(numPosition(ourNum, 0));
int SN = Convert.ToInt16(numPosition(ourNum, 1));

if(FN > SN)
{
    Console.WriteLine($"Наибольшей цифрой является {FN}");
}
else
{
    Console.WriteLine($"Наибольшей цифрой является {SN}");
}