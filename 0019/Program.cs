// Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

int Quater(int x, int y)
{
    int quaterPos = 0;
    if (x > 0 && y > 0) quaterPos = 1;
    if (x < 0 && y > 0) quaterPos = 2;
    if (x < 0 && y < 0) quaterPos = 3;
    if (x > 0 && y < 0) quaterPos = 4;
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

string[] Qname = { "первой", "второй", "третьей", "четвертой" };
for (int i = 0; i < Qname.Length + 1; i++)
{
    if (i == Quater(coorX, coorY))
    {
        i = i - 1;
        Console.WriteLine($"Точка с координатами ({coorX};{coorY}) находится в {Qname[i]} четверти");
        return;
    }
}