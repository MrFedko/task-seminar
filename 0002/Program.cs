// Даны два числа. Показать большее и меньшее
Console.WriteLine("Введите первое число: ");
long n1 = Convert.ToInt64(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
long n2 = Convert.ToInt64(Console.ReadLine());

if (n1 == n2)
{
    Console.WriteLine("Эти числа равны.");
    return;
}

bool MaxMin(long number1, long number2)
{
    return number1 > number2;
}

if (MaxMin(n1, n2) == true)
{
    Console.WriteLine($"Число {n1} является бОльшим, а {n2} меньшим.");
}
else
{
    Console.WriteLine($"Число {n2} является бОльшим, а {n1} меньшим.");
}




// void First()
// {
//     Console.WriteLine($"Число {n1} больше числа {n2}");
// }
// void Second()
// {
//     Console.WriteLine($"Число {n2} больше числа {n1}");
// }

// if (n1 > n2)
// {
//     First();
// }
// else
// {
//     if (n1 == n2)
//     {
//         Console.WriteLine("Числа равны.");
//     }
//     else
//     {
//         Second();
//     }
// }