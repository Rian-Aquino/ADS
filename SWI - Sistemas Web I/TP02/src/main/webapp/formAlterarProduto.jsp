<%@ taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c" %>
<c:url value="/alterarProduto" var="LinkServletAlterarProduto" />

<!DOCTYPE html>
<html>
	<head>
		<meta charset="ISO-8859-1">
		<title>Insert title here</title>
	</head>
	
	<body>
		<form action="${LinkServletAlterarProduto}" method="post">
			Nome: <input type="text" name="nome" value="${ produto.nome }" /><br>
			Unidade Compra: <input type="number" name="unidadeCompra" value="${ produto.unidadeCompra }"/><br>
			Descrição: <input type="text" name="descricao" value="${ produto.descricao }"/><br>
			Quantidade Prevista por Mês: <input type="number" step="any" name="qtdPrevistoMes" value="${ produto.qtdPrevistoMes }"/><br>
			Preço Máximo Comprado: <input type="number" step="any" name="precoMaxComprado" value="${ produto.precoMaxComprado }"/><br>
			
			<input hidden type="text" name="id" value="${ produto.id }" />
			<input type="submit" />
		</form>
	</body>
</html>