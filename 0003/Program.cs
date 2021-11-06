//По заданному номеру дня недели, вывести его название

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
    Console.WriteLine($"Этот день недели на английском будет называться {DayName(day)}");
}

// Console.WriteLine("Введите номер дня недели: ");
// int num = Convert.ToInt16 (Console.ReadLine());

// string DayName(int DayNumber)
// {
//     string result = String.Empty;
//     if (DayNumber == 1) result = result + "Monday";
//     if (DayNumber == 2) result = result + "Tuesday";
//     if (DayNumber == 3) result = result + "Wednesday";
//     if (DayNumber == 4) result = result + "Thursday";
//     if (DayNumber == 5) result = result + "Friday";
//     if (DayNumber == 6) result = result + "Saturday";
//     if (DayNumber == 7) result = result + "Sunday";
//     return result;
// }

// if ((num < 1) || (num > 7))
// {
//     Console.WriteLine("Такого дня недели еще не придумали.");
// }
// else
// {
//     Console.WriteLine($"На аглицком он зовётся {DayName(num)}");
// }