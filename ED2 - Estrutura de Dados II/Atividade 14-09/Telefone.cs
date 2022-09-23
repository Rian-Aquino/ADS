using System;

class Telefone {
  private String tipo;
  private String numero;
  private bool principal;

  public Telefone(String t, String n, bool p) {
    this.tipo = t;
    this.numero = n;
    this.principal = p;
  }
  
  public String Tipo {
    get { return tipo; }
  }

  public String Numero {
    get { return numero; }
  }

  public bool Principal {
    get { return principal; }
    set { principal = value; }
  }
}