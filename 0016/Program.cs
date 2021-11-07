// Дано число обозначающее день недели. Выяснить является номер дня недели выходным 

Console.WriteLine("Введите номер дня недели: ");
int day = Convert.ToInt32(Console.ReadLine());



string DayName (int number)
{
    string result = string.Empty;
    if(number == 1) result = result + "Monday";
    if(number == 2) result = result + "Tuesday";
    if(number == 3) result = result + "Wednesday";
    if(number == 4) result = result + "Thursday";
    if(number == 5) result = result + "Friday";
    if(number == 6) result = result + "Saturday";
    if(number == 7) result = result + "Sunday";
    return result;
}

if (day < 1 || day > 7)
{
    Console.WriteLine("Пользователь баран.");
    return;
}
else
{
    if ((day == 6) || (day == 7))
    {
        Console.WriteLine($"Этот день недели на английском будет называться {DayName(day)} и является выходным днем.");
    }
    else 
    {
        Console.WriteLine($"Этот день недели на английском будет называться {DayName(day)} и не является выходным днем.");
    }
}