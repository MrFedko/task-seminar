// Дано число обозначающее день недели. Выяснить является номер дня недели выходным 

Console.WriteLine("Введите номер дня недели: ");
int day = Convert.ToInt32(Console.ReadLine());

string DayName (int number)
{
    string[] dayweek = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};
    return dayweek[number -1]; 
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