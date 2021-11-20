// Выяснить являются ли три числа сторонами треугольника 

Console.WriteLine("Введите три натуральных числа через пробел: ");
string numbers = Console.ReadLine();
string[] num = numbers.Split(' ');

bool triangle(string[] a)
{
    int q = Convert.ToInt32(a[0]);
    int w = Convert.ToInt32(a[1]);
    int e = Convert.ToInt32(a[2]);
    return (q < (w + e)) && (w < (q + e)) && (e < (q + w));
}
if (triangle(num) == true) Console.WriteLine($"Числа являются сторонами треугольника");
else
{
    Console.WriteLine($"Числа НЕ являются сторонами треугольника");
}