// Написать программу вычисления функции Аккермана

// A(m,n) =    if m = 0             n+1
//             if m > 0  n = 0      a(m-1,1)
//             if m> 0, n > 0       A(m-1, A(m, n -1)) 

Console.WriteLine("Введите число N: ");
int number = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("Введите число M: ");
int number1 = Convert.ToInt16(Console.ReadLine());

if (number < 0 || number1 < 0) Console.WriteLine("Введите положительные числа.");

int Akkerman(int m, int n)
{
    if (m == 0) return (n + 1);
    if (m > 0 && n == 0) return Akkerman(m - 1, 1);
    if (m > 0 && n > 0) return Akkerman(m - 1, Akkerman(m, n - 1));
    return Akkerman(m,n);
}

Console.WriteLine(Akkerman(number, number1));