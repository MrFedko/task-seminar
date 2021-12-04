// Написать программу возведения числа А в целую стень B

int Request(string message)
{
    Console.WriteLine(message);
    string line = Console.ReadLine();
    return Convert.ToInt32(line);
}
int numberA = Request("Введите число A: ");
int degree = Request("Введите целую степень числа А: ");

int NumberDegree(int num, int deg)
{
    if (deg == 0) return 1;
    else if (deg % 2 == 0) return NumberDegree(num * num, deg / 2);
    else return NumberDegree(num, deg - 1) * num;
}

Console.WriteLine(NumberDegree(numberA, degree));