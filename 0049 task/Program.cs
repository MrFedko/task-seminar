//  Показать двумерный массив размером m×n заполненный вещественными числами

Console.WriteLine("Введите число строк: ");
int num1 = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Введите число столбцов: ");
int num2 = Convert.ToInt16(Console.ReadLine());

double[,] NewArray(int a, int b)
{
    double[,] array = new double[a, b];
    return array;
}

double [,] FillArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = Math.Round((new Random().Next() + new Random().NextDouble()),4);
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

double [,] MyArray = NewArray(num1, num2);
FillArray(MyArray);
PrintArray(MyArray);