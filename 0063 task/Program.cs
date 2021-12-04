// Сформировать трехмерный массив не повторяющимися двузначными числами 
// показать его построчно на экран выводя индексы соответствующего элемента

int str = 4;

int[,,] NewArray(int a)
{
    int[,,] array = new int[a, a, a];
    return array;
}

int[,,] FillArray(int[,,] array)
{
    int num = 10;
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = num++;
            }
    return array;
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.WriteLine($"{array[i, j, k]} ({i}, {j}, {k})");
            }
}

int [,,] MyArray = NewArray(str);
FillArray(MyArray);
PrintArray(MyArray);
