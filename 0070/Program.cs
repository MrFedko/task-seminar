// Найти сумму цифр числа
Console.WriteLine("Введите число N: ");
int number = Convert.ToInt16(Console.ReadLine());
int tempor = 0;

int Summ(int num, int div, int temp)
{
    if (num / div == 0) return temp;
    temp = temp + (num / div) % 10;
    return Summ(num, div * 10, temp);
}

Console.WriteLine(Summ(number, 1, tempor));