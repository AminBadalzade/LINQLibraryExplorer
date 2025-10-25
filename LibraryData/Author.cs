using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryData
{
    public class Author
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Country { get; set; }
        public DateTime? BirthDate { get; set; }
        public List<Book> Books { get; set; }

        public Author(int id, string fullName, string country, DateTime? birthDate, List<Book> books)
        {
            Id = id;
            FullName = fullName;
            Country = country;
            BirthDate = birthDate;
            Books = books;
        }
    }
}
