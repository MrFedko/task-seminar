// // Выяснить является ли вещественное m

// синусом угла кратного 45 градусам
// угол i % 45==0
// m == Math.Sin(i)

Console.WriteLine("Введите вещественное число M: ");
double m = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите угол i: ");
int i = Convert.ToInt16(Console.ReadLine());

if (i < -360 || i > 360)
{
    Console.WriteLine($"Угол {i} выходит за пределы [-360,360].");
    return;
}
// Math.Sqrt(m);
// Math.Pow(m,i)

if (Math.Sin(i) == m && i % 45 == 0) Console.WriteLine($"Число M {m} является синусом угла {i}");




