// Задать двумерный массив следующим правилом: Aₘₙ = m+n

Console.WriteLine("Введите число строк: ");
int num1 = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Введите число столбцов: ");
int num2 = Convert.ToInt16(Console.ReadLine());

int[,] NewArray(int a, int b)
{
    int[,] array = new int[a, b];
    return array;
}

int[,] WriteArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = i + j;
        }
    return array;
}

NewArray(num1, num2);