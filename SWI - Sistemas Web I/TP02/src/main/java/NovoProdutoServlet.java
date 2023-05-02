import java.io.IOException;
import java.io.PrintWriter;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

/*
 * Autor:
 * Rian Gustavo Quintanilha de Aquino
 */

@WebServlet("/novoProduto")
public class NovoProdutoServlet extends HttpServlet  {
	private static final long serialVersionUID = 1L;
	
	protected void doPost(HttpServletRequest req, HttpServletResponse res) throws ServletException, IOException {
		PrintWriter out = res.getWriter();  
		
		Produto produto = new Produto();
		produto.setNome(req.getParameter("nome"));
		produto.setDescricao(req.getParameter("descricao"));
		produto.setPrecoMaxComprado(Double.parseDouble(req.getParameter("precoMaxComprado")));
		produto.setUnidadeCompra(Integer.parseInt(req.getParameter("unidadeCompra")));
		produto.setQtdPrevistoMes(Double.parseDouble(req.getParameter("qtdPrevistoMes")));
		
		int status = ProdutoDao.save(produto);
        if(status>0){  
            out.print("<p>Record saved successfully!</p>");  
            req.setAttribute("produto", produto.getNome());
            req.getRequestDispatcher("/listaProdutos").include(req, res);  
        }else{  
            out.println("Sorry! unable to save record");  
        }
        
        out.close();
	}
	
}