// Показать кубы чисел, заканчивающихся на четную цифру

Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 1)
{
    Console.WriteLine($"Число {number} не является натуральным.");
    return;
}

for ( int i = 1; i <= number; i++)
{
    if(i % 2 == 0) Console.WriteLine($"{i}^3 = {Math.Pow(i,3)}");
}