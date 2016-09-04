using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main()
        {
            var books = new BookRepository().GetBooks();

            var query = books.Where(b => b.Price < 5);

            Print(query);
        }

        private static void Print(Book query)
        {
            Console.WriteLine(query);
        }

        private static void Print(IEnumerable<Book> query)
        {
            foreach (var book in query)
            {
                Console.WriteLine(book);
            }
        }
    }
}
