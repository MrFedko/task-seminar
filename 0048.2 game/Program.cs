// игра одной колодой 52 карты.
// Значения очков каждой карты: от двойки до десятки — от 2 до 10 соответственно
// у туза — 1 или 11 (11 пока общая сумма не больше 21, далее 1), у т. н. картинок (король, дама, валет) — 10.
// при одинаковом счете - ничья.
// Общее правило блек-джека состоит в том, что дилер обязан остановиться, как только наберёт 17 очков или выше, и обязан брать, пока не достигнет (даже если у всех не перебравших меньше очков)
// Если у игрока сразу после раздачи набралось 21 очко (то есть у игрока туз и десятиочковая карта)
// то такая ситуация и называется блек-джек. В таком случае игроку сразу выплачивается выигрыш 3 к 2 (то есть в 1,5 раза превышающий его ставку). 
// Исключение составляют случаи, когда дилеру первой картой (открытой) попадается 10, картинка или туз. 
// В этом случае существует вероятность, что у дилера также будет блек-джек, 
// поэтому игроку с блек-джеком предлагается либо взять выигрыш 1 к 1 (только если первая карта дилера — туз), 
// либо дождаться окончания конца игры (и в случае, если у дилера не блек-джек, получить выигрыш 3 к 2).
// Далее игрокам, у которых не блек-джек, предлагается на выбор либо взять ещё карту 
// (в таком случае игрок должен сказать дилеру «карту» или «ещё», англ. hit me), 
// либо остаться при тех картах, которые у него на руке (в этом случае игрок должен сказать дилеру «достаточно» или «хватит»).
// Как правило, если у игрока после взятия новой карты в сумме получается 21, дилер не спрашивает его больше и переходит к себе.
// Если у игрока после взятия новой карты сумма очков превысит 21, то Дилер произносит «много» и снимает ставку игрока в пользу казино.
// Если у дилера в первых двух картах набирается 21 очко, то все игроки (кроме тех, у кого тоже блек-джек), проигрывают. 
// После того, как игрок завершил брать карты, дилер говорит «себе» и раздаёт карты себе. 

// методы:
// создаем "коллоду" 
// {2h, 3h, 4h, 5h, 6h, 7h, 8h, 9h, 10h, Jh, Qh, Kh, Ah} Heart черви
// {2d, 3d, 4d, 5d, 6d, 7d, 8d, 9d, 10d, Jd, Qd, Kd, Ad} Dimond буби
// {2c, 3c, 4c, 5c, 6c, 7c, 8c, 9c, 10c, Jc, Qc, Kc, Ac} Club трефа
// {2s, 3s, 4s, 5s, 6s, 7s, 8s, 9s, 10s, Js, Qs, Ks, As} Spade пика
// реализовать систему считывания розданных карт и их суммы. (сколько очков у той или иной карты) помним про туз 1 или 11
// метод по раздаче карт (не должны повторяться ни с одной картой на столе). в методе выдается 1 карта, дальше встроить это в метод запроса хода
// создаем массив "стол" 2 строки 6 столбцов. (максимально в 21 очко вмещается 6 карт)
// метод запроса хода игрока и переход хода диллеру по его желанию. т.е. 2 варианта: "ещё" и "достаточно"
// диллер берет, пока его очки не будут равны 17 или больше. как только он перешел этот рубеж, стоп.
// метод считывания суммы карт и вывода ответа (выводить сумму если она меньше 21 и бранные слова при переборе)
// игроку сразу раздается туз и 10, выводим сообщение "Блэк джек" и диллер открывает 1 карту и если она не == тузу или 10, то он проиграл.
// если у диллера 10, то игрок выбирает, продолжить диллеру или нет. если игрок отказался, то он выйграл.
// если у диллера туз, то диллер берет еще карты, пока не наберет 17 или более очков.
// метод выведения в консоль карточного стола со всеми картами. Очищать консоль перед каждым ходом.

string cards = "2h 3h 4h 5h 6h 7h 8h 9h 10h Jh Qh Kh Ah 2d 3d 4d 5d 6d 7d 8d 9d 10d Jd Qd Kd Ad 2c 3c 4c 5c 6c 7c 8c 9c 10c Jc Qc Kc Ac 2s 3s 4s 5s 6s 7s 8s 9s 10s Js Qs Ks As";
string[] deck = cards.Split(' ');
int[] PlayerCard = new int[2];
int[] DealerCard = new int[1];

int HowMuch(int num)        //считаем ценность карты
{
    if (num == 0) return 2;
    if (num % 13 == 12) return 1;
    else if (num % 13 == 11 || num % 13 == 10 || num % 13 == 9 || num % 13 == 8) return 10;
    else return ((num % 13) + 2);
}

