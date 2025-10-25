using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryClasses
{
    //The purpose of this class is to avoid duplications (book, author) in Library
    public class LibraryRepository
    {
        private readonly List<Book> _books = new List<Book>();

        public IEnumerable<Book> Books => _books;

        public void AddBook(Book book)
        {
            if (_books.Any(b => b.Title == book.Title && b.Author == book.Author && b.Genre == book.Genre))
            {
                throw new InvalidOperationException("This book already exists");
            }

            _books.Add(book);
        }

        private readonly List<Author> _authors = new List<Author>();

        public IEnumerable<Author> Authors => _authors;


        public void AddAuthor(Author author)
        {
            if (_authors.Any(b => b.FullName == author.FullName && b.Country == author.Country && b.BirthDate == author.BirthDate))
            {
                throw new InvalidOperationException("This author already exists");
            }

            _authors.Add(author);
        }
    }
}
