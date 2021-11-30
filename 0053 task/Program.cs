// В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет

Console.WriteLine("Введите число строк: ");
int num1 = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Введите число столбцов: ");
int num2 = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("Введите натуральное число от 0 до 100: ");
int number = Convert.ToInt16(Console.ReadLine());

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


void Finder(int[,] array, int num)
{
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == num) 
            {
                Console.WriteLine($"Число {num} размещено в строке {i + 1} и столбце {j + 1}");
                count++;
            }
        }
        if (count == 0) Console.WriteLine($"Числа {num} нет в массиве.");
}

int[,] MyArray = NewArray(num1, num2);
FillArray(MyArray);
PrintArray(MyArray);
Console.WriteLine();
Finder(MyArray, number);