// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

int length = 12;
int[] array = new int[length];

for (int i = 0; i < array.Length; i++) array[i] = new Random().Next(100, 1000);     //заполняем


int even = 0;
int odd = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0) even++;
    else odd++;
}

Console.WriteLine($"В полученном массиве {even} четных и {odd} нечетных чисел.");

Console.WriteLine();
for (int j = 0; j < array.Length; j++) Console.WriteLine($"A{j + 1} = {array[j]}"); // для проверки выведем массив