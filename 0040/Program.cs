// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

int length = 10;
double[] array = new double[length];

for (int i = 0; i < array.Length; i++) array[i] = Math.Round((new Random().Next(0, 100) + new Random().NextDouble()), 3);     //заполняем

Console.WriteLine();
for (int j = 0; j < array.Length; j++) Console.WriteLine($"A{j + 1} = {array[j]}"); // для проверки выведем массив

double difference(double[] a)
{
    double diff = 0;
    for (int i = 0; i < (a.Length - 1); i++)
    {
        int minPosition = i;
        int maxPosition = i;
        for (int j = i + 1; j < a.Length; j++)
        {
            if (a[j] < a[minPosition]) minPosition = j;
            if (a[j] > a[maxPosition]) maxPosition = j;
        }
        diff = a[maxPosition] - a[minPosition];
        return diff;
    }
    return diff;

}
Console.WriteLine($"Разница между максимальным и минмальным значением массива равна {difference(array):f3}");
