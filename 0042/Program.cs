// Определить сколько чисел больше 0 введено с клавиатуры
int length = 6;
int [] array = new int [length];
for ( int i = 0; i < array.Length; i++)
{
    Console.WriteLine($"Введите елмент массива A{i}: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
int count = 0;

for(int j =0; j <array.Length; j++)
{
    if (array[j] > 0) count++;
}
Console.WriteLine($"В массиве {count} чисел больше 0");