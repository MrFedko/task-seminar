//Найти расстояние между точками в пространстве 2D

Console.WriteLine("Введите координату X для точки A: ");
int AX = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("Введите координату Y для точки A: ");
int AY = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("Введите координату X для точки B: ");
int BX = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("Введите координату Y для точки B: ");
int BY = Convert.ToInt16(Console.ReadLine());

int lengthA = AX - BX;
int lengthB = AY - BY;

double distanceAB = Math.Sqrt((Math.Pow(lengthA, 2) + Math.Pow(lengthB, 2)));

Console.WriteLine($"Расстояние между точками A и B равно {distanceAB}");