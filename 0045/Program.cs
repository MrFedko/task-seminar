// Показать числа Фибоначчи

double[] array = new double[50];
array[0] = 0;
array[1] = 1;
for (int i = 2; i < array.Length; i++) array[i] = array[i - 1] + array[i - 2];
for (int j = 0; j < array.Length; j++) Console.WriteLine(array[j]);