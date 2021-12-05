// Составить частотный словарь элементов двумерного массива

string little = "Так как я никогда в жизни не рисовал баранов"
                + " я я я я я повторил для него одну из двух старых картинок"
                + " которые я               только и умею рисовать удава снаружи".ToLower();

var littleArray = little.Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries).ToArray();

Dictionary<string, int> doc = new();

for (int i = 0; i < littleArray.Length; i++)
{
    if(!doc.ContainsKey(littleArray[i]))doc.Add(littleArray[i],1);
    else doc[littleArray[i]]++;
}
System.Console.WriteLine(doc["я"]);
foreach (var item in doc)
{
    System.Console.WriteLine(item.Value);
}

// void PrintArrayNew(string[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]}  ");
//     }
// }
// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]}  ");
//     }
// }



// int[] Dictionary(string[] array)
// {
//     int[] array1 = new int[array.Length];
//     int temp = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         for (int j = 0; j < array.Length; j++)
//         {
//             if (array[i] == array[j]) temp++;
//             array1[i] = temp;
//         }
//         temp = 0;
//     }
//     return array1;
// }

// PrintArrayNew(littleArray);
// PrintArray(Dictionary(littleArray));
