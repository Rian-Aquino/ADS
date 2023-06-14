package ads.inventario.DAOs;

import java.sql.*;
import java.sql.SQLException;
import java.util.*;
import java.util.Date;

import ads.inventario.Models.Order;
 
/**
 * Autores:
 * Diogo Santos Teixeira
 * Rian Gustavo Quintanilha de Aquino 
*/

public class OrderDAO extends DAO {
	
    public OrderDAO(String jdbcURL, String jdbcUsername, String jdbcPassword) {
    	super(jdbcURL, jdbcUsername, jdbcPassword);
    }
    
    public boolean save(Order order) throws SQLException {
    	String sql = "INSERT INTO Orders (purch_amt, ord_date, customer_id, salesman_id) VALUES (?, ?, ?, ?)";
        connect();
         
        PreparedStatement statement = jdbcConnection.prepareStatement(sql);
        statement.setFloat(1, order.getPurch_amt());
        statement.setDate(2, new java.sql.Date(order.getOrd_date().getTime()));
        statement.setInt(3, order.getCustomer_id());
        statement.setInt(4, order.getSalesman_id());
         
        boolean rowInserted = statement.executeUpdate() > 0;
        statement.close();
        disconnect();
        return rowInserted;
    }
    
    public List<Order> list() throws SQLException {
    	List<Order> listOrders = new ArrayList<>();
        
        String sql = "SELECT * FROM Orders";
         
        connect();
         
        Statement statement = jdbcConnection.createStatement();
        ResultSet resultSet = statement.executeQuery(sql);
         
        while (resultSet.next()) {
            int ord_no = resultSet.getInt("ord_no");
            float purch_amt = resultSet.getFloat("purch_amt");
            Date ord_date = resultSet.getDate("ord_date");
            int customer_id = resultSet.getInt("customer_id");
            int salesman_id = resultSet.getInt("salesman_id");
             
            Order order = new Order(ord_no, purch_amt, ord_date, customer_id, salesman_id);
            listOrders.add(order);
        }
         
        resultSet.close();
        statement.close();
         
        disconnect();
         
        return listOrders;
    }
}