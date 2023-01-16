namespace number_guessing
{
    internal abstract class Code
    {
        private static void Main()
        {
            Random random = new Random();
            int min = 1;
            int max = 5;
            int guesses = 0; 
            int guess;
            int num = random.Next(min, max);
            bool playAgain = true;
            
            while (playAgain)
            {
                guess = 0;

                while (guess != num)
                {
                    Console.WriteLine($"Guess a number between {min} & {max} :");
                    guess = Convert.ToInt16(Console.ReadLine());

                    if (guess > num)
                    {
                        Console.WriteLine("Guess is too high, try again...");
                    } else if (guess < num)
                    {
                        Console.WriteLine("Guess is too low, try again...");
                    }
                    
                    guesses++;
                }
                
                Console.WriteLine("Yay, your guess is correct!");
                Console.WriteLine("Would you like to play again? y/n");
                string? usrAns = Console.ReadLine();
                usrAns = usrAns.ToLower();

                if (usrAns == "y")
                {
                    playAgain = true;
                }
                else if (usrAns == "n")
                {
                    playAgain = false;
                    Console.WriteLine($"Thanks for playing. You guessed {guesses} times!");
                }
            }
        }
    }
}