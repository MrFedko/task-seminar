// Написать программу, которая обменивает элементы первой строки и последней строки

int str = 10;
int coll = 10;

int[,] NewArray(int a, int b)
{
    int[,] array = new int[a, b];
    return array;
}

int[,] FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 100);
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

int[,] Replace(int[,] array)
{
    int[] array1 = new int[array.GetLength(1)];

    for (int i = 0; i == 0; i++)
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array1[j] = array[i, j];
            array[i, j] = array[(array.GetLength(0) - 1), j];
            array[(array.GetLength(0) - 1), j] = array1[j];
        }
    return array;
}

int[,] MyArray = NewArray(str, coll);
PrintArray(FillArray(MyArray));
Console.WriteLine();
PrintArray(Replace(MyArray));