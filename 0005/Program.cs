//Написать программу вычисления значения функции y=f(a) = sin в степени p (количество букв фамилии)
// y = sin^P(a)

Console.WriteLine("Введите число P: ");
int P = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());

double sinAngle = Math.Pow(Math.Sin(a),P);


Console.WriteLine($"{sinAngle}");