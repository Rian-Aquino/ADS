using Command.Repositories;

/*
 Dupla:
 Gabriel Ferreira de Souza
 Rian Gustavo Quintanilha de Aquino
*/

namespace Command
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRouting();
        }

        public void Configure(IApplicationBuilder app)
        {
            var builder = new RouteBuilder(app);
            builder.MapRoute("/", Home);
            builder.MapRoute("livros/{bookIndex}/", Book);
            builder.MapRoute("livros/{bookIndex}/nome", BookName);
            builder.MapRoute("livros/{bookIndex}/autores", BookAuthors);
            builder.MapRoute("livros/{bookIndex}/apresentar-livro", BookShow);
            var rotas = builder.Build();

            app.UseRouter(rotas);
        }

        public Task Roteamento(HttpContext context)
        {
            var caminhosAtendidos = new Dictionary<string, RequestDelegate>
            {
                { "livros/{bookIndex}/", Book },
                { "livros/{bookIndex}/nome", BookName },
                { "livros/{bookIndex}/autores", BookAuthors },
                { "livros/{bookIndex}/apresentar-livro", BookShow }
            };

            if (caminhosAtendidos.ContainsKey(context.Request.Path))
            {
                return caminhosAtendidos[context.Request.Path].Invoke(context);
            }

            context.Response.StatusCode = 404;
            return context.Response.WriteAsync("Caminho inexistente.");
        }

        public Task BookName(HttpContext context)
        {
            var _repo = new BookRepository();
            var bookIndexObj = context.GetRouteValue("bookIndex");

            if (bookIndexObj == null)
            {
                context.Response.StatusCode = 400;
                return context.Response.WriteAsync("Livro não informado.");
            }

            var bookIndex = int.Parse(bookIndexObj.ToString()) - 1;

            if (bookIndex >= _repo.Books.Count || bookIndex < 0)
            {
                context.Response.StatusCode = 404;
                return context.Response.WriteAsync("Livro inexistente.");
            }

            var book = _repo.Books.ElementAt(bookIndex);

            context.Response.StatusCode = 200;
            return context.Response.WriteAsync("<div style='background-color: #f85f; padding: 30px; border-radius: 30px; margin: 5% 20%'><pre>" + book.Name + "</pre></div>");
        }

        public Task BookAuthors(HttpContext context)
        {
            var _repo = new BookRepository();
            var bookIndexObj = context.GetRouteValue("bookIndex");

            if (bookIndexObj == null)
            {
                context.Response.StatusCode = 400;
                return context.Response.WriteAsync("Livro não informado.");
            }

            var bookIndex = int.Parse(bookIndexObj.ToString()) - 1;

            if (bookIndex >= _repo.Books.Count || bookIndex < 0)
            {
                context.Response.StatusCode = 404;
                return context.Response.WriteAsync("Livro inexistente.");
            }

            var book = _repo.Books.ElementAt(bookIndex);

            context.Response.StatusCode = 200;
            return context.Response.WriteAsync("<div style='background-color: #f85f; padding: 30px; border-radius: 30px; margin: 5% 20%'><pre>" + book.GetAuthorNames() + "</pre></div>");
        }

        public Task Book(HttpContext context)
        {
            var _repo = new BookRepository();
            var bookIndexObj = context.GetRouteValue("bookIndex");

            if (bookIndexObj == null)
            {
                context.Response.StatusCode = 400;
                return context.Response.WriteAsync("Livro não informado.");
            }

            var bookIndex = int.Parse(bookIndexObj.ToString()) - 1;

            if (bookIndex >= _repo.Books.Count || bookIndex < 0)
            {
                context.Response.StatusCode = 404;
                return context.Response.WriteAsync("Livro inexistente.");
            }

            var book = _repo.Books.ElementAt(bookIndex);

            context.Response.StatusCode = 200;
            return context.Response.WriteAsync("<div style='background-color: #f85f; padding: 30px; border-radius: 30px; margin: 5% 20%'>" + book.ToString() + "</div>");
        }

        public Task BookShow(HttpContext context)
        {
            var _repo = new BookRepository();
            var bookIndexObj = context.GetRouteValue("bookIndex");

            if (bookIndexObj == null)
            {
                context.Response.StatusCode = 400;
                return context.Response.WriteAsync("Livro não informado.");
            }

            var bookIndex = int.Parse(bookIndexObj.ToString()) - 1;

            if (bookIndex >= _repo.Books.Count || bookIndex < 0)
            {
                context.Response.StatusCode = 404;
                return context.Response.WriteAsync("Livro inexistente.");
            }

            var book = _repo.Books.ElementAt(bookIndex);

            var authorLIs = "";
            foreach (var author in book.Authors)
            {
                authorLIs += "<li>" + author.Name + "</li>";
            }

            context.Response.StatusCode = 200;
            return context.Response.WriteAsync(
                "<div style='background-color: #f85f; padding: 30px; border-radius: 30px; margin: 5% 20%; color: #fff'>" +
                    "<h3 style='color: #fff'>" +
                        book.Name +
                    "</h3>" +

                    "<ul>" +
                        authorLIs +
                    "<ul>" +
                "</div>"
            );
        }

        public Task Home(HttpContext context)
        {
            return context.Response.WriteAsync(
                "TP01 - Sistemas Web II\n" +
                "Rotas disponiveis:\n\n" +
                "livros/{numero do livro}/\n" +
                "livros/{numero do livro}/nome\n" +
                "livros/{numero do livro}/autores\n" +
                "livros/{numero do livro}/apresentar-livro\n"
            );
        }

        /*
        public Task NovoLivroParaLer(HttpContext context)
        {
            var livro = new Negocio.Livro()
            {
                Titulo = context.GetRouteValue("nome").ToString(),
                Autor = context.GetRouteValue("autor").ToString(),
            };

            var repo = new LivroRepositorioCSV();
            repo.Incluir(livro);
            return context.Response.WriteAsync("O livro foi adicionado com sucesso");
        }

        public Task LivrosLendo(HttpContext context)
        {
            var _repo = new LivroRepositorioCSV();
            context.Response.StatusCode = 200;
            return context.Response.WriteAsync("<div style='background-color: #f46; padding: 30px; border-radius: 30px; margin: 5% 20%'><pre>" + _repo.Lendo.ToString() + "</pre></div>");
        }

        public Task LivrosLidos(HttpContext context)
        {
            try
            {
                var _repo = new LivroRepositorioCSV();
                context.Response.StatusCode = 200;
                return context.Response.WriteAsync("<div style='background-color: #32a852; padding: 30px; border-radius: 30px; margin: 5% 20%'><pre>" + _repo.Lidos.ToString() + "</pre></div>");
            }
            catch (Exception e)
            {
                context.Response.StatusCode = 500;
                return context.Response.WriteAsync("<div style='background-color: #f005; padding: 30px; border-radius: 30px; margin: 5% 20%'><pre>" + e + "</pre></div>");
            }
        }*/

    }
}