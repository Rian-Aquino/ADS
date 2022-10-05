using System;

class Program {
  static int painel() {
    Console.WriteLine("");
    Console.WriteLine("+----- Selecione a operação -----+");
    Console.WriteLine("+--------------------------------+");
    Console.WriteLine("| 0. Sair                        |");
    Console.WriteLine("| 1. Adicionar Livro             |");
    Console.WriteLine("| 2. Pesquisar Livro (Sintético) |");
    Console.WriteLine("| 3. Pesquisar Livro (Analítico) |");
    Console.WriteLine("| 4. Adicionar Exemplar          |");
    Console.WriteLine("| 5. Registrar Empréstimo        |");
    Console.WriteLine("| 6. Registrar Devolução         |");
    Console.WriteLine("+--------------------------------+");

    Console.Write("+ > ");
    
    return Convert.ToInt32(Console.ReadLine());
  }

  public static void adicionarLivro(Livros livros) {
    Console.WriteLine("");
    Console.WriteLine("+ Adicionar Livro:");

    try {
      Console.Write("- Isnb: ");
      int isnb = Convert.ToInt32(Console.ReadLine());
      
      Console.Write("- Título: ");
      String titulo = Console.ReadLine();
      
      Console.Write("- Autor: ");
      String autor = Console.ReadLine();
      
      Console.Write("- Editora: ");
      String editora = Console.ReadLine();
  
      livros.adicionar(new Livro(isnb, titulo, autor, editora));
      
      Console.WriteLine("");
      Console.WriteLine("v Livro adicionado com sucesso!");
    } catch {
      Console.WriteLine("");
      Console.WriteLine("x Não foi possível adicionar o livro...");
    }
  }
  
  public static void pesquisarLivroS(Livros livros) {
    Console.WriteLine("");
    Console.WriteLine("+ Pesquisar Livro:");

    try {
      Console.Write("- Isnb: ");
      int isnb = Convert.ToInt32(Console.ReadLine());
  
      Livro livro = livros.pesquisar(new Livro(isnb));
      if(livro == null) throw new Exception();
      
      Console.WriteLine("");
      Console.WriteLine("v Livro encontrado com sucesso!");
      
      Console.WriteLine("");
      Console.WriteLine("+ Titulo.........: " + livro.Titulo);
      Console.WriteLine("+ Autor..........: " + livro.Autor);
      Console.WriteLine("+ Editora........: " + livro.Editora);
      Console.WriteLine("+ Tot. Exemplares: " + livro.qtdeExemplares());
      Console.WriteLine("+ Ex. Disponíveis: " + livro.qtdeDisponiveis());
      Console.WriteLine("+ Qt. Empréstimos: " + livro.qtdeEmprestimos());
      Console.WriteLine("+ Perc. Disponib.: " + livro.percDisponibilidade() + "%");
      
    } catch {
      Console.WriteLine("");
      Console.WriteLine("x Não foi possível encontrar o livro...");
    }
  }
  
  public static void pesquisarLivroA(Livros livros) {
    Console.WriteLine("");
    Console.WriteLine("+ Pesquisar Livro:");

    try {
      Console.Write("- Isnb: ");
      int isnb = Convert.ToInt32(Console.ReadLine());
  
      Livro livro = livros.pesquisar(new Livro(isnb));
      if(livro == null) throw new Exception();
      
      Console.WriteLine("");
      Console.WriteLine("v Livro encontrado com sucesso!");
      
      Console.WriteLine("");
      Console.WriteLine("+ Titulo.: " + livro.Titulo);
      Console.WriteLine("+ Autor..: " + livro.Autor);
      Console.WriteLine("+ Editora: " + livro.Editora);
      
      Console.WriteLine("|");
      Console.WriteLine("+ Exemplares (Total: " + livro.qtdeExemplares() + ")");
      Console.WriteLine("+ - Disponíveis....: " + livro.qtdeDisponiveis());
      Console.WriteLine("+ - Perc. Disponib.: " + livro.percDisponibilidade() + "%");
      livro.Exemplares.ForEach(delegate(Exemplar e) {
        Console.WriteLine("| | - Tombo: " + e.Tombo + " - Disponível: " + (e.disponivel() ? "sim" : "não"));
      });
      
      Console.WriteLine("|");
      Console.WriteLine("+ Empréstimos (Total: " + livro.qtdeEmprestimos() + ")");

      livro.Exemplares.ForEach(delegate(Exemplar e) {
        Console.WriteLine("| - Exemplar " + e.Tombo + " (" + e.qtdeEmprestimo() + ")");
        e.Emprestimos.ForEach(delegate(Emprestimo e) {
          Console.WriteLine("| | - Emprestado: " + e.DtEmprestimo + " - Devolvido: " + (e.DtDevolucao == new DateTime() ? "não" : e.DtDevolucao));
        });
      });
      
      Console.WriteLine("+-+");
    } catch {
      Console.WriteLine("");
      Console.WriteLine("x Não foi possível encontrar o livro...");
    }
  }
  
