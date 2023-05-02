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

@WebServlet("/removerProduto")
public class RemoverProdutoServlet extends HttpServlet  {
	private static final long serialVersionUID = 1L;
	
	protected void doGet(HttpServletRequest request,
		HttpServletResponse response) throws ServletException, IOException {
		String id = request.getParameter("id");

		ProdutoDao.delete(Integer.parseInt(id));
		
		response.sendRedirect("listaProdutos");
	}
	
}