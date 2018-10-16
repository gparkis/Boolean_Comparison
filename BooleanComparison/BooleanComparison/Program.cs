using System;

namespace BooleanComparison
{
    class Program
    {
        static void Main()
        {
            int number = 3;
            bool playingGame = true;

            while (playingGame == true)
            {
                Console.WriteLine("Guess a number from 0 - 20");
                int userGuess = Convert.ToInt32(Console.ReadLine());

                if (userGuess != number)
                {
                    Console.WriteLine("WRONG TRY AGAIN...Guess a number from 0 - 20");
                    userGuess = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("You guessed right!");
                    playingGame = false;
                }
            }

            Console.Read();
        }
    }
}
