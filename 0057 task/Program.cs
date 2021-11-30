// Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.

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

int[,] ReplaceString(int[,] array, int num)
{
    int temp = 0;
    for (int k = (array.GetLength(1) - 1); k != 0; k--)
        for (int i = 0; i < k; i++)
        {
            if (array[num, i] < array[num, i + 1])
            {
                temp = array[num, i + 1];
                array[num, i + 1] = array[num, i];
                array[num, i] = temp;
            }
        }
    return array;
}

int [,] ReplaceAllString(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++) ReplaceString(array, i);
    return array;
}

int[,] MyArray = NewArray(str, coll);
PrintArray(FillArray(MyArray));
Console.WriteLine();
PrintArray(ReplaceAllString(MyArray));