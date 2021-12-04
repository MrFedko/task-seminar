// Написать программу вычисления функции Аккермана

// A(m,n) =    if m = 0             n+1
//             if m > 0  n = 0      a(m-1,1)
//             if m> 0, n > 0       A(m-1, A(m, n -1)) 

int Akkerman(int m, int n)
{
    if (m == 0) return (n + 1);
    if (m != 0 && n == 0) return Akkerman(m - 1, 1);
    if (m > 0 && n > 0) return Akkerman(m - 1, Akkerman(m, n - 1));
    return Akkerman(m,n);
}

Console.WriteLine(Akkerman(2, 4));