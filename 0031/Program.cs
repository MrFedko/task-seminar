//Задать массив из 8 элементов и вывести их на экран
int length = 8;
int [] array = new int[length];

for (int i = 0; i < length; i++) array[i] = new Random().Next();
for (int j = 0; j < length; j++) Console.WriteLine($"A{j+1} = {array[j]}");
