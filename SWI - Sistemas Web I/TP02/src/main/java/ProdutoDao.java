import java.util.*;
import java.sql.*;

/*
 * Autor:
 * Rian Gustavo Quintanilha de Aquino
 */

public class ProdutoDao {

    public static Connection getConnection(){
        Connection con=null;
        try {
            String dbDriver = "com.mysql.cj.jdbc.Driver";
            String dbURL = "jdbc:mysql://localhost:3306/";
            String dbName = "tp02?useTimezone=true&serverTimezone=America/Sao_Paulo";
            String dbUsername = "root";
            String dbPassword = "fcamaradb123";
            Class.forName(dbDriver);

            con = DriverManager.getConnection(dbURL + dbName, dbUsername, dbPassword); 
        } catch(Exception e){ System.out.println(e); }
        return con;
    }

    public static int save(Produto produto) {
        int status = 0;
        try {
            Connection con = ProdutoDao.getConnection();
            PreparedStatement ps = con.prepareStatement(
                    "insert into produto (nome, unidade_compra, descricao, qtd_previsto_mes, preco_max_comprado) values (?, ?, ?, ?, ?)");
            ps.setString(1, produto.getNome());
            ps.setInt(2, produto.getUnidadeCompra());
            ps.setString(3, produto.getDescricao());
            ps.setDouble(4, produto.getQtdPrevistoMes());
            ps.setDouble(5, produto.getPrecoMaxComprado());

            status = ps.executeUpdate();
            con.close();
        } catch (Exception ex) {
            ex.printStackTrace();
        }

        return status;
    }

    public static int update(Produto produto) {
        int status = 0;
        try {
            Connection con = ProdutoDao.getConnection();
            PreparedStatement ps = con.prepareStatement(
                    "update produto set nome=?, unidade_compra=?, descricao=?, qtd_previsto_mes=?, preco_max_comprado=? where id=?");
            ps.setString(1, produto.getNome());
            ps.setInt(2, produto.getUnidadeCompra());
            ps.setString(3, produto.getDescricao());
            ps.setDouble(4, produto.getQtdPrevistoMes());
            ps.setDouble(5, produto.getPrecoMaxComprado());
            ps.setInt(6, produto.getId());

            status = ps.executeUpdate();

            con.close();
        } catch (Exception ex) {
            ex.printStackTrace();
        }

        return status;
    }

    public static int delete(int id) {
        int status = 0;
        try {
            Connection con = ProdutoDao.getConnection();
            PreparedStatement ps = con.prepareStatement("delete from produto where id=?");
            ps.setInt(1, id);
            status = ps.executeUpdate();

            con.close();
        } catch (Exception e) {
            e.printStackTrace();
        }

        return status;
    }

    public static Produto getById(int id) {
        Produto produto = new Produto();
        try {
            Connection con = ProdutoDao.getConnection();
            PreparedStatement ps = con.prepareStatement("select * from produto where id=?");
            ps.setInt(1, id);
            ResultSet rs = ps.executeQuery();
            if (rs.next()) {
                produto.setId(rs.getInt(1));
                produto.setNome(rs.getString(2));
                produto.setUnidadeCompra(rs.getInt(3));
                produto.setDescricao(rs.getString(4));
                produto.setQtdPrevistoMes(rs.getDouble(5));
                produto.setPrecoMaxComprado(rs.getDouble(6));
            }
            con.close();
        } catch (Exception ex) {
            ex.printStackTrace();
        }

        return produto;
    }

    public static List<Produto> getAll() throws SQLException {
        List<Produto> produtos = new ArrayList<>();
        Connection con = ProdutoDao.getConnection();
        PreparedStatement stmt = con.prepareStatement("SELECT * FROM produto");
        ResultSet rs = stmt.executeQuery();

        while (rs.next()) {
            Produto produto = new Produto();
            produto.setId(rs.getInt("id"));
            produto.setNome(rs.getString("nome"));
            produto.setUnidadeCompra(rs.getInt("unidade_compra"));
            produto.setDescricao(rs.getString("descricao"));
            produto.setQtdPrevistoMes(rs.getDouble("qtd_previsto_mes"));
            produto.setPrecoMaxComprado(rs.getDouble("preco_max_comprado"));
            produtos.add(produto);
        }

        rs.close();
        stmt.close();
        return produtos;
    }
}