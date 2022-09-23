using System;
using System.Collections.Generic;

class Contatos {
  readonly List<Contato> agenda;

  public Contatos() {
    this.agenda = new List<Contato>();
  }
  
  public List<Contato> Agenda {
    get { return agenda; }
  }

  public bool adicionar(Contato c) {
    this.agenda.Add(c);

    return true;
  }

  public Contato pesquisar(Contato c) {
    return this.agenda.Find(delegate(Contato _c) {
      return _c.Equals(c);
    });
  }
  
  public bool alterar(Contato c) {
    Contato _c = this.pesquisar(c);

    Console.WriteLine("Contato selecionado: " + _c.Email);
    Console.WriteLine("Escolha a opção:\n");
    Console.WriteLine(" 1. Alterar nome");
    Console.WriteLine(" 2. Alterar e-mail");
    Console.WriteLine(" 3. Alterar data de nascimento");
    Console.WriteLine(" 4. Adicionar telefone");    
    
    return true;
  }
  
  public bool remover(Contato c) {
    this.agenda.Remove(c);
    
    return true;
  }
}