// Дано число. Проверить кратно ли оно 7 и 23

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());


bool number (int n)
{
    return (n % 7 == 0) && (n % 23 == 0);
}

if (number(num) == true)
{
    Console.WriteLine($"Число {num} кратно 7 и 23");
}
else
{
    Console.WriteLine($"Число {num} не кратно 7 и 23");
}





// if ((num % 7 == 0) && (num % 23 == 0))
// {
//     Console.WriteLine($"Число {num} кратно 7 и 23");
// }
// else
// {
//     Console.WriteLine($"Число {num} не кратно 7 и 23");
// }