<%@ page language="java" contentType="text/html; charset=UTF-8" pageEncoding="UTF-8"%>
<%@ taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c" %>

<!DOCTYPE html>
<html>
	<head>
		<meta charset="UTF-8"/>
		<title> Java Standard Taglib</title>
	</head>
	
	<body>
		<c:if test="${not empty produto}">
			Produto ${ produto } salvo com sucesso!
		</c:if>
		<h1>Lista de Produtos</h1>
		
		<table border>
			<tr>
				<th>Nome</th>
				<th>Unidade Compra</th>
				<th>Descrição</th>
				<th>Quantidade Prevista por Mês</th>
				<th>Preço Máximo Comprado</th>
				<th>alterar</th>
				<th>remover</th>
			</tr>
			<c:forEach items="${ produtos }" var="produto">
				<tr>
					<td>${ produto.nome }</td>
					<td>${ produto.unidadeCompra }</td>
					<td>${ produto.descricao }</td>
					<td>${ produto.qtdPrevistoMes }</td>
					<td>${ produto.precoMaxComprado }</td>
					<td><a href="alterarProduto?id=${ produto.id }">alterar</a></td>
					<td><a href="removerProduto?id=${ produto.id }">remover</a></td>
				</tr>
			</c:forEach>
		</table>
		
		<br><a href="formNovoProduto.jsp">Cadastrar um novo produto</a>
		<br><a href="credits.html">Créditos</a>
	</body>
</html>