namespace DoWhile;

class Program
{
    static void Main(string[] args)
    {
        string secretWord = "tenis";
        string guess = "";
        int guessLimit = 3;
        int guessCount = 0;
        bool outOfGuesses = false;

        do
        {
            if (guessCount < guessLimit && !outOfGuesses)
            {
                Console.Write("Enter the Guess:");
                guess = Console.ReadLine()!;
                guessCount++;

                if (guess != secretWord && guessCount == guessLimit)
                {
                    outOfGuesses = true;
                    Console.WriteLine("Out of guesses! You made " + guessCount + " attempts.");
                }
            }

        } while (guess != secretWord && !outOfGuesses);

        if (guess == secretWord)
        {
            Console.WriteLine("Success! YOU WON!");
        }
        else
        {
            Console.WriteLine("YOU LOSE! The game had " + guessLimit + " attempts.");
        }

        Console.ReadLine();
    }
}
