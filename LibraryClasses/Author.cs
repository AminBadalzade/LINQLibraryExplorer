using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryClasses
{
    public class Author
    {
        private static int _nextId = 1;
        public readonly int AuthorId;
        public readonly string FullName;
        public readonly string Country;
        public readonly DateTime? BirthDate;
        public readonly List<Book> Books;

        public Author(int id, string fullName, string country, DateTime? birthDate, List<Book> books)
        {
            _nextId++;
            AuthorId = _nextId;
            FullName = fullName;
            Country = country;
            BirthDate = birthDate;
            Books = books;
        }
    }
}
