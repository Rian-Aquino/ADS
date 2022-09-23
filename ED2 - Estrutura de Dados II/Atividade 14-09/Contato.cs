using System;
using System.Collections.Generic;

class Contato {
  private String email;
  private String nome;
  private Data dtNascimento;
  private List<Telefone> telefones;

  public Contato(String e, String n, Data d) {
    this.email = e;
    this.nome = n;
    this.dtNascimento = d;
    this.telefones = new List<Telefone>();
  }

  public Contato(String e) {
    this.email = e;
    this.nome = "";
    this.dtNascimento = new Data();
    this.telefones = new List<Telefone>();
  }

  public String Email {
    get { return email; }
    set { email = value;  }
  }

  public String Nome {
    get { return nome; }
    set { nome = value;  }
  }
  
  public Data DtNascimento {
    get { return dtNascimento; }
    set { dtNascimento = value;  }
  }

  public List<Telefone> Telefones {
    get { return telefones; }
  }
  
  public int getIdade() {
    DateTime d1 = DateTime.Now;
    DateTime d2 = new DateTime(this.dtNascimento.Ano, this.dtNascimento.Mes, this.dtNascimento.Dia);

    return d1.Subtract(d2).Days / 365;
  }

  public void adicionarTelefone(Telefone t) {
    if(t.Principal) {
      this.telefones.ForEach(delegate(Telefone _t) {
        _t.Principal = false;
      });
    }
    
    this.telefones.Add(t);
  }

  public String getTelefonePrincipal() {
    Telefone t = this.telefones.Find(delegate(Telefone _t) {
      return _t.Principal;
    });

    if (t != null) {
      return t.Numero;
    } else {
      return "";
    }
  }
  
  public String getTelefonesSecundarios() {
    String str = "";

    this.telefones.ForEach(delegate(Telefone _t) {
      if(!_t.Principal) {
        str = str + _t.Numero + ", ";
      }
    });

    return str;
  }

  override public String ToString() {
    return 
      "\n +" +
      "\n | Nome..: " + this.nome +
      "\n | E-mail: " + this.email +
      "\n | Idade.: " + this.getIdade() +
      "\n | \n | Tel. Principal: \n |  - " + this.getTelefonePrincipal() +
      "\n | \n | Tel. Secundário(s): \n |  - " + this.getTelefonesSecundarios() +
      "\n +";
  }

  override public bool Equals(object obj) {
    return this.email.Equals(((Contato)obj).Email);
  }

  override public int GetHashCode() {
    return 123;
  }
}