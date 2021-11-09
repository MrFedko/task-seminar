// Задать номер четверти, показать диапазоны для возможных координат

Console.WriteLine("Введите номер интересуемой четверти на координатной плоскости: ");
int quater = Convert.ToInt16(Console.ReadLine());
if (quater < 1 || quater > 4)
{
    Console.WriteLine("Такой четверти нет.");
    return;
}

int min = -2147483647;
int max = 2147483647;
string[] Qname = { "0", "2 147 483 647", "-2 147 483 647" };

if (quater == 1) Console.WriteLine($"Четверть №{quater} обладает диапозоном X(0, {max}); Y(0, {max})");
if (quater == 2) Console.WriteLine($"Четверть №{quater} обладает диапозоном X(0, {min}); Y(0, {max})");
if (quater == 3) Console.WriteLine($"Четверть №{quater} обладает диапозоном X(0, {min}); Y(0, {min})");
if (quater == 4) Console.WriteLine($"Четверть №{quater} обладает диапозоном X(0, {max}); Y(0, {min})");