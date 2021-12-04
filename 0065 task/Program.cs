// Спирально заполнить двумерный массив:
//   1  2  3  4
//  12 13 14  5
//  11 16 15  6
//  10  9  8  7 

int Request(string message)
{
    Console.WriteLine(message);
    string line = Console.ReadLine();
    return Convert.ToInt32(line);
}

int side = Request("Введите размер стобца/строки двумерного массива: ");

int[,] spiral = new int[side, side];

int[,] FillSpiral(int[,] array)
{
    int numbers = 1;
    int num = array.GetLength(0);
    if (num % 2 != 0) array[num / 2, num / 2] = num * num;
    for (int i = 0; i < (num / 2); i++)
    {
        for (int j = i; j < (num - i); j++)    //(num - i) - чтобы с каждым разом сторона становилась меньше
        {
            array[i, j] = numbers;
            numbers++;
        }
        for (int k = 1; k < (num - i - i); k++)// начинаем с первого эл. т.k. нулевой уже записан
        {
            array[k + i, (num - i) - 1] = numbers;// (num - i) - 1 - отнимаем 1 чтоб не выходило за рамки массива
            numbers++;
        }
        for (int l = (num - 2) - i; l >= i; l--) // (num - 2) - i - отнимаем 1 чтоб не выходило за рамки массива и еще одну 1 
        {
            array[(num - i) - 1, l] = numbers;
            numbers++;
        }
        for (int m = ((num - i) - 2); m > i; m--)
        {
            array[m,i] = numbers;
            numbers++;
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if ( array[i,j] < 10) Console.Write(" ");
            Console.Write($"{array[i, j]}  ");
        }
        Console.WriteLine();
    }
}

PrintArray(FillSpiral(spiral));