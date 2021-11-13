// // Выяснить является ли вещественное m

// целой степенью числа 3
// корнем целой степени из 5,
// синусом угла кратного 45 градусам

Console.WriteLine("Введите вещественное число M: ");
double m = Convert.ToDouble(Console.ReadLine());

// Math.Sqrt(m);
// Math.Pow(m,i)
for(int i = 1; i < 100; i++)
{
    if (Math.Pow(m, 1.0 / i) == 3) Console.WriteLine($"Число M {m} является целой степенью {i} числа 3");
}



