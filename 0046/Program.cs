// Написать программу масштабирования фигуры. Берем восьмиугольник.

double[,] octagon = new double[,] // 1 столбец - координаты x, 2 - y., 3 - расстояние от середины фигуры до этой точки
{
    { -1, 3, 0},   //1
    { 1, 3, 0},    //2
    { 3, 1, 0},    //3
    { 3, -1, 0},   //4
    { 1, -3, 0},   //5
    { -1, -3, 0},  //6
    { -3, -1, 0},  //7
    { -3, 1, 0},   //8
    { 0, 0, 0}      //середина
};

//мы знаем, что противоположные точки в фигуре это 1 и 5, 2 и 6, 3 и 7, 4 и 8.
// находим координаты середины. это пересечение линий между этими точками
// ищем пересечение между точками 1/5 и 2/6
// y = a1*x+b1
// y = a2*x+b2
double a1 = (octagon[0, 1] - octagon[4, 1]) / (octagon[0, 0] - octagon[4, 0]);  // a1 = (1y-5y)/(1x-5x)
double a2 = (octagon[1, 1] - octagon[5, 1]) / (octagon[1, 0] - octagon[5, 0]);  // a2 = (2y-6y)/(2x-6x)
double b1 = octagon[0, 1] - a1 * octagon[0, 0]; // b1 = 1y - a1*1x = 5y - a1*5x
double b2 = octagon[1, 1] - a2 * octagon[1, 0]; // b2 = 2y - a2*2x = 6y - a2*6x
octagon[8, 0] = (b2 - b1) / (a1 - a2); // x = (b2 - b1)/(a1-a2)
octagon[8, 1] = a1 * octagon[8, 0] + b1;

Console.WriteLine($"x = {octagon[8, 0]}, y = {octagon[8, 1]}");


void distance(double[,] array) //метод для нахождения расстояния между серединой многоугольника и его точками. Сразу записываем в массив.
{
    for (int i = 0; i < array.GetLength(0) - 1; i++)
    {
        array[i, 2] = Math.Round(Math.Sqrt((Math.Pow((array[array.GetLength(0) - 1, 0] - array[i, 0]), 2) + Math.Pow((array[array.GetLength(0) - 1, 1] - array[i, 1]), 2))), 3);
    }
}

void PrintA(double[,] array)       //для проверки выводим расстояние до точек
{
    for (int i = 0; i < array.GetLength(0) - 1; i++)
    {
        Console.WriteLine($"Расстояние от центра до точки {i + 1} = {array[i, 2]}");
    }
}

//x новой точки = 0,5 * scale * x старая точка−x0
//y новая точка = 0,5 * scale * y старая точка - y0
void scaling(double n, double[,] array)             //переписываем масштабированный массив
{
    for (int i = 0; i < array.GetLength(0) - 1; i++)
    {
        array[i, 0] =  n * array[i, 0] - array[array.GetLength(0) - 1, 0];
        array[i, 1] = n * array[i, 1] - array[array.GetLength(0) - 1, 1];
        array[i, 2] = n * array[i, 2];
    }
}
 void PrintB(double[,] array)       // пишем метод для печати координат
 {
      Console.WriteLine("     x      y    distance");
     for (int i = 0; i < array.GetLength(0); i++)
     {
         Console.WriteLine($"1 = {octagon[i,0]}  {octagon[i,1]}  {octagon[i,2]} ");
     }
 }   

double scale = 2; 

distance(octagon);
PrintA(octagon);
Console.WriteLine();
scaling(scale, octagon);
PrintB(octagon);

// написать метод перемещения фигуры
