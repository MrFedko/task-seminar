// Написать программу замену элементов массива на противоположные

int length = 12;
int[] array = new int[length];

for (int i = 0; i < array.Length; i++) array[i] = new Random().Next(-100, 101);
for (int j = 0; j < array.Length; j++) Console.WriteLine($"A{j + 1} = {array[j]}");
Console.WriteLine();
for (int k = 0; k < array.Length; k++) array[k] = array[k] * -1;
for (int l = 0; l < array.Length; l++) Console.WriteLine($"newA{l + 1} = {array[l]}");