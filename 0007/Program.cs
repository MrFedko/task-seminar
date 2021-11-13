// показать числа от -N до N
Console.WriteLine("Введите натуральное число N: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num <= 0)
{
    Console.WriteLine("Введите натуральное число.");
    return;
}
int numMin = num - num * 2;

Console.WriteLine();

int[] myArray = new int[num * 2 + 1];

void WriteArray(int[] array, int start)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = start;
        start++;
    }
}

WriteArray(myArray, numMin);
for (int j = 0; j < myArray.Length; j++)
{
    Console.WriteLine($"{myArray[j]}");
}