  public static void adicionarExemplar(Livros livros) {
    Console.WriteLine("");
    Console.WriteLine("+ Pesquisar Livro para adiocionar:");

    try {
      Console.Write("- Isnb: ");
      int isnb = Convert.ToInt32(Console.ReadLine());
  
      Livro livro = livros.pesquisar(new Livro(isnb));
      if(livro == null) throw new Exception();
      
      Console.WriteLine("");
      Console.WriteLine("v Livro encontrado com sucesso!");
      
      Console.WriteLine("");
      Console.Write("- Tombo: ");
      int tombo = Convert.ToInt32(Console.ReadLine());

      livro.adicionarExemplar(new Exemplar(tombo));
      
      Console.WriteLine("");
      Console.WriteLine("v Exemplar adicionado com sucesso!");
    } catch {
      Console.WriteLine("");
      Console.WriteLine("x Não foi possível adicionar o exemplar...");
    }
  }
  
  public static void registrarEmprestimo(Livros livros) {
    Console.WriteLine("");
    Console.WriteLine("+ Pesquisar Livro para emprestar:");

    try {
      Console.Write("- Isnb: ");
      int isnb = Convert.ToInt32(Console.ReadLine());
  
      Livro livro = livros.pesquisar(new Livro(isnb));
      if(livro == null) throw new Exception();
      
      Console.Write("- Tombo do exemplar: ");
      int tombo = Convert.ToInt32(Console.ReadLine());

      Exemplar exemplar = livro.Exemplares.Find(delegate(Exemplar e) {
        return e.Tombo == tombo;
      });
      if(exemplar == null) throw new Exception();

      bool sucesso = exemplar.emprestar();

      if(sucesso) {
        Console.WriteLine("");
        Console.WriteLine("v Exemplar emprestado com sucesso!");
      } else {
        Console.WriteLine("");
        Console.WriteLine("x O exemplar está indisponível...");
      }
    } catch {
      Console.WriteLine("");
      Console.WriteLine("x Não foi possível emprestar o exemplar...");
    }
  }
  
  public static void registrarDevolucao(Livros livros) {
    Console.WriteLine("");
    Console.WriteLine("+ Pesquisar Livro para devolver:");

    try {
      Console.Write("- Isnb: ");
      int isnb = Convert.ToInt32(Console.ReadLine());
  
      Livro livro = livros.pesquisar(new Livro(isnb));
      if(livro == null) throw new Exception();
      
      Console.Write("- Tombo do exemplar: ");
      int tombo = Convert.ToInt32(Console.ReadLine());

      Exemplar exemplar = livro.Exemplares.Find(delegate(Exemplar e) {
        return e.Tombo == tombo;
      });
      if(exemplar == null) throw new Exception();

      bool sucesso = exemplar.devolver();

      if(sucesso) {
        Console.WriteLine("");
        Console.WriteLine("v Exemplar devolvido com sucesso!");
      } else {
        Console.WriteLine("");
        Console.WriteLine("x O exemplar não está emprestado...");
      }
    } catch {
      Console.WriteLine("");
      Console.WriteLine("x Não foi possível devolver o exemplar...");
    }
  }
  
  public static void Main (string[] args) {

    Console.WriteLine("");
    Console.WriteLine("+-- Atividade ED2 - Biblioteca --+");

    Livros livros = new Livros();

    livros.adicionar(new Livro(1, "ABC", "Rian", "ED2"));
    livros.adicionar(new Livro(2, "MAT", "Jorge", "ED2"));

    livros.Acervo[0].adicionarExemplar(new Exemplar(1));

    int seletor;
    do {
      seletor = painel();

      switch(seletor) {
        case 0: break;
        case 1: adicionarLivro(livros); break;
        case 2: pesquisarLivroS(livros); break;
        case 3: pesquisarLivroA(livros); break;
        case 4: adicionarExemplar(livros); break;
        case 5: registrarEmprestimo(livros); break;
        case 6: registrarDevolucao(livros); break;
      }
      
    } while(seletor != 0);
    
    Console.WriteLine("");
    Console.WriteLine("-> Finalizando aplicação...");
  }
}