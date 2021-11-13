// найти третью цифру числа или сообщить что её нет
Console.WriteLine("Введите натуральное число: ");
int num = Convert.ToInt32(Console.ReadLine());

int third( int n)
{
    return (n/100)%10;
}
if (num/100 == 0)
{ 
    Console.WriteLine($"У числа {num} нет третьей цифры");
}
else
{
    Console.WriteLine($"Треттья цифра числа {num} = {third(num)}");
}