// Показать числа Фибоначчи

int length = 50;
double[] array = new double[length];
array[0] = 0;
array[1] = 1;
void FA(double[] a)
{
    for (int i = 2; i < a.Length; i++) a[i] = a[i - 1] + a[i - 2];
}
FA(array);
for (int j = 0; j < array.Length; j++) Console.WriteLine(array[j]);