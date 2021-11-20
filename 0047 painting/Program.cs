
int[,] picture = new int[,]
{
    {0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0},
    {0,0,0,0,0,0,0,0,1,0,1,0,0,0,0,0,0,0,0,0,0},
    {0,0,0,0,0,0,0,1,0,0,0,1,0,0,0,0,0,0,0,0,0},
    {0,0,1,1,1,1,1,0,0,0,0,0,1,1,1,1,1,0,0,0,0},
    {0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0},
    {0,0,0,0,1,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0},
    {0,0,0,0,0,1,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0},
    {0,0,0,0,0,0,1,0,0,0,0,0,1,0,0,0,0,0,0,0,0},
    {0,0,0,0,0,1,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0},
    {0,0,0,0,1,0,0,0,0,1,0,0,0,0,1,0,0,0,0,0,0},
    {0,0,0,1,0,0,0,1,1,0,1,1,0,0,0,1,0,0,0,0,0},
    {0,0,1,0,0,1,1,0,0,0,0,0,1,1,0,0,1,0,0,0,0},
    {0,0,0,1,1,0,0,0,0,0,0,0,0,0,1,1,0,0,0,0,0},
};

void ImagePrint(int[,] image)
{
    for (int i = 0; i < image.GetLength(0); i++)
    {
        for (int j = 0; j < image.GetLength(1); j++)
        {
            if (image[i, j] == 0) Console.Write($" ");
            else Console.Write($"+");
        }
        Console.WriteLine();
    }
}

void FillImage(int[,] image, int row, int col)
{
    if (image[row, col] == 0)
    {
        image[row, col] = 1;
        FillImage(image, row - 1, col);
        FillImage(image, row, col - 1);
        FillImage(image, row + 1, col);
        FillImage(image, row, col + 1);
    }
}


ImagePrint(picture);
FillImage(picture, 6, 9);
ImagePrint(picture);