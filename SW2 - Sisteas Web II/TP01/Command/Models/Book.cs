using Command.Repository.Implementation;

namespace Command.Repository
{
    public class Book : IBook
    {
        private String _name;
        private Author[] _authors;
        private double _price;
        private int _qty;

        public Book(string name, Author[] authors, double price, int qty)
        {
            _name = name;
            _authors = authors;
            _price = price;
            _qty = qty;
        }

        public string Name { get => _name; set => _name = value; }
        public Author[] Authors { get => _authors; set => _authors = value; }
        public double Price { get => _price; set => _price = value; }
        public int Qty { get => _qty; set => _qty = value; }

        public override String ToString()
        {
            var authorsStr = String.Join(", ", _authors.ToList().ConvertAll(author => author.ToString()).ToArray());
            return $"Book[name={_name}, authors={{{authorsStr}}}, price={_price}, qty={_qty}]";
        }

        public String GetAuthorNames()
        {
            return String.Join(", ", _authors.ToList().ConvertAll(author => author.Name).ToArray());
        }
    }
}
