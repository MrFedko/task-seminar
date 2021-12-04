// В некотором машинном алфавите имеются четыре буквы «х», «й», «о» и «п». 
// Покажите все слова, состоящие из n букв, которые можно построить из букв этого алфавита

int Request(string message)
{
    Console.WriteLine(message);
    string line = Console.ReadLine();
    return Convert.ToInt32(line);
}

int count = Request("Введите количество букв: ");

void NewWords(string our, char[] words, int length = 0)
{
    if (length == words.Length)
    {
        Console.WriteLine($"{new String(words)}"); return;
    }
    for (int i = 0; i < our.Length; i++)
    {
        words[length] = our[i];
        NewWords(our, words, length + 1);
    }
}

NewWords("хйоп", new char[count]);