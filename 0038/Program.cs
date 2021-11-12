// Найти сумму чисел одномерного массива стоящих на нечетной позиции

int length = 100;
int[] array = new int[length];

for (int i = 0; i < array.Length; i++) array[i] = new Random().Next(0, 1000);     //заполняем

int summ(int [] a)
{
    int summ = 0;
    for(int i = 0; i < a.Length; i++)
    {
        if(i%2 != 0)
        summ = summ + a[i];
    }
    return summ;
}
Console.WriteLine($"Сумма элементов массива, стоящих на нечетной позиции = {summ(array)}");