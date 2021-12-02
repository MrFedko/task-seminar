// В двумерном массиве целых чисел. Удалить строку и столбец, на пересечении которых расположен наименьший элемент.

int str = 6;
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
            array[i, j] = new Random().Next(0, 1000);
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

(int minStr, int minCol, int minValue) FindMin(int[,] array)
{
    int minValue = array[0, 0];
    int minStr = 0;
    int minCol = 0;
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < minValue)
            {
                minValue = array[i, j];
                minStr = i;
                minCol = j;
            }
        }
    return (minStr, minCol, minValue);
}

int[,] ReWrite(int[,] array, int a, int b)
{
    int[,] newArray = new int[(array.GetLength(0)-1), (array.GetLength(1)-1)];
    int l = 0;
    int k = 0;
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        if(k == a && (k < array.GetLength(0) - 1)) k++;
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            if (l == b && (l < array.GetLength(1)-1)) l++;
            newArray[i, j] = array[k, l];
            if (l < (array.GetLength(1)-1))l++;
        }
        if(k < array.GetLength(0) - 1)k++;
        l = 0;
    }
    return newArray;
}

int[,] MyArray = NewArray(str, coll);
int[] Summ = new int[MyArray.GetLength(0)];
FillArray(MyArray);
PrintArray(MyArray);
Console.WriteLine();
(int minStr, int minCol, int minValue) result = FindMin(MyArray);
Console.WriteLine(result.Item3);

PrintArray(ReWrite(MyArray, result.minStr, result.minCol));
