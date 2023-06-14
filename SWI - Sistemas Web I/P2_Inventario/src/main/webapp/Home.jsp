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
    </center>
    <div style="display: flex; gap: 60px; width: 100%; justify-content: center">
	    <div>
	        <table border="1" cellpadding="5">
	            <caption><h2>Vendedores</h2></caption>
	            <tr>
	                <th>ID</th>
	                <th>Nome</th>
	                <th>Cidade</th>
	                <th>Comissão</th>
	            </tr>
	            <c:if test="${listSalesman != null }">
	                <c:forEach var="salesman" items="${listSalesman}">
	                    <tr>
	                        <td>${salesman.salesman_id}</td>
	                        <td>${salesman.name}</td>
	                        <td>${salesman.city}</td>
	                        <td>${salesman.commission}</td>
	                    </tr>
	                </c:forEach>
	            </c:if>
	        </table>
	    </div>
        
        <div>
	        <table border="1" cellpadding="5">
	            <caption><h2>Clientes</h2></caption>
	            <tr>
	                <th>ID</th>
	                <th>Nome</th>
	                <th>Cidade</th>
	                <th>Grade</th>
	                <th>Vendedor</th>
	            </tr>
	            <c:if test="${listCustomer != null }">
	                <c:forEach var="customer" items="${listCustomer}">
	                    <tr>
	                        <td>${customer.customer_id}</td>
	                        <td>${customer.cust_name}</td>
	                        <td>${customer.city}</td>
	                        <td>${customer.grade}</td>
	                        <td>${customer.salesman_id}</td>
	                    </tr>
	                </c:forEach>
	            </c:if>
	        </table>
        </div>
        
        <div>
	        <table border="1" cellpadding="5">
	            <caption><h2>Pedidos</h2></caption>
	            <tr>
	                <th>Número</th>
	                <th>Valor</th>
	                <th>Data</th>
	                <th>Cliente</th>
	                <th>Vendedor</th>
	            </tr>
	            
	            <c:if test="${listOrders != null }">
	                <c:forEach var="order" items="${listOrders}">
	                    <tr>
	                        <td>${order.ord_no}</td>
	                        <td>${order.purch_amt}</td>
	                        <td>${order.ord_date}</td>
	                        <td>${order.customer_id}</td>
	                        <td>${order.salesman_id}</td>
	                    </tr>
	                </c:forEach>
	            </c:if>
	        </table>
        </div>
    </div>   
</body>
</html>