int HowMuchAll(int[] array)        //подсчет карт на руках
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        sum = HowMuch(array[i]) + sum;
    }
    for (int j = 0; j < array.Length; j++)
    {
        if ((sum + 10) <= 21 && HowMuch(array[j]) == 1) return sum += 10;
    }
    return sum;
}

int NextCard()      //рандомно выбираем карту
{
    return new Random().Next(0, 52);
}

void Table()     //вывод суммы и карт на экран
{
    Console.WriteLine($"Сумма игрока: {HowMuchAll(PlayerCard)}");
    Console.WriteLine("Карты игрока: ");
    for (int i = 0; i < PlayerCard.Length; i++)
    {
        Console.Write($"{deck[PlayerCard[i]]}   ");
    }
    Console.WriteLine(); Console.WriteLine();
    Console.WriteLine($"Сумма диллера: {HowMuchAll(DealerCard)}");
    Console.WriteLine("Карты диллера: ");
    for (int i = 0; i < DealerCard.Length; i++)
    {
        Console.Write($"{deck[DealerCard[i]]}   ");
    }
    Console.WriteLine(); Console.WriteLine("________________________________________");
}

int[] FirstDistribution(int[] player, int[] dealer)     //первая раздача игроку
{
    for (int i = 0; i < player.Length; i++)
        for (int k = 1; k < player.Length; k++)
        {
            player[i] = NextCard();
            if (player[k] == player[i]) player[i] = NextCard();
        }
    return player;
}

int[] FirstDealer(int[] player, int[] dealer)      //первая раздача диллеру. 1 карта
{
    for (int i = 0; i < dealer.Length; i++)
        for (int j = 0; j < player.Length; j++)
        {
            dealer[i] = NextCard();
            if (dealer[i] == player[j]) dealer[i] = NextCard();
        }
    return dealer;
}

int[] NextMove(int[] one, int[] two)        // ход
{
    int[] array = new int[one.Length + 1];
    for (int i = 0; i < one.Length; i++)
    {
        array[i] = one[i];
    }
    array[array.Length - 1] = NextCard();
    for (int i = 0; i < array.Length - 1; i++)
        for (int j = 0; j < two.Length; j++)
        {
            while (array[array.Length-1] == two[j] || array[array.Length-1] == array[i]) array[one.Length] = NextCard();
        }
    return array;
}

int[] LastCall(int[] player, int[] dealer)        // набор карт диллером после окончания ходов игрока.
{
    while (HowMuchAll(dealer) < 17)
    {
        dealer = NextMove(dealer, player);
    }
    return dealer;
}

void score()       //подсчет и выведение результата
{
    if (HowMuchAll(PlayerCard) == 21 && HowMuchAll(PlayerCard) < 21) Console.WriteLine("Ты прогирал....");
    if (HowMuchAll(PlayerCard) < HowMuchAll(DealerCard) && HowMuchAll(DealerCard) <= 21) Console.WriteLine("Ты проиграл.");
    if (HowMuchAll(PlayerCard) > HowMuchAll(DealerCard) && HowMuchAll(DealerCard) < 21 && HowMuchAll(PlayerCard) < 21) Console.WriteLine("Ты выйграл!!!!");
    if (HowMuchAll(PlayerCard) == HowMuchAll(DealerCard)) Console.WriteLine("Ничья");
    if (HowMuchAll(PlayerCard) > 21) Console.WriteLine("Перебор....");
    if (HowMuchAll(PlayerCard) == 21)
    {
        DealerCard = LastCall(PlayerCard, DealerCard);
        Table();
        if (HowMuchAll(PlayerCard) > HowMuchAll(DealerCard) || HowMuchAll(DealerCard) > 21) Console.WriteLine("Black Jack!!!");
        if (HowMuchAll(PlayerCard) == HowMuchAll(DealerCard)) Console.WriteLine("Ничья");
    }

    if (HowMuchAll(DealerCard) > 21) Console.WriteLine("Ты  выйграл!!!");
}

FirstDistribution(PlayerCard, DealerCard);
FirstDealer(PlayerCard, DealerCard);
Table();

while (HowMuchAll(PlayerCard) < 21)
{
    Console.WriteLine("Ещё карту? Y / N ");
    char answer = Convert.ToChar(Console.ReadLine());
    if (answer == 'y' || answer == 'Y')
    {
        PlayerCard = NextMove(PlayerCard, DealerCard);
        Table();
    }
    else
    {
        DealerCard = LastCall(PlayerCard, DealerCard);
        Table();
        break;
    }
}

score();
