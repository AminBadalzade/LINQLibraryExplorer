using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryClasses;

namespace LibraryData
{
    public static class AuthorData
    {
        public static List<Author> GetAuthors()
        {
            return new List<Author>
            {
                new Author(1, "William Shakespeare", "England", new DateTime(1564, 4, 23), new List<Book>()),
                new Author(2, "Jane Austen", "England", new DateTime(1775, 12, 16), new List<Book>()),
                new Author(3, "Charles Dickens", "England", new DateTime(1812, 2, 7), new List<Book>()),
                new Author(4, "Leo Tolstoy", "Russia", new DateTime(1828, 9, 9), new List<Book>()),
                new Author(5, "Mark Twain", "USA", new DateTime(1835, 11, 30), new List<Book>()),
                new Author(6, "George Orwell", "England", new DateTime(1903, 6, 25), new List<Book>()),
                new Author(7, "J.K. Rowling", "UK", new DateTime(1965, 7, 31), new List<Book>()),
                new Author(8, "Ernest Hemingway", "USA", new DateTime(1899, 7, 21), new List<Book>()),
                new Author(9, "Agatha Christie", "UK", new DateTime(1890, 9, 15), new List<Book>()),
                new Author(10, "Gabriel García Márquez", "Colombia", new DateTime(1927, 3, 6), new List<Book>()),
                new Author(11, "J.R.R. Tolkien", "UK", new DateTime(1892, 1, 3), new List<Book>()),
                new Author(12, "Paulo Coelho", "Brazil", new DateTime(1947, 8, 24), new List<Book>())
            };
        }
    }
}
