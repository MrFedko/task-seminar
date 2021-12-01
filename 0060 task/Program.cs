// Составить частотный словарь элементов двумерного массива

string little = "Так как я никогда в жизни не рисовал баранов"
                + " я повторил для него одну из двух старых картинок"
                + " которые я только и умею рисовать удава снаружи";

var littleArray = little.Split(" ").ToArray();

void PrintArrayNew(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}  ");
    }
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}  ");
    }
}

int[] Dictionary(string[] array)
{
    int[] array1 = new int[array.Length];
    int temp = 0;
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = 0; j < array.Length; j++)
        {
            if (array[i] == array[j]) temp++;
            array1[i] = temp;
        }
        temp = 0;
    }
    return array1;
}

PrintArrayNew(littleArray);
PrintArray(Dictionary(littleArray));
