// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
int length = 123;
int[] array = new int[length];

for (int i = 0; i < array.Length; i++) array[i] = new Random().Next(0, 1000);     //заполняем

int counter = 0;
for (int j = 0; j < array.Length; j++)
{
    if(array[j]>10 && array[j] < 100) counter++;
}
Console.WriteLine($"Элементы из отрезка [10,99] встречаются в массиве {counter} раз");