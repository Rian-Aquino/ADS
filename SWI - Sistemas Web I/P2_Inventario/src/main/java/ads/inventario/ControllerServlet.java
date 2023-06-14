package ads.inventario;
import java.io.IOException;
import java.sql.SQLException;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Date;
import java.util.List;
import javax.servlet.RequestDispatcher;
import javax.servlet.ServletConfig;
import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import ads.inventario.DAOs.*;
import ads.inventario.Models.*;

/**
 * Autores:
 * Diogo Santos Teixeira
 * Rian Gustavo Quintanilha de Aquino 
*/

public class ControllerServlet extends HttpServlet {
	private static final long serialVersionUID = 1L;
	private SalesmanDAO salesmanDAO;
	private CustomerDAO customerDAO;
	private OrderDAO orderDAO;
	
	public ControllerServlet() {
        super();
    }

	@Override
	public void init() {
		String jdbcURL = getServletContext().getInitParameter("jdbcURL");
		String jdbcUsername = getServletContext().getInitParameter("jdbcUsername");
        String jdbcPassword = getServletContext().getInitParameter("jdbcPassword");
 
        salesmanDAO = new SalesmanDAO(jdbcURL, jdbcUsername, jdbcPassword);
        customerDAO = new CustomerDAO(jdbcURL, jdbcUsername, jdbcPassword);
        orderDAO = new OrderDAO(jdbcURL, jdbcUsername, jdbcPassword);
	}

	protected void doPost(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
		String action = request.getServletPath();
		 
        try {
            switch (action) {
            case "/newSalesman":
            	saveSalesman(request, response);
                break;
            case "/newCustomer":
            	saveCustomer(request, response);
                break;
            case "/newOrder":
            	saveOrder(request, response);
                break;
            default:
            	doGet(request, response);
                break;
            }
        } catch (Exception ex) {
            throw new ServletException(ex);
        }
    }
 
    protected void doGet(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        String action = request.getServletPath();
 
        try {
            switch (action) {
            case "/newSalesman":
            	newSalesmanForm(request, response);
                break;
            case "/newCustomer":
            	newCustomerForm(request, response);
                break;
            case "/newOrder":
            	newOrderForm(request, response);
                break;
            case "/credits":
            	credits(request, response);
                break;
            default:
            	index(request, response);
                break;
            }
        } catch (Exception ex) {
            throw new ServletException(ex);
        }
    }
    
    private void credits(HttpServletRequest request, HttpServletResponse response)
            throws SQLException, ServletException, IOException {
        RequestDispatcher dispatcher = request.getRequestDispatcher("Credits.jsp");
        dispatcher.forward(request, response);
    }
    
    private void index(HttpServletRequest request, HttpServletResponse response)
            throws SQLException, IOException, ServletException {
        List<Salesman> listSalesman = salesmanDAO.list();
        List<Customer> listCustomer = customerDAO.list();
        List<Order> listOrders = orderDAO.list();

        request.setAttribute("listSalesman", listSalesman);
        request.setAttribute("listCustomer", listCustomer);
        request.setAttribute("listOrders", listOrders);
        RequestDispatcher dispatcher = request.getRequestDispatcher("Home.jsp");
        dispatcher.forward(request, response);
    }
    
    private void newSalesmanForm(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        RequestDispatcher dispatcher = request.getRequestDispatcher("NewSalesman.jsp");
        dispatcher.forward(request, response);
    }
    
    private void saveSalesman(HttpServletRequest request, HttpServletResponse response)
            throws SQLException, IOException {
        String name = request.getParameter("name");
        String city = request.getParameter("city");
        float commission = Float.parseFloat(request.getParameter("commission"));
 
        Salesman newSalesman = new Salesman(name, city, commission);
        salesmanDAO.save(newSalesman);
        response.sendRedirect("./");
    }
    
    private void newCustomerForm(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException, SQLException {
    	List<Salesman> listSalesman = salesmanDAO.list();
    	request.setAttribute("listSalesman", listSalesman);
    	
        RequestDispatcher dispatcher = request.getRequestDispatcher("NewCustomer.jsp");
        dispatcher.forward(request, response);
    }
 

    private void saveCustomer(HttpServletRequest request, HttpServletResponse response)
            throws SQLException, IOException {
        String cust_name = request.getParameter("cust_name");
        String city = request.getParameter("city");
        float grade = Float.parseFloat(request.getParameter("grade"));
        Integer salesman_id = Integer.parseInt(request.getParameter("salesman_id"));
 
        Customer newCustomer = new Customer(cust_name, city, grade, salesman_id);
        customerDAO.save(newCustomer);
        response.sendRedirect("./");
    }
    
    private void newOrderForm(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException, SQLException {
    	List<Salesman> listSalesman = salesmanDAO.list();
    	request.setAttribute("listSalesman", listSalesman);
    	
    	List<Customer> listCustomer = customerDAO.list();
    	request.setAttribute("listCustomer", listCustomer);
    	
        RequestDispatcher dispatcher = request.getRequestDispatcher("NewOrder.jsp");
        dispatcher.forward(request, response);
    }
 

    private void saveOrder(HttpServletRequest request, HttpServletResponse response)
            throws SQLException, IOException {
    	float purch_amt =  Float.parseFloat(request.getParameter("purch_amt"));
    	String dateString = request.getParameter("ord_date");
    	Date ord_date = new Date();
    	try {
    		if(dateString != null) {
    			ord_date= new SimpleDateFormat("yyyy-MM-dd").parse(dateString);    		
    		}
    	} catch(ParseException e) {
    		
    	}
        int customer_id = Integer.parseInt(request.getParameter("customer_id"));
        int salesman_id = Integer.parseInt(request.getParameter("salesman_id"));
        
        System.out.println("dataUsuario " + ord_date);
        
        Order newOrder = new Order(purch_amt, ord_date, customer_id, salesman_id);
        orderDAO.save(newOrder);
        response.sendRedirect("./");
    }
}