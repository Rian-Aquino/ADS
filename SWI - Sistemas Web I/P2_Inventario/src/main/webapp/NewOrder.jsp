<%@ page language="java" contentType="text/html; charset=UTF-8" pageEncoding="UTF-8"%>
<%@ taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c" %>
<html lang="pt-br">
<head>
    <meta charset="UTF-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />

    <link rel="preconnect" href="https://fonts.googleapis.com" />
    <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin />

    <link
        href="https://fonts.googleapis.com/css2?family=Montserrat:ital,wght@0,100;0,200;0,300;0,400;0,500;0,600;0,700;0,800;0,900;1,100;1,200;1,300;1,400;1,500;1,600;1,700;1,800;1,900&display=swap"
        rel="stylesheet"
    />

    <link rel="stylesheet" type="text/css" href="./styles.css" />
    <title>Prova 02 - Inventário</title>
    <style>
    	a {
    		padding: 6px 12px;
    		background: #d3d3d3;
    		border-radius: 8px;
    		font-size: 16px;
    		text-transform: uppercase;
    		text-decoration: none;
    		color: #44a;
    	}
    	
    	form {
		    display: flex;
		    flex-direction: column;
		    gap: 8px;
		    max-width: 300px;
		}
    	
    </style>
</head>
<body>
    <center>
        <h1>
        	Prova 2 - Inventário
        	<a href="./">Home</a>
            <a href="credits">Creditos</a>
        </h1>
        <hr>
        <h2 class="links">
            <a href="newSalesman">Cadastrar Vendedor</a>
            <a href="newCustomer">Cadastrar Cliente</a>
            <a href="newOrder">Cadastrar Pedido</a>
        </h2> 
        <hr><br><br>
        <h1>Cadastro de Pedido</h1>

        <form method="post" action="newOrder">
            <label for="purch_amt">Valor de Compra:</label>
		    <input type="number" step="0.01" id="purch_amt" name="purch_amt" required />
		
		    <label for="ord_date">Data:</label>
		    <input type="date" id="ord_date" name="ord_date" required />
		
		    <label for="customer_id">ID do Cliente:</label>
		    <select id="customer_id" name="customer_id" required>
		        <c:forEach var="customer" items="${listCustomer}">
		            <option value="${customer.customer_id}">${customer.customer_id} - ${customer.cust_name}</option>
		        </c:forEach>
		    </select>
		
		    <label for="salesman_id">ID do Vendedor:</label>
		    <select id="salesman_id" name="salesman_id" required>
		        <c:forEach var="salesman" items="${listSalesman}">
		            <option value="${salesman.salesman_id}">${salesman.salesman_id} - ${salesman.name}</option>
		        </c:forEach>
		    </select>
		
		    <button type="submit">Cadastrar</button>
        </form>
    </center>
    </body>
</html>
