//Написать программу вычисления значения функции y=sin^p(a)
Console.WriteLine("Сейчас будем находить значение функции sin^P(a).");
Console.WriteLine("Введите число P: ");
int P = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());

double sinAngle = Math.Pow(Math.Sin(a),P); // Math.Sin() - вычисляет синус. 
// а конструкция Math.Pow(a, b) возводит число "a" в степень "b".

Console.WriteLine($"Синус {a} в степени {P} = {sinAngle}");