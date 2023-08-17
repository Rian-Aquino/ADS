using System.Numerics;

namespace Command.Repository.Implementation
{
    public interface IBook
    {
        String Name { get; }
        Author[] Authors { get; }
        double Price { get; set; }
        int Qty { get; set; }

        public String ToString();
        public String GetAuthorNames();

    }
}
