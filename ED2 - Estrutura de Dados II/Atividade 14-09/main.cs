using System;

class Program {
    static int painel() {
      
      Console.WriteLine("");
      Console.WriteLine("+--- Selecione a operação ---+");
      Console.WriteLine("+----------------------------+");
      Console.WriteLine("| 0. Sair                    |");
      Console.WriteLine("| 1. Adicionar contato       |");
      Console.WriteLine("| 2. Pesquisar contato       |");
      Console.WriteLine("| 3. Alterar contato         |");
      Console.WriteLine("| 4. Remover contato         |");
      Console.WriteLine("| 5. Listar contatos         |");
      Console.WriteLine("+----------------------------+");

      Console.Write("+ > ");
      
      return Convert.ToInt32(Console.ReadLine());
    }

    static void adicionarContato(Contatos agenda) {
      Console.WriteLine("");
      Console.WriteLine("+ Adicionar contato:");

      Console.Write("- Nome: ");
      String nome = Console.ReadLine();
      
      Console.Write("- E-mail: ");
      String email = Console.ReadLine();
      
      Console.Write("- Data de Nascimento (dd/mm/aaaa): ");
      String dtNascimento = Console.ReadLine();

      bool sucesso = agenda.adicionar(new Contato(email, nome, new Data(dtNascimento)));

      if(sucesso) {
        Console.WriteLine("");
        Console.WriteLine("v Contato adicionado com sucesso!");
      } else {
        Console.WriteLine("");
        Console.WriteLine("x Não foi possível adicionar o contato...");
      }
    }
  
    static void pesquisarContato(Contatos agenda) {
      Console.WriteLine("");
      Console.WriteLine("+ Pesquisar contato:");
      
      Console.Write("- E-mail: ");
      String email = Console.ReadLine();

      Contato contato = agenda.pesquisar(new Contato(email));

      if(contato != null) {
          Console.WriteLine("");
          Console.WriteLine("v Contato encontrado!");
          Console.WriteLine(contato.ToString());
      } else {
          Console.WriteLine("");
          Console.WriteLine("x Não foi possível encontrar o contato...");
      }
    }

    static void alterarContato(Contatos agenda) {
      Console.WriteLine("");
      Console.WriteLine("+ Alterar contato:");
      
      Console.Write("- E-mail: ");
      String email = Console.ReadLine();

      Contato contato = agenda.pesquisar(new Contato(email));

      if(contato != null) {
        Console.WriteLine("");
        Console.WriteLine("+ Selecione a opção:");
        

        int seletor;
        do {
          Console.WriteLine("");
          Console.WriteLine("  0. Voltar");
          Console.WriteLine("  1. Alterar Nome..: " + contato.Nome);
          Console.WriteLine("  2. Alterar E-mail: " + contato.Email);
          Console.WriteLine("  3. Alterar Idade.: " + contato.getIdade());
          Console.WriteLine("  4. Adicionar Telefone");

          Console.Write("  > ");
          seletor = Convert.ToInt32(Console.ReadLine());
  
          switch(seletor) {
            case 0: break;
            case 1: 
              Console.WriteLine("");
              Console.Write("- Novo nome: ");
              String novoNome = Console.ReadLine();

              contato.Nome = novoNome;
            break;
            case 2: 
              Console.WriteLine("");
              Console.Write("- Novo e-mail: ");
              String novoEmail = Console.ReadLine();

              contato.Email = novoEmail;
            break;
            case 3: 
              Console.WriteLine("");
              Console.Write("- Nova data de nascimento: ");
              String novaDtNascimento = Console.ReadLine();

              contato.DtNascimento = new Data(novaDtNascimento);
            break;
            case 4: 
              Console.WriteLine("");
              Console.WriteLine("  Novo Telefone: ");
              
              Console.Write("  - Número: ");
              String numero = Console.ReadLine();
              
              Console.Write("  - Tipo: ");
              String tipo = Console.ReadLine();
              
              Console.Write("  - Principal (s/n): ");
              String principal = Console.ReadLine();

              contato.adicionarTelefone(new Telefone(tipo, numero, principal == "s" ? true : false));
            break;
          }
          
        } while(seletor != 0);
        
      } else {
        Console.WriteLine("");
        Console.WriteLine("x Não foi possível encontrar o contato...");
      }
    }

    static void removerContato(Contatos agenda) {
      Console.WriteLine("");
      Console.WriteLine("+ Remover contato:");
      
      Console.Write("- E-mail: ");
      String email = Console.ReadLine();

      Contato contato = agenda.pesquisar(new Contato(email));

      if(contato != null) {
          Console.WriteLine("");

          bool sucesso = agenda.remover(contato);
          if(sucesso) {
            Console.WriteLine("v Contato removido com sucesso!");
          } else {
            Console.WriteLine("x Não foi possível remover o contato...");
          }
      } else {
          Console.WriteLine("");
          Console.WriteLine("x Não foi possível encontrar o contato...");
      }
    }
  
    static void listarContatos(Contatos agenda) {
      Console.WriteLine("");
      Console.WriteLine("+ Listar contatos:");

      agenda.Agenda.ForEach(delegate(Contato c) {
        Console.WriteLine(c.ToString());
      });
    }
  
    static void Main(string[] args) {
      Console.WriteLine("");
      Console.WriteLine("+---- Agenda de Contatos ----+");

      Contatos agenda = new Contatos();
      agenda.adicionar(new Contato("r", "r", new Data("1/1/1")));

      int seletor;
      do {
        seletor = painel();

        switch(seletor) {
          case 0: break;
          case 1: adicionarContato(agenda); break;
          case 2: pesquisarContato(agenda); break;
          case 3: alterarContato(agenda); break;
          case 4: removerContato(agenda); break;
          case 5: listarContatos(agenda); break;
        }
        
      } while(seletor != 0);
      
      Console.WriteLine("");
      Console.WriteLine("-> Finalizando aplicação...");
    }
}