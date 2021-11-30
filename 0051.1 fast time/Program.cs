using System.Diagnostics;
const int collumn = 4000;
int[,] array = new int[collumn, collumn];

int sum = 0;

Stopwatch sv = new (); //высокоточный таймер
sv.Start();

for (int i = 0; i < collumn; i++)
    for (int j = 0; j < collumn; j++)
    {
        sum += array[i, j];
    }
sv.Stop();

Console.WriteLine($"{sv.ElapsedMilliseconds}");