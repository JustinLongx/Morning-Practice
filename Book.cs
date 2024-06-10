using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morning_Practice
{
    public class Book
    {
        public string Title { get; set; }
        public int Pages { get; set; }

        public void OpenBook()
        {
            Console.WriteLine("Book opens");
        }
    }
}
