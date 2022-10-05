using System;

class Emprestimo {
  private DateTime dtEmprestimo;
  private DateTime dtDevolucao;

  public Emprestimo(DateTime dtE) {
    this.dtEmprestimo = dtE;
  }

  public DateTime DtEmprestimo {
    get { return dtEmprestimo; }
    set { dtEmprestimo = value; }
  }
  
  public DateTime DtDevolucao {
    get { return dtDevolucao; }
    set { dtDevolucao = value; }
  }
}