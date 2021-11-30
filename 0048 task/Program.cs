// Показать двумерный массив размером m×n заполненный целыми числами

Console.WriteLine("Введите число строк: ");
int num1 = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Введите число столбцов: ");
int num2 = Convert.ToInt16(Console.ReadLine());

int[,] NewArray(int a, int b)
{
    int[,] array = new int[a, b];
    return array;
}

int [,] FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next();
        }
        return array;
}

void PrintArray(int[,] array)
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

int [,] MyArray = NewArray(num1, num2);
FillArray(MyArray);
PrintArray(MyArray);