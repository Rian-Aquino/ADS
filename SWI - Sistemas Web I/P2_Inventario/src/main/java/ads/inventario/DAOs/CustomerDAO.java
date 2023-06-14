package ads.inventario.DAOs;

import java.sql.*;
import java.sql.SQLException;
import java.util.*;

import ads.inventario.Models.Customer;
 
/**
 * Autores:
 * Diogo Santos Teixeira
 * Rian Gustavo Quintanilha de Aquino 
*/

public class CustomerDAO extends DAO {
	
    public CustomerDAO(String jdbcURL, String jdbcUsername, String jdbcPassword) {
    	super(jdbcURL, jdbcUsername, jdbcPassword);
    }
    
    public boolean save(Customer customer) throws SQLException {
    	String sql = "INSERT INTO Customer (cust_name, city, grade, salesman_id) VALUES (?, ?, ?, ?)";
        connect();
         
        PreparedStatement statement = jdbcConnection.prepareStatement(sql);
        statement.setString(1, customer.getCust_name());
        statement.setString(2, customer.getCity());
        statement.setFloat(3, customer.getGrade());
        statement.setInt(4, customer.getSalesman_id());
         
        boolean rowInserted = statement.executeUpdate() > 0;
        statement.close();
        disconnect();
        return rowInserted;
    }
    
    public List<Customer> list() throws SQLException {
    	List<Customer> listCustomer = new ArrayList<>();
        
        String sql = "SELECT * FROM Customer";
         
        connect();
         
        Statement statement = jdbcConnection.createStatement();
        ResultSet resultSet = statement.executeQuery(sql);
         
        while (resultSet.next()) {
            int customer_id = resultSet.getInt("customer_id");
            String cust_name = resultSet.getString("cust_name");
            String city = resultSet.getString("city");
            int grade = resultSet.getInt("grade");
            int salesman_id = resultSet.getInt("salesman_id");
            
             
            Customer customer = new Customer(customer_id, cust_name, city, grade, salesman_id);
            listCustomer.add(customer);
        }
         
        resultSet.close();
        statement.close();
         
        disconnect();
         
        return listCustomer;
    }
}