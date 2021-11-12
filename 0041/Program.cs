// Выяснить являются ли три числа сторонами треугольника 

Console.WriteLine("Введите натуральное число A: ");
int A = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Введите натуральное число B: ");
int B = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Введите натуральное число C: ");
int C = Convert.ToInt16(Console.ReadLine());

if ((A < (B + C)) && (B < (A + C)) && (C < (A + B))) Console.WriteLine($"Числа A = {A}, B = {B}, C = {C} являются сторонами треугольника");
else 
{ 
    Console.WriteLine($"Числа A = {A}, B = {B}, C = {C} НЕ являются сторонами треугольника");
}