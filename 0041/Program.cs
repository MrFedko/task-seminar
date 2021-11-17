// Выяснить являются ли три числа сторонами треугольника 

Console.WriteLine("Введите натуральное число A: ");
int A = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Введите натуральное число B: ");
int B = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Введите натуральное число C: ");
int C = Convert.ToInt16(Console.ReadLine());

bool triangle ( int q, int w, int e)
{
    return (q < (w + e)) && (w < (q + e)) && (e < (q + w));
}
if (triangle(A, B, C) == true) Console.WriteLine($"Числа A = {A}, B = {B}, C = {C} являются сторонами треугольника");
else 
{ 
    Console.WriteLine($"Числа A = {A}, B = {B}, C = {C} НЕ являются сторонами треугольника");
}