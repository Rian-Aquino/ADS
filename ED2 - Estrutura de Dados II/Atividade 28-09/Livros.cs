using System;
using System.Collections.Generic;

class Livros {
  private List<Livro> acervo;

  public Livros() {
    this.acervo = new List<Livro>();
  }

  public List<Livro> Acervo {
    get { return acervo; }
    set { acervo = value; }
  }

  public void adicionar(Livro livro) {
    this.acervo.Add(livro);
  }

  public Livro pesquisar(Livro livro) {
    return this.acervo.Find(delegate(Livro l) {
      return l.Isbn == livro.Isbn;
    });
  }
}