//Найти расстояние между точками в пространстве 3D

Console.WriteLine("Введите координату X для точки A: ");
int AX = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("Введите координату Y для точки A: ");
int AY = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("Введите координату Z для точки A: ");
int AZ = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("Введите координату X для точки B: ");
int BX = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("Введите координату Y для точки B: ");
int BY = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("Введите координату Z для точки B: ");
int BZ = Convert.ToInt16(Console.ReadLine());

double distanceAB = Math.Sqrt((Math.Pow((AX - BX), 2) + Math.Pow((AY - BY), 2) + Math.Pow((AZ - BZ), 2)));

Console.WriteLine($"Расстояние между точками A и B равно {distanceAB}");