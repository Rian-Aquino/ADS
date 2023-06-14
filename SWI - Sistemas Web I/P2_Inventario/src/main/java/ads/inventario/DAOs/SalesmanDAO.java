package ads.inventario.DAOs;

import java.sql.*;
import java.sql.SQLException;
import java.util.*;

import ads.inventario.Models.Salesman;
 
/**
 * Autores:
 * Diogo Santos Teixeira
 * Rian Gustavo Quintanilha de Aquino 
*/

public class SalesmanDAO extends DAO {
	
    public SalesmanDAO(String jdbcURL, String jdbcUsername, String jdbcPassword) {
    	super(jdbcURL, jdbcUsername, jdbcPassword);
    }
    
    public boolean save(Salesman salesman) throws SQLException {
        String sql = "INSERT INTO Salesman (name, city, commission) VALUES (?, ?, ?)";
        connect();
         
        PreparedStatement statement = this.jdbcConnection.prepareStatement(sql);
        statement.setString(1, salesman.getName());
        statement.setString(2, salesman.getCity());
        statement.setFloat(3, salesman.getCommission());
         
        boolean rowInserted = statement.executeUpdate() > 0;
        statement.close();
        disconnect();
        return rowInserted;
    }
    
    public List<Salesman> list() throws SQLException {
        List<Salesman> listSalesman = new ArrayList<>();
         
        String sql = "SELECT * FROM Salesman";
         
        connect();
         
        Statement statement = this.jdbcConnection.createStatement();
        ResultSet resultSet = statement.executeQuery(sql);
         
        while (resultSet.next()) {
            int salesman_id = resultSet.getInt("salesman_id");
            String name = resultSet.getString("name");
            String city = resultSet.getString("city");
            float commission = resultSet.getFloat("commission");
             
            Salesman salesman = new Salesman(salesman_id, name, city, commission);
            listSalesman.add(salesman);
        }
         
        resultSet.close();
        statement.close();
         
        disconnect();
         
        return listSalesman;
    }
}