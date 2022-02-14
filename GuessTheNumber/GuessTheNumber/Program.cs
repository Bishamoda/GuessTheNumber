// See https://aka.ms/new-console-template for more information
int secretNumber;
int userNumber;
int count = 0;
bool isWin = false;
bool isNumber = false;
bool userNameValidation = false;
string? name;
string? inputNumber;

Random randomNumber = new();
secretNumber = randomNumber.Next(0, 999);

Console.WriteLine("Кто ты воин?");
do
{
    name = Console.ReadLine();
    if (String.IsNullOrWhiteSpace(name))
        Console.WriteLine($"{name} - это не строка! Андрей, ну широкую на широкую!\n");
    else
        userNameValidation = true;
} while (!userNameValidation);

Console.WriteLine($"Я хочу сыграть с тобой в игру, {name}!");
Console.WriteLine("Ты уже целый год изучаешь С#, но всё еще не постиг всех знаний ООП, паттернов и чистого кода!\n" +
    "Предлагаю тебе выход! Просто выбери число от 0 до 999.\n");

while (!isWin)
{
    do
    {
        count++;
        inputNumber = Console.ReadLine();
        isNumber = int.TryParse(inputNumber, out userNumber);

        if (!isNumber)
            Console.WriteLine("Не ну ты фрнцуз! Это не число...\n " + "Попробуй еще раз:");
        else
            isNumber = true;
    } while (!isNumber);

    if (userNumber < secretNumber)
    {
        Console.WriteLine("Ты выбрал слишком маленькое число... Тебя заждался Delphi!\n" 
            + "Попробуй еще раз:");
    }
    else if (userNumber > secretNumber)
    {
        Console.WriteLine("Ты выбрал слишком большое число... Хочешь уйти в JS?\n" 
            + "Попробуй еще раз:");
    }
    else if (userNumber == secretNumber)
    {
        isWin = true;
        Console.WriteLine($"Ты сделал правильный выбор. .Net-чики нам нужны! Смотри сколько попыток ты сделал -  {count}.");
    }
}
