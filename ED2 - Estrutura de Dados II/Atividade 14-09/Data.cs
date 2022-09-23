using System;

class Data{
  private int dia;
  private int mes;
  private int ano;

  public Data() {
    this.setData(1, 1, 1);
  }
  
  public Data(String s) {
    String[] dt = s.Split("/");
    
    this.setData(Convert.ToInt32(dt[0]), Convert.ToInt32(dt[1]), Convert.ToInt32(dt[2]));
  }

  public int Dia {
    get { return dia; }
  }

  public int Mes {
    get { return mes; }
  }

  public int Ano {
    get { return ano; }
  }

  public void setData(int dia, int mes, int ano) {
    this.dia = dia;
    this.mes = mes;
    this.ano = ano;
  }

  override public String ToString() {
    return dia + "/" + mes + "/" + ano;
  }
}