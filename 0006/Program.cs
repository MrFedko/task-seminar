// выяснить является ли число четным

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32 (Console.ReadLine());

string initialNumber(int number)
{
    string answer = String.Empty;
    if(number % 2 == 0) answer = answer + "Число является чётным";
    else answer = answer + "Число является нечётным";
    return answer;
}

Console.WriteLine($"{initialNumber(num)}");