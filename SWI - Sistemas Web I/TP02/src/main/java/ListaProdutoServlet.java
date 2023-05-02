import java.io.IOException;
import java.io.PrintWriter;
import java.sql.SQLException;
import java.util.List;

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

@WebServlet("/listaProdutos")
public class ListaProdutoServlet extends HttpServlet  {
	private static final long serialVersionUID = 1L;
	
	protected void service(HttpServletRequest req, HttpServletResponse res) throws ServletException, IOException {
		try {
			List<Produto> lista = ProdutoDao.getAll();
			req.setAttribute("produtos", lista);
			
			RequestDispatcher rd = req.getRequestDispatcher("/listaProdutos.jsp");
			rd.forward(req, res);
		} catch (SQLException e) {
			e.printStackTrace();
		}
	}
}