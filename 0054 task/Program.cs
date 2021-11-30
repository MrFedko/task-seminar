// В матрице чисел найти сумму элементов главной диагонали

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

int summ(int[,] array)
{
    int j = 0;
    int summ = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        summ = array[i,j] + summ;
        j++;
    }
    return summ;
}

int[,] MyArray = NewArray(str, coll);
FillArray(MyArray);
PrintArray(MyArray);
Console.WriteLine(summ(MyArray));
