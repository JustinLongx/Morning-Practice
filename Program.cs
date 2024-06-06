using System.Diagnostics.CodeAnalysis;

namespace Morning_Practice
{
    internal class Program
    {


        static void Main(string[] args)
        { 
            

            var truck = new Car();
            truck.Make = "Ford";
            truck.Year = 2017;
            truck.Model = "F150";


            Console.WriteLine($"The truck make is {truck.Make}");
            Console.WriteLine($"The truck model is {truck.Model}");
            Console.WriteLine($"The truck year is {truck.Year}");


        }

     

    }


}

