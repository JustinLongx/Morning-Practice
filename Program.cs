using System.Diagnostics.CodeAnalysis;

namespace Morning_Practice
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            NumberGuesser();
        }

        public static int NumberGuesser()
        {
            Random n = new Random();
            int randomNum = n.Next(1, 100);
            

            int attempts = 0;
            int guess;
            do
            {
                Console.WriteLine("What number am i thinking of between 1 - 100?");
                guess = int.Parse(Console.ReadLine());

                if (guess == randomNum)
                {
                    Console.WriteLine($"Congratz, {guess} was the correct guess!");
                    Console.WriteLine($"You completed the game with {attempts} attempts.");
                    Console.ReadLine();
                }
                else if (guess > randomNum)
                {
                    Console.WriteLine("Your guess was too high!");
                    attempts++;
                }
                else
                {
                    Console.WriteLine("Your guess was too low!");
                    attempts++;
                }
            } while (guess != randomNum);


            return randomNum;
        }

    }
}
