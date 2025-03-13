using System;

public class GuessingGame
{
    private readonly int _secretNumber;
    public int Attempts { get; private set; }

    public GuessingGame(int? predefinedNumber = null)
    {
        _secretNumber = predefinedNumber ?? new Random().Next(1, 101);
        Attempts = 0;
    }

    public string Guess(int number)
    {
        Attempts++;

        if (number < _secretNumber)
            return "Загадане число більше.";
        if (number > _secretNumber)
            return "Загадане число менше.";
        return $"Ви вгадали число {_secretNumber} за {Attempts} спроб.";
    }
}

class Program
{
    static void Main()
    {
        GuessingGame game = new GuessingGame();
        int guess = 0;

        Console.WriteLine("Число загадано. Введіть число від 1 до 100:");

        while (true)
        {
            Console.Write("Ваш варіант: ");
            string input = Console.ReadLine();
            if (!int.TryParse(input, out guess))
            {
                Console.WriteLine("Потрібно ввести ціле число");
                continue;
            }

            string result = game.Guess(guess);
            Console.WriteLine(result);

            if (result.StartsWith("Ви")) break;
        }
    }
}
