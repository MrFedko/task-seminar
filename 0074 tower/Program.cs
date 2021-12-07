// ханойская башня

void Tower(string with = "1", string on = "3", string some = "2", int count = 5)
{
    if (count > 1) Tower(with, some, on, count - 1);
    Console.WriteLine($"{with} >> {on}");
    if (count > 1) Tower(some, on, with, count - 1);
}

Tower();