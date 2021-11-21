double [,] rectangle = new double [,]
{//   x  y   distance
    { -3, -2, 0},     //1 - точка середины масштабирования
    { -3, 2, 0},     //2
    { 3, 2, 0},     //3
    { 3, -2, 0}      //4
};

// пишим метод для нахождения расстояния до точек

// double distanceAB = Math.Sqrt((Math.Pow((AX - BX), 2) + Math.Pow((AY - BY), 2)));

void distance ( double [,] array)       // пишим метод для нахождения расстояния до точек
{
    for (int i = 1; i < array.GetLength(0); i++)
    {   
        array[i,2] = Math.Round(Math.Sqrt((Math.Pow((array[0,0] - array[i,0]), 2) + Math.Pow((array[0,1] - array[i,1]), 2))), 3);
    }
}

void PrintArray (double [,] array)
{
    Console.WriteLine("x    y     distance");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine($"{array[i,0]}    {array[i,1]}     {array[i,2]} ");
    }
}

// пишем метод масштабирования
//x новой точки = scale * x старая точка − x0
//y новая точка = scale * y старая точка - y0

void scale (double n, double [,] array )
{
    for (int i = 1; i < array.GetLength(0); i++)
    {
        array[i,0] = (n * array[i,0]) - array[0,0];
        array[i,1] = (n * array[i,1]) - array[0,1]; 
        array[i,2] = n * array[i,2];
    }
}

PrintArray(rectangle);
Console.WriteLine();
distance(rectangle);
double scalenum = 2;
scale (scalenum, rectangle);
PrintArray(rectangle);
