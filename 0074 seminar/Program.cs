// создать набор данных

using System.Text;
using 

string [] namesauto = {"Toyota", "Aston Martin", "Audi", "Bentley", "BMW", "Brilliance", "Cadillac", "Changan", "Chery", "Chevrolet", "Chrysler"};
string[] type = new string [] {"Sedan", "Universal", "Pickup", "Hatchback", "Minivan", "Coupe"};
string[] db = new string[100];

Random n = new Random();
for (int i = 0; i < db.Length; i++)
{
    int year = new Random().Next(1900,2021);
    db[i] = $"{i};{namesauto[n.Next(namesauto.Length)]}; {type[n.Next(type.Length)]}; {year}";
    // System.Console.WriteLine(db[i]);
}
File.WriteAllLines("db.csv", db);

string[] db2 = File.ReadAllLines("db.csv");
for (int i = 0; i < db2.Length; i++)
{
    string[] line = db2[i].Split(';');
    for (int j = 0; j < line.Length; j++)
    {
        Console.Write($"{line[j]} ");
    }
    Console.WriteLine();
}
