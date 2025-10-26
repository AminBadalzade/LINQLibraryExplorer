using System.Windows;
using System.Windows.Controls;
using LibraryClasses;
using LibraryData;

namespace LINQLibraryExplorer
{
    public partial class MainWindow : Window
    {
        private Author selectedAuthor;
        private Genre selectedGenre;
        private string ChoiceForResult;

        private decimal MinPriceBook;
        private decimal MaxPriceBook;

        List<Author> Authors;
        List<Genre> Genres;
        List<Book> Books;

        public MainWindow()
        {
            InitializeComponent();

            Authors = AuthorData.GetAuthors();
            Genres = GenreData.GetGenres();
            Books = BookData.GetBooks(Authors, Genres);

            foreach (var author in Authors)
            {
                AuthorComboBox.Items.Add(author.FullName);
            }


            foreach (var genre in Genres)
            {
                GenreComboBox.Items.Add(genre.Name);
            }
        }



        
        private void AuthorComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (AuthorComboBox.SelectedItem != null) {
                string authorName = AuthorComboBox.SelectedItem.ToString();
                selectedAuthor = Authors?.FirstOrDefault(a => a.FullName == authorName);
            }
        }

        private void GenreComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (GenreComboBox.SelectedItem != null)
            {
                string genreName = GenreComboBox.SelectedItem.ToString();
                // Example: filter books by this genre
                selectedGenre = Genres?.FirstOrDefault(g => g.Name == genreName);

            }
        }


        private void MinPriceTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(decimal.TryParse(MinPriceTextBox.Text, out decimal value))
            {
                MinPriceBook = value;
            }
            else
            {
                MinPriceBook = 0;
            }

        }

        private void MaxPriceTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (decimal.TryParse(MaxPriceTextBox.Text, out decimal value))
            {
                MaxPriceBook = value;
            }
            else
            {
                MaxPriceBook = 100;
            }
        }

        private void RunQuery_Click(object sender, RoutedEventArgs e)
        {
            // Start with all books
            var query = Books.AsEnumerable();

            // Filter by Author
            if (selectedAuthor != null)
                query = query.Where(b => b.Author == selectedAuthor);

            // Filter by Genre
            if (selectedGenre != null)
                query = query.Where(b => b.Genre == selectedGenre);

            // Apply price filter
            query = query.Where(b => b.Price >= MinPriceBook && b.Price <= MaxPriceBook);

            //Working with user's selected options in ListBox

            var selectedOperations = OperationsListBox.SelectedItems
                .Cast<ListBoxItem>()
                .Select(i => i.Content.ToString())
                .ToList();

            List<string> outputLines = new List<string>();

            foreach (var op in selectedOperations)
            {
                switch (op)
                {
                    case "Top 5 Expensive":
                        var topExpensive = query.OrderByDescending(b => b.Price).Take(5);
                        outputLines.Add("--- Top 5 Expensive ---");
                        outputLines.AddRange(topExpensive.Select(b => b.ToString()));
                        break;

                    case "Top 5 Modern":
                        var topModern = query.OrderByDescending(b => b.YearPublished).Take(5);
                        outputLines.Add("--- Top 5 Modern ---");
                        outputLines.AddRange(topModern.Select(b => b.ToString()));
                        break;

                    case "Average Price":
                        var avgPrice = query.Any() ? query.Average(b => b.Price) : 0;
                        outputLines.Add($"--- Average Price ---\n{avgPrice:C}");
                        break;

                    case "Group by Author":
                        var grouped = query.GroupBy(b => b.Author)
                                           .OrderByDescending(g => g.Count());
                        outputLines.Add("--- Group by Author ---");
                        foreach (var group in grouped)
                        {
                            outputLines.Add($"{group.Key.FullName}: {group.Count()} books");
                        }
                        break;

                }
            }

            if (!selectedOperations.Any())
            {
                outputLines.AddRange(query.Select(b => b.ToString()));
            }

            resultWindow.Text = string.Join(Environment.NewLine, outputLines);
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedOperations = OperationsListBox.SelectedItems
                .Cast<ListBoxItem>()   
                .Select(item => item.Content.ToString())
                .ToList();

            List<MultipleOperations> operationsEnums = new List<MultipleOperations>();

            foreach(var op in selectedOperations)
            {
                switch (op)
                {
                    case "Top 5 Expensive":
                        operationsEnums.Add(MultipleOperations.Top5Expensive);
                        break;
                    case "Top 5 Modern":
                        operationsEnums.Add(MultipleOperations.Top5Modern);
                        break;
                    case "Average Price":
                        operationsEnums.Add(MultipleOperations.AveragePrice);
                        break;
                    case "Group by Author":
                        operationsEnums.Add(MultipleOperations.GroupByAuthor);
                        break;
                }
            }
        }

        enum MultipleOperations
        {
            Top5Expensive,
            Top5Modern,
            AveragePrice,
            GroupByAuthor,
            CustomFilter
        }
    }

}
