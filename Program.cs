using System.Diagnostics.CodeAnalysis;

namespace Morning_Practice
{
    internal class Program
    {


        static void Main(string[] args)
        {


            //TODO:

            // Create an int array and populate it with numbers 1-10
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


            /* Create a list of type int
             * Name the list "evens"
             */
            var evens = new List<int>();

            /* Create another list of type int
             * Name the list "odds"
             */
            var odds = new List<int>();

            /* Using either a foreach or for loop,
            * iterate through the array you populated with 10 numbers.
            * Inside the scope of the loop,
            * check to see if each number in the array is even or odd.
            * If the number is even, add it to the evens list.
            * If the number is odd, add it to the odds list.
            */
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i % 2 == 0)
                {
                    evens.Add(i);
                }
                else 
                {
                    odds.Add(i);
                }    
            }


            /* Using a foreach loop,
             * display the numbers in your "evens" list
             */
            Console.WriteLine("Evens:");
            foreach (var item in evens)
            {
                
                Console.WriteLine(item);
            }

            /* Using a for loop,
             * display the numbers in your "odds" list
             */
            Console.WriteLine("Odds:");
            foreach (var item in odds)
            {
                Console.WriteLine(item);
            }
        }



    }


}

