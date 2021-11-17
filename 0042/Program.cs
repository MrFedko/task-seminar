// Определить сколько чисел больше 0 введено с клавиатуры
int length = 6;
int[] array = new int[length];

int counter(int[] a)
{
    int c = 0;
    for (int i = 0; i < a.Length; i++)
    {
        Console.WriteLine($"Введите элемент массива A{i}: ");
        a[i] = Convert.ToInt32(Console.ReadLine());
        if (a[i] > 0) c++;
    }
    return c;
}

Console.WriteLine($"В массиве {counter(array)} чисел больше 0");