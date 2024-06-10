using System.Diagnostics.CodeAnalysis;

namespace Morning_Practice
{
    internal class Program
    {


        static void Main(string[] args)
        {
            var books = new List<Book>();
            
            var book1 = new Book();


            book1.Title = "I Like Rocks";
            book1.Pages = 26;
            book1.OpenBook();
            books.Add(book1);
            

            var book2 = new Book();
            book2.Title = "Blah";
            book2.Pages = 7;
            book2.OpenBook(); 
            books.Add(book2);

            foreach (var book in books) 
            {
                Console.WriteLine($"Title: {book.Title} , Page Count: {book.Pages}");
            }

            
            
            

        }

     

    }


}

