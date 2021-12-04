// Написать программу возведения числа А в целую стень B

Console.WriteLine("Введите число A: ");
int numberA = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Введите целую степень числа А: ");
int degree = Convert.ToInt16(Console.ReadLine());

int NumberDegree(int num, int deg)
{
    if (deg == 0) return 1;
    else if (deg % 2 == 0) return NumberDegree(num * num, deg / 2);
    else return NumberDegree(num, deg - 1) * num;
}

Console.WriteLine(NumberDegree(numberA, degree));