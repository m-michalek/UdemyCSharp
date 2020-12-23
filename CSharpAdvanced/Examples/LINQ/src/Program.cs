using System;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = BookRepository.GetBooks();
            
            // LINQ Extension Methods 
            var queriedBooks = books
                .Where(book => book.Price < 10)
                .OrderBy(book => book.Price);
            
            foreach (var book in queriedBooks)
            {
                Console.WriteLine(book.Title);
            }
            
            // Other methods
            // .Single                 .Min
            // .SingleOrDefault        .Max
            // .OrderBy                .Count
            // .First                  .Sum
            // .FirstOrDefault         .Average
            // Last                    .Skip
            // LastOrDefault           .Take
            
            Console.WriteLine();
            
            var averageBookPrice = books.Average(book => book.Price);

            Console.WriteLine($"Average book price: {averageBookPrice}");

            Console.WriteLine();
            
            // LINQ Query Operators
            // - gets internally converted to LINQ Extension Methods
            // - are a better readable alternative
            // - do not support all methods of LINQ Extension Methods
            // There is no right or wrong which to use
            var queriedBooksAlternative =
                from book in books
                where book.Price < 10
                orderby book.Title
                select book;

            foreach (var book in queriedBooksAlternative)
            {
                Console.WriteLine(book.Title);
            }
        }
    }
}