using System.Diagnostics.CodeAnalysis;

namespace Morning_Practice
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            NumberGuesser();
        }

        public static void NumberGuesser()
        {
            var r = new Random();
            var favNumber = r.Next(1, 50);
            int attempts = 0;

            Console.WriteLine("Try to guess what my favorite number is: 1-50");
            var userInput = int.Parse(Console.ReadLine());
            while (userInput != favNumber) 
            {
                if (userInput > favNumber)
                {
                    Console.WriteLine("Too High!");
                    attempts++;
                }
                else if (userInput < favNumber)
                {
                    Console.WriteLine("Too Low!");
                    attempts++;
                }
                

                Console.WriteLine($"Try again, you've made {attempts} attempts so far.");
                userInput = int.Parse(Console.ReadLine());
            }

            if (userInput == favNumber)
            {
                Console.WriteLine($"CONGRATZ! You completed this in {attempts} attempts.");
            }


        }
    }
}
