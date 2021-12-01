// Найти произведение двух матриц

int str = 3;
int coll = 4;

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
            array[i, j] = new Random().Next(-10, 10);
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

int[,] MatrixProduct(int[,] array1, int[,] array2)
{
    int[,] product = new int[array1.GetLength(0), array2.GetLength(1)];

    for (int i = 0; i < array1.GetLength(0); ++i)
        for (int j = 0; j < array2.GetLength(1); ++j)
            for (int k = 0; k < array1.GetLength(1); ++k)
                product[i, j] += array1[i, k] * array2[k, j];
    return product;
}

int[,] MyArray1 = NewArray(coll, str);
int[,] MyArray2 = NewArray(str, coll);
FillArray(MyArray1);
FillArray(MyArray2);
PrintArray(MyArray1);
Console.WriteLine();
PrintArray(MyArray2);
Console.WriteLine();
PrintArray(MatrixProduct(MyArray1, MyArray2));