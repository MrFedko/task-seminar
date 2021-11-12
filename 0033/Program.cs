// Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива

int length = 12;
int[] array = new int[length];

for (int i = 0; i < length; i++) array[i] = new Random().Next(-9, 10);
for (int j = 0; j < length; j++) Console.WriteLine($"A{j + 1} = {array[j]}");

int summ = 0;
int summ1 = 0;
for (int k = 0; k < length; k++)
{
    if (array[k] > 0) summ = summ + array[k];
    if (array[k] < 0) summ1 = summ1 + array[k];
}
Console.WriteLine($"сумма отрицательных элементо массива = {summ1}, а положительных = {summ}");