// Выяснить кратно ли число заданному. Если нет, вывести остаток.

Console.WriteLine("Введите число A: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число B: ");
int num2 = Convert.ToInt32(Console.ReadLine());


int remainder(int number, int number1)
{
    int result = 0;
    result = number % number1;
    return result;
}

if (num % num2 == 0)
{ 
    Console.WriteLine($"Число {num} делится на {num2} без остатка");
}
else
{
    Console.WriteLine($"Остаток от деления {num} на {num2} = {remainder(num, num2)}");
}