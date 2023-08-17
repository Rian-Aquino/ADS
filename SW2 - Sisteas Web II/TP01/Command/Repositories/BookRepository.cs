using Command.Repository;
using System.Globalization;

/*
 Dupla:
 Gabriel Ferreira de Souza
 Rian Gustavo Quintanilha de Aquino
*/

namespace Command.Repositories
{
    public class BookRepository
    {
        private static readonly string booksCsvFilePath = "C:\\Users\\rian.aquino\\Documents\\ADS\\6º Semestre\\SW2 - Sistemas Web II\\TP01\\Command\\Command\\Database\\book.csv";
        private static readonly string authorsCsvFilePath = "C:\\Users\\rian.aquino\\Documents\\ADS\\6º Semestre\\SW2 - Sistemas Web II\\TP01\\Command\\Command\\Database\\author.csv";

        List<Author> _authors = new List<Author>();
        List<Book> _books = new List<Book>();

        public List<Author> Authors { get => _authors; set => _authors = value; }
        public List<Book> Books { get => _books; set => _books = value; }

        public BookRepository()
        {
            _authors = ReadAuthorsFromCsv();
            _books =  ReadBooksFromCsv();
        }

        public List<Author> ReadAuthorsFromCsv()
        {
            List<Author> authors = new List<Author>();

            using (StreamReader reader = new StreamReader(authorsCsvFilePath))
            {
                reader.ReadLine();

                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] fields = line.Split(',');

                    string name = fields[0];
                    string email = fields[1];
                    char gender = fields[2][0];

                    Author author = new Author(name, email, gender);
                    authors.Add(author);
                }
            }

            return authors;
        }

        public List<Book> ReadBooksFromCsv()
        {
            List<Book> books = new List<Book>();

            using (StreamReader reader = new StreamReader(booksCsvFilePath))
            {
                reader.ReadLine();

                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] fields = line.Split(',');

                    string bookName = fields[0];
                    double price = double.Parse(fields[2], NumberStyles.Any, CultureInfo.InvariantCulture);
                    int quantity = int.Parse(fields[3]);

                    string[] authorEmails = fields[1].Split(" ");
                    List<Author> bookAuthors = new List<Author>();
                    foreach (string authorEmail in authorEmails)
                    {
                        var author = _authors.FirstOrDefault(a => a.Email == authorEmail);
                        if (author != null)
                        {
                            bookAuthors.Add(author);
                        }
                    }

                    Book book = new Book(bookName, bookAuthors.ToArray(), price, quantity);
                    books.Add(book);
                }
            }

            return books;
        }
    }
}