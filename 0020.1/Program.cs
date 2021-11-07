// Задать номер четверти, показать диапазоны для возможных координат

int Quater(int x, int y)
{
    int quaterPos = 0;
    if (x > 0 && y > 0) quaterPos = 1;
    if (x > 0 && y < 0) quaterPos = 2;
    if (x < 0 && y < 0) quaterPos = 3;
    if (x < 0 && y > 0) quaterPos = 4;
    return quaterPos;
}

Console.WriteLine("Введите координату X, не равную 0: ");
int coorX = Convert.ToInt16(Console.ReadLine());
if (coorX == 0)
{
    Console.WriteLine("НЕ РАВНУЮ НУЛЮ!!!!");
    return;
}
Console.WriteLine("Введите координату Y, не равную 0: ");
int coorY = Convert.ToInt16(Console.ReadLine());
if (coorY == 0)
{
    Console.WriteLine("НЕ РАВНУЮ НУЛЮ!!!!");
    return;
}

int min = -2147483647;
int max = 2147483647;

string[] Qname = { "первой", "второй", "третьей", "четвертой" };
for (int i = 0; i < 5; i++)
{
    if (i == Quater(coorX, coorY))
    {
        i = i - 1;
        Console.WriteLine($"Точка с координатами ({coorX};{coorY}) находится в {Qname[i]} четверти");
        if (Quater(coorX, coorY) == 1) Console.WriteLine($"Четверть №{Quater(coorX, coorY)} обладает диапозоном X(0; {max}); Y(0; {max})");
        if (Quater(coorX, coorY) == 2) Console.WriteLine($"Четверть №{Quater(coorX, coorY)} обладает диапозоном X(0; {max}); Y(0; {min})");
        if (Quater(coorX, coorY) == 3) Console.WriteLine($"Четверть №{Quater(coorX, coorY)} обладает диапозоном X(0; {min}); Y(0; {min})");
        if (Quater(coorX, coorY) == 4) Console.WriteLine($"Четверть №{Quater(coorX, coorY)} обладает диапозоном X(0; {min}); Y(0; {max})");
        return;
    }
}



