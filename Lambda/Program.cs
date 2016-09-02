using System;
using System.Linq;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks().ToList().FindAll(b => b.Price < 10);
            foreach (var book in books)
            {
                Console.WriteLine(book.Title);
            }
        }
    }
}
