// // Выяснить является ли вещественное m корнем целой степени из 5,
//         m    5^4
// 5, 25, 125, 625
// 1   2   3    4

Console.WriteLine("Введите вещественное число M: ");
double m = Convert.ToDouble(Console.ReadLine());

// Math.Sqrt(m);
// Math.Pow(m,i)
int count = 0;
for(int i = 1; i < 100; i++)
{
    if (Math.Round(Math.Pow(m, i),2) == 5) 
    {
        Console.WriteLine($"Число M {m} является корнем целой степени {i} числа 5");
        count++;
    } 
}
if (count == 0) Console.WriteLine($"Число M {m} не является корнем целой степени числа 5");