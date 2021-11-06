// показать числа от -N до N
Console.WriteLine("Введите число N: ");
int num = Convert.ToInt32(Console.ReadLine());
if(num <= 0) 
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

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"{array[i]}");
    }
}

WriteArray(myArray, numMin);
PrintArray(myArray);