using System;
using System.Collections.Generic;

class Exemplar {
  private int tombo;
  private List<Emprestimo> emprestimos;

  public Exemplar(int t) {
    this.tombo = t;
    this.emprestimos = new List<Emprestimo>();
  }

  public int Tombo {
    get { return tombo; }
    set { tombo = value; }
  }
  
  public List<Emprestimo> Emprestimos {
    get { return emprestimos; }
    set { emprestimos = value; }
  }

  public bool emprestar() {
    bool disponivel = this.disponivel();
    
    if(disponivel) {
      this.emprestimos.Add(new Emprestimo(DateTime.Now));
    }

    return disponivel;
  }

  public bool devolver() {
    bool disponivel = this.disponivel();
    
    if(!disponivel) {
      Emprestimo ultimoEmprestimo = this.emprestimos[this.qtdeEmprestimo() - 1];
      ultimoEmprestimo.DtDevolucao = DateTime.Now;
    }

    return !disponivel;
  }
  
  public bool disponivel() {
    bool disponivel = true;
    
    if(this.qtdeEmprestimo() > 0) {
      Emprestimo ultimoEmprestimo = this.emprestimos[this.qtdeEmprestimo() - 1];
      if(ultimoEmprestimo.DtDevolucao == new DateTime()) {
        return disponivel = false;
      }
    }
    
    return disponivel;
  }
  
  public int qtdeEmprestimo() {
    return this.emprestimos.Count;
  }
}