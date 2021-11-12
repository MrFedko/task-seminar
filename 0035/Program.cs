// Определить, присутствует ли в заданном массиве, некоторое число

Console.WriteLine("Введите натуральное число от -10 до 10: ");
int number = Convert.ToInt16(Console.ReadLine());

int length = 12;
int[] array = new int[length];

for (int i = 0; i < array.Length; i++) array[i] = new Random().Next(-10, 11);     //заполняем
for (int k = 0; k < array.Length; k++)
{
    if (array[k] == number) Console.WriteLine($"Число {number} присутствует в массиве.");
}
Console.WriteLine();
for (int j = 0; j < array.Length; j++) Console.WriteLine($"A{j + 1} = {array[j]}"); // для проверки выведем массив