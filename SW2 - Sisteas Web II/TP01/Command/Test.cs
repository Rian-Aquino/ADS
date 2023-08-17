using Command.Repositories;

/*
 Dupla:
 Gabriel Ferreira de Souza
 Rian Gustavo Quintanilha de Aquino
*/

namespace Command
{
    public class Test
    {


        public static void Main()
        {
            var _repo = new BookRepository();
            var book1 = _repo.Books.ElementAt(0);

            Console.WriteLine("Book 1 =");
            Console.WriteLine(book1);

            Console.WriteLine();
            book1.Name = "Livro - TP01 Sistemas Web II";
            Console.WriteLine("Novo nome do livro: " + book1.Name);

            Console.WriteLine();
            Console.WriteLine("Autores do livro:");
            foreach (var _author in book1.Authors)
            {
                Console.WriteLine(_author);
            };

            Console.WriteLine();
            Console.WriteLine("Preço do livro: " + book1.Price);
            book1.Price = 54.00;
            Console.WriteLine("Novo preço do livro: " + book1.Price);

            Console.WriteLine();
            Console.WriteLine("Unidades: " + book1.Qty);
            book1.Qty = 100;
            Console.WriteLine("Unidades atualizadas: " + book1.Qty);

            Console.WriteLine();
            Console.WriteLine("ToString():");
            Console.WriteLine(book1.ToString());

            Console.WriteLine();
            Console.WriteLine("Nome dos Autores:");
            Console.WriteLine(book1.GetAuthorNames());


        }
    }
}
