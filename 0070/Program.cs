// Найти сумму цифр числа
Console.WriteLine("Введите число N: ");
int number = Convert.ToInt16(Console.ReadLine());

int Summ(int num, int div = 1)
{
    if (num / div == 0) return 0;
    else return ((num / div) % 10) + Summ(num, div * 10);
}

Console.WriteLine(Summ(number));