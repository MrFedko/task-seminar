// Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. 
// Первые два элемента последовательности задаются пользователем

int Request(string message)
{
    Console.WriteLine(message);
    string line = Console.ReadLine();
    return Convert.ToInt32(line);
}

int numberA = Request("Введите число A: ");
int numberB = Request("Введите чило В: ");
int count = Request("Введите количество чисел в последовательности: ");

string Sequence(int a, int b, int c)
{
    return c == 0 ? $"{a}" : $"{a} {Sequence(b, a+b, c-1)}";
}

Console.WriteLine(Sequence(numberA, numberB, count-1));