// игра угадай число
// комп загадывает число в некотором отрезке. у игрока несколько попыток. игрок вводит число. считается кол-во попыток. 
// комп говорит: число меньше или больше. или угадал.

// рандомное число из отрезка
// количество попыток
// инициализация игры и объясняем условие
// вводим с клавиатуры
// сравниваем с рандомным числом и говорим скольько попыток осталось
// пишем больше или меньше
// по истечении попыток пишем что проиграл
// GameInit() - метод иниализации игры
// MakeMove () - ходы задаются этим методом
// requestnumber() - запрос числа у игрока  и обработка нештатных ситуаций
// chek number (int playernumber, int Secretnumber)
// GameOver (bool winner)

int minValue = 0;
int maxValue = 0;
int attempt = 0;
int Secretnumber = 0;

int Request(string message)
{
    Console.WriteLine(message);
    string line = Console.ReadLine();
    return Convert.ToInt32(line);
}
void GameInit()     // вводим отрезок и количество попыток и задаем число
{
    Console.WriteLine("Сейчас мы будем играть. Тебе необходимо будет угадать число из отрезка, который ты определишь.");
    minValue = Request("Введи начало отрезкаю");
    maxValue = Request("Введи конец отрезкаю");
    for (int i = (maxValue - minValue); i != 0; i /= 2) attempt++;
    Console.WriteLine($"У тебя {attempt} попыток.");
    Secretnumber = new Random().Next(minValue, maxValue);
}

void CheckNumber(int num, int secret)   //сравниваем
{
    if (num < secret) Console.WriteLine("Это число меньше загаданного.");
    if (num > secret) Console.WriteLine("Это число больше загаданного.");
    if (num == secret) 
    {
        Console.WriteLine("Ты угадал.");
        Environment.Exit(1);
    }
}


void MakeMove()
{
    for (int i = attempt; i >= 0; i--)
    {
        if (i == 0)
        {
            Console.WriteLine("Ты проиграл!!!");
            return;
        }
        Console.WriteLine($"У тебя осталось {i} попыток.");
        int PlayerNumber = Request("Введите число.");
        Console.Clear();
        CheckNumber(PlayerNumber,Secretnumber);
    }
}

GameInit();
MakeMove();

// int minValue = 0;
// int maxValue = 100;
// int number = new Random().Next(minValue, maxValue);
// int attempt = 10;

// Console.WriteLine($"Я загадал число из отрезка {minValue}:{maxValue}. У тебя {attempt} попыток для того, чтобы его угадать. Начнем.");

// for (int i = 0; i < attempt; i++)
// {
//     Console.WriteLine($"У тебя осталось {attempt - i} попыток.");
//     int temp = Convert.ToInt32(Console.ReadLine());
//     if (temp < minValue || temp > maxValue) Console.WriteLine("Вы вышли за пределы отрезка.");
//     if (temp > number) Console.WriteLine("Это число больше загаданного.");
//     if (temp < number) Console.WriteLine("Это число меньше загаданного.");
//     if ( temp == number) 
//     {
//         Console.WriteLine("Ты угадал.");
//         break;
//     }
// }