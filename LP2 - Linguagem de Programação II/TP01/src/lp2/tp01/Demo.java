package lp2.tp01;

/**
 *
 * @author Rian
 */
public class Demo {
  public static void pegarEmprestado(LivroDeBiblioteca l) {
    if(!l.getEmprestado()) {
      l.Empresta();
      System.out.println("O livro " + l.titulo + " foi emprestado com sucesso! Deverá ser devolvido em 7 dias.");
    } else {
      System.out.println("Negado! O livro " + l.titulo + " já está emprestado! Tente novamente em alguns dias.");
    }
  }
  
  public static void main(String[] args) {
    LivroDeBiblioteca L1 = new LivroDeBiblioteca("Introdução à POO usando JAVA", "Prof. Rafael Santos", "Campus/SBC", (short) 2003, "g11p17");
    
    System.out.println("=== TP.LP2 ===\n");
    System.out.println(L1.getDados());
    
    System.out.println("");
    System.out.println("Tentativa Nº1:");
    pegarEmprestado(L1);
    
    System.out.println("");
    System.out.println("Tentativa Nº2:");
    pegarEmprestado(L1);
  }
  
}
