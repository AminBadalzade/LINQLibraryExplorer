using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryClasses;


namespace LibraryData
{
    public static class BookData
    {
        public static List<Book> GetBooks(List<Author> authors, List<Genre> genres)
        {
            //I am using short names to refer our authors
            var shakespeare = authors.First(a => a.FullName == "William Shakespeare");
            var janeAusten = authors.First(a => a.FullName == "Jane Austen");
            var charlesDickens = authors.First(a => a.FullName == "Charles Dickens");
            var leoTolstoy = authors.First(a => a.FullName == "Leo Tolstoy");
            var markTwain = authors.First(a => a.FullName == "Mark Twain");
            var georgeOrwell = authors.First(a => a.FullName == "George Orwell");
            var jkRowling = authors.First(a => a.FullName == "J.K. Rowling");
            var hemingway = authors.First(a => a.FullName == "Ernest Hemingway");
            var agathaChristie = authors.First(a => a.FullName == "Agatha Christie");
            var marquez = authors.First(a => a.FullName == "Gabriel García Márquez");
            var tolkien = authors.First(a => a.FullName == "J.R.R. Tolkien");
            var paulo = authors.First(a => a.FullName == "Paulo Coelho");


            // Find genres by name for easy reference
            var fiction = genres.First(g => g.Name == "Fiction");
            var mystery = genres.First(g => g.Name == "Mystery");
            var fantasy = genres.First(g => g.Name == "Fantasy");
            var drama = genres.First(g => g.Name == "Drama");
            var romance = genres.First(g => g.Name == "Romance");
            var historical = genres.First(g => g.Name == "Historical Fiction");
            var nonFiction = genres.First(g => g.Name == "Non-Fiction");
            var scienceFiction = genres.First(g => g.Name == "Science Fiction");
            var historicalFiction = genres.First(g => g.Name == "Historical Fiction");
            var horror = genres.First(g => g.Name == "Horror");

            var books = new List<Book>
            {
                new Book(1, "Hamlet", shakespeare, drama, 1603, 19.99m),
                new Book(2, "Romeo and Juliet", shakespeare, romance, 1597, 17.99m),

                new Book(3, "Pride and Prejudice", janeAusten, romance, 1813, 14.99m),
                new Book(4, "Sense and Sensibility", janeAusten, romance, 1811, 13.99m),

                new Book(5, "A Tale of Two Cities", charlesDickens, historical, 1859, 18.50m),
                new Book(6, "Great Expectations", charlesDickens, fiction, 1861, 16.75m),

                new Book(7, "War and Peace", leoTolstoy, historical, 1869, 22.99m),
                new Book(8, "Anna Karenina", leoTolstoy, romance, 1878, 21.99m),

                new Book(9, "Adventures of Huckleberry Finn", markTwain, fiction, 1884, 15.50m),
                new Book(10, "The Adventures of Tom Sawyer", markTwain, fiction, 1876, 14.50m),

                new Book(11, "1984", georgeOrwell, fiction, 1949, 17.99m),
                new Book(12, "Animal Farm", georgeOrwell, fiction, 1945, 13.50m),

                new Book(13, "Harry Potter and the Philosopher's Stone", jkRowling, fantasy, 1997, 25.00m),
                new Book(14, "Harry Potter and the Chamber of Secrets", jkRowling, fantasy, 1998, 25.00m),

                new Book(15, "The Old Man and the Sea", hemingway, fiction, 1952, 14.00m),
                new Book(16, "A Farewell to Arms", hemingway, drama, 1929, 16.00m),

                new Book(17, "Murder on the Orient Express", agathaChristie, mystery, 1934, 18.99m),
                new Book(18, "And Then There Were None", agathaChristie, mystery, 1939, 19.99m),

                new Book(19, "One Hundred Years of Solitude", marquez, fiction, 1967, 22.50m),
                new Book(20, "Love in the Time of Cholera", marquez, romance, 1985, 21.50m),

                // === Additional books ===

                // Shakespeare
                new Book(21, "Macbeth", shakespeare, drama, 1606, 18.50m),
                new Book(22, "Othello", shakespeare, drama, 1604, 18.25m),
                new Book(23, "King Lear", shakespeare, drama, 1606, 19.75m),

                // Jane Austen
                new Book(24, "Emma", janeAusten, romance, 1815, 15.99m),
                new Book(25, "Mansfield Park", janeAusten, romance, 1814, 14.75m),

                // Charles Dickens
                new Book(26, "Oliver Twist", charlesDickens, drama, 1838, 15.25m),
                new Book(27, "David Copperfield", charlesDickens, fiction, 1850, 17.25m),
                new Book(28, "Bleak House", charlesDickens, drama, 1853, 18.00m),

                // Tolstoy
                new Book(29, "The Death of Ivan Ilyich", leoTolstoy, fiction, 1886, 12.50m),
                new Book(30, "Resurrection", leoTolstoy, drama, 1899, 15.99m),

                // Mark Twain
                new Book(31, "The Prince and the Pauper", markTwain, fiction, 1881, 13.75m),
                new Book(32, "A Connecticut Yankee in King Arthur's Court", markTwain, fiction, 1889, 14.25m),

                // George Orwell
                new Book(33, "Homage to Catalonia", georgeOrwell, nonFiction, 1938, 17.99m),
                new Book(34, "Down and Out in Paris and London", georgeOrwell, nonFiction, 1933, 15.50m),

                // J.K. Rowling
                new Book(35, "Harry Potter and the Prisoner of Azkaban", jkRowling, fantasy, 1999, 25.00m),
                new Book(36, "Harry Potter and the Goblet of Fire", jkRowling, fantasy, 2000, 27.50m),
                new Book(37, "Harry Potter and the Order of the Phoenix", jkRowling, fantasy, 2003, 29.50m),

                // Hemingway
                new Book(38, "For Whom the Bell Tolls", hemingway, drama, 1940, 19.00m),
                new Book(39, "The Sun Also Rises", hemingway, fiction, 1926, 18.00m),

                // Agatha Christie
                new Book(40, "The Murder of Roger Ackroyd", agathaChristie, mystery, 1926, 16.75m),
                new Book(41, "Death on the Nile", agathaChristie, mystery, 1937, 17.25m),
                new Book(42, "The A.B.C. Murders", agathaChristie, mystery, 1936, 18.50m),

                // Gabriel García Márquez
                new Book(43, "Chronicle of a Death Foretold", marquez, fiction, 1981, 19.50m),
                new Book(44, "No One Writes to the Colonel", marquez, fiction, 1961, 17.00m),

                // === Adding a few “bonus” well-known works for variety ===
                new Book(45, "The Hobbit", tolkien, fantasy, 1937, 23.99m),
                new Book(46, "The Lord of the Rings: The Fellowship of the Ring", tolkien , fantasy, 1954, 29.99m),
                new Book(47, "The Lord of the Rings: The Two Towers", tolkien, fantasy, 1954, 29.99m),
                new Book(48, "The Lord of the Rings: The Return of the King", tolkien , fantasy, 1955, 29.99m),

                new Book(49, "The Alchemist", paulo, fiction, 1988, 19.99m),
                new Book(50, "Veronika Decides to Die",paulo, drama, 1998, 17.99m)


               };

            foreach(var author in authors)
            {
                var authoredBooks = books.Where(b => b.Author == author).ToList();
                author.Books.AddRange(authoredBooks);
            }

            return books;
        }


    }
}
