Console.WriteLine("Введите число, квадрат которого необходимо найти: ");
int number = Convert.ToInt32(Console.ReadLine());

int qwerty = 89;
int SquareNumber(int num)
{
    int n = num * num;
    return n;
}

Console.WriteLine($"Квадрат {number} = {SquareNumber(number)}");











// Console.WriteLine("Введите число, квадрат которого необходимо найти: ");
// long n = Convert.ToInt64(Console.ReadLine());
// long SquareN(long number)
// {
//     long square = number * number;
//     return square;
// }
// Console.WriteLine($"Квадрат {n} = {SquareN(n)}");