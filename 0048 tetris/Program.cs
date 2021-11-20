
int[,] figure = new int[,]
{
    { 0, 1, 0, 0},
    { 0, 1, 1, 0},
    { 0, 1, 0, 0},
    { 0, 0, 0, 0},
};

void Rotate1(int[,] mas)
{
    Console.WriteLine("0123");
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = mas.GetLength(1) - 1; j >= 0; j--)
        {
            if (mas[j, i] == 0) Console.Write($" ");
            else Console.Write($"+");
        }
        Console.WriteLine($"{i}");
    }
}

void Rotate2(int[,] mas)
{
    Console.WriteLine("0123");
    for (int i = 0; i < mas.GetLength(1); i++)
    {
        for (int j = mas.GetLength(0) - 1; j >= 0; j--)
        {
            if (mas[i, j] == 0) Console.Write($" ");
            else Console.Write($"+");
        }
        Console.WriteLine($"{i}");
    }
}

void Rotate3(int[,] mas)
{
    Console.WriteLine("0123");
    for (int i = mas.GetLength(0) - 1; i >= 0; i--)
    {
        for (int j = mas.GetLength(1) - 1; j >= 0; j--)
        {
            if (mas[j, i] == 0) Console.Write($" ");
            else Console.Write($"+");
        }
        Console.WriteLine($"{Math.Abs(i-mas.GetLength(0)+1)}");
    }
}

void ImagePrint(int[,] image)
{
    Console.WriteLine("0123");
    for (int i = 0; i < image.GetLength(0); i++)
    {
        for (int j = 0; j < image.GetLength(1); j++)
        {
            if (image[i, j] == 0) Console.Write($" ");
            else Console.Write($"+");
        }
        Console.WriteLine($"{i}");
    }
}

ImagePrint(figure);
Rotate1(figure);
Rotate2(figure);
Rotate3(figure);
