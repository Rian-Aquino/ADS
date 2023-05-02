import java.io.IOException;
import java.io.PrintWriter;

import javax.servlet.RequestDispatcher;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

/*
 * Autor:
 * Rian Gustavo Quintanilha de Aquino
 */

@WebServlet("/alterarProduto")
public class AlterarProdutoServlet extends HttpServlet  {
	private static final long serialVersionUID = 1L;
	
	protected void doGet(HttpServletRequest request,
		HttpServletResponse response) throws ServletException, IOException {
		String id = request.getParameter("id");
		Produto produto = ProdutoDao.getById(Integer.parseInt(id));

		request.setAttribute("produto", produto);
		
		RequestDispatcher rd = request.getRequestDispatcher("/formAlterarProduto.jsp");
		rd.forward(request, response);
	}
	
	protected void doPost(HttpServletRequest req, HttpServletResponse res) throws ServletException, IOException {
		PrintWriter out = res.getWriter();  
		
		Produto produto = new Produto();
		produto.setId(Integer.parseInt(req.getParameter("id")));
		produto.setNome(req.getParameter("nome"));
		produto.setDescricao(req.getParameter("descricao"));
		produto.setPrecoMaxComprado(Double.parseDouble(req.getParameter("precoMaxComprado")));
		produto.setUnidadeCompra(Integer.parseInt(req.getParameter("unidadeCompra")));
		produto.setQtdPrevistoMes(Double.parseDouble(req.getParameter("qtdPrevistoMes")));
		
		int status = ProdutoDao.update(produto);
        if(status>0){
            req.setAttribute("produto", produto.getNome());
            req.getRequestDispatcher("/listaProdutos").include(req, res);  
        }else{  
            out.println("Não foi possível fazer a alteração!");  
        }
        
        out.close();
	}
	
}