Console.WriteLine("Введите число, степень которого необходимо найти: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степнь в которую необходимо возвести число: ");
int degree = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{number}^{degree} = {Math.Pow(number, degree)}");











// Console.WriteLine("Введите число, квадрат которого необходимо найти: ");
// long n = Convert.ToInt64(Console.ReadLine());
// long SquareN(long number)
// {
//     long square = number * number;
//     return square;
// }
// Console.WriteLine($"Квадрат {n} = {SquareN(n)}");