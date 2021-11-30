// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты

Console.WriteLine("Введите число строк: ");
int num1 = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Введите число столбцов: ");
int num2 = Convert.ToInt16(Console.ReadLine());

double[,] NewArray(int a, int b)
{
    double[,] array = new double[a, b];
    return array;
}

double[,] FillArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 1000);
        }
    return array;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}  ");
        }
        Console.WriteLine();
    }
}

double[,] Square(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0 && i !=0 && j != 0) array[i, j] = Math.Pow(array[i, j],2);
        }
    return array;
}
double[,] MyArray = NewArray(num1, num2);
FillArray(MyArray);
PrintArray(MyArray);
Console.WriteLine();
Square(MyArray);
PrintArray(MyArray);