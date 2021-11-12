// Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.

int length = 10;
int[] array = new int[length];

for (int i = 0; i < array.Length; i++) array[i] = new Random().Next(0, 100);     //заполняем


int end = array.Length - 1;
for (int j = 0; j < array.Length/2; j++)
{
    int pair = array[j]*array[end];
    Console.WriteLine($"A{j+1} * A{end+1} = {pair}");
    end--;
}

Console.WriteLine();
for (int j = 0; j < array.Length; j++) Console.WriteLine($"A{j + 1} = {array[j]}"); // для проверки выведем массив
