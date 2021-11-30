// Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.

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
void PrintArrayNew(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}  ");
    }
}

int[] Middle(int[,] array)
{
    int[] array1 = new int[array.GetLength(1)];
    int summ = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            summ = summ + array[j, i];
        }
        array1[i] = summ / array.GetLength(1);
        summ = 0;
    }
    return array1;
}

int [,] MyArray = NewArray(str, coll);
FillArray(MyArray);
PrintArray(MyArray);
Console.WriteLine();
PrintArrayNew(Middle(MyArray));
