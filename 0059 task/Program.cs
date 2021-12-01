// В прямоугольной матрице найти строку с наименьшей суммой элементов.

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

int[] SummStrings(int[,] array)
{
    int[] array1 = new int[array.GetLength(0)];
    int summ = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            summ = summ + array[i, j];
        }
        array1[i] = summ;
        summ = 0;
    }
    return array1;
}

int MinString(int[] array)
{
    int minvalue = array[0];
    int minindex = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (minvalue < array[1])
        {
            minvalue = array[i];
            minindex = i;
        }
    }
    return minindex;
}

void PrintMinString(int[,] array, int[] array1)
{
   array1 = SummStrings(array);
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write($"{array[MinString(array1), j]}  ");
    }
    Console.WriteLine($" Сумма этой строки: {array1[MinString(array1)]}");
}


int[,] MyArray = NewArray(str, coll);
int[] Summ = new int [MyArray.GetLength(0)];
FillArray(MyArray);
PrintArray(MyArray);
Console.WriteLine();
PrintMinString(MyArray, Summ);
