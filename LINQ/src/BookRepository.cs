using System.Collections.Generic;

namespace LINQ
{
    public class BookRepository
    {
        public static List<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book {Title = "ADO.Net Step by Step", Price = 5},
                new Book {Title = "ASP.Net MVC", Price = 9.99f},
                new Book {Title = "ADO.Net Web APO", Price = 20},
                new Book {Title = "ADO.Net Advanced Topics", Price = 7},
                new Book {Title = "ADO.Net Advanced Topics", Price = 12},
                new Book {Title = "ADO.Net Intermediate Topics", Price = 15},
                new Book {Title = "ADO.Net Beginner Topics", Price = 2}
            };
        }
    }
}