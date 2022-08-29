package lp2.tp01;

/**
 *
 * @author Rian
 */

public class LivroDeBiblioteca extends Livro implements ItemDeBiblioteca {
	private boolean emprestado = false;
  	private String localizacao;
  
  	LivroDeBiblioteca(String titulo, String autor, String editora, short anoedicao, String localizacao) {
      super(titulo, autor, editora, anoedicao);
      this.localizacao = localizacao;
    }
  
  	public boolean getEmprestado() {
      return this.emprestado;
    }
  
  	public String getLocalizacao() {
      return this.localizacao;
    }
  
  	public void Empresta() {
      this.emprestado = true;
    }
  
  	public void Devolve() {
      this.emprestado = false;
    }

  	public String getDados() {
      return 
          "Titulo..... = " + this.titulo +
        "\nAutor...... = " + this.autor +
        "\nEditora.... = " + this.editora +
        "\nAno........ = " + this.anoedicao +
        "\nLocalização = " + this.localizacao;
    }
}
