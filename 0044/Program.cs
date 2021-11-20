// Найти точку пересечения двух прямых заданных уравнением y=kx+b, b1 k1 и b2 и k2 заданы

int[,] array2d = new int[3, 2];

Console.WriteLine("Введите b1, k1, b2, k2 через пробел: ");
string numbers = Console.ReadLine();
string[] num = numbers.Split(' ');
array2d[0, 0] = Convert.ToInt32(num[0]);
array2d[0, 1] = Convert.ToInt32(num[1]);
array2d[1, 0] = Convert.ToInt32(num[2]);
array2d[1, 1] = Convert.ToInt32(num[3]);

if (array2d[0, 1] == array2d[1, 1])
{
    Console.WriteLine("Прямые параллельны.");
    return;
}

array2d[2, 0] = (array2d[1, 0] - array2d[0, 0]) / (array2d[0, 1] - array2d[1, 1]); // x = (b2 - b1)/(k1-k2)
array2d[2, 1] = array2d[0, 1]* array2d[2,0] + array2d[0,0];

Console.WriteLine($"Координаты точки пересечения прямых x = {array2d[2,0]}, y = {array2d[2,1]}");