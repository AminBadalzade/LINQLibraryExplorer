using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryData
{
    public class Book
    {
        private static int _nextId = 1;
        private static readonly List<Book> _allBooks = new List<Book>();

        public int Id { get; set; }
        public string Title { get; set; }
        public Author Author { get; set; }
        public Genre Genre { get; set; }
        public int YearPublished { get; set; }
        public decimal Price { get; set; }

        public Book(int id, string title, Author author, Genre genre, int yearPublished, decimal price)
        {

            if (string.IsNullOrWhiteSpace(title))
                throw new ArgumentException("Title cannot be empty.");
            else if (author == null)
                throw new ArgumentNullException(nameof(author));
            else if (genre == null)
                throw new ArgumentNullException(nameof(genre));
            else if (yearPublished < 0 || yearPublished > DateTime.Now.Year)
                throw new ArgumentOutOfRangeException(nameof(yearPublished), "Year is invalid.");

            Id = _nextId++;
            Title = title;
            Author = author;
            Genre = genre;
            YearPublished = yearPublished;
            Price = price;
        }
    }


}
