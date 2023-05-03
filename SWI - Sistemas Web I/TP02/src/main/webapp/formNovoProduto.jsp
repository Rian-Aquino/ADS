<%@ taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c" %>
<c:url value="/novoProduto" var="LinkServletNovoProduto" />

<!DOCTYPE html>
<html>
	<head>
		<meta charset="ISO-8859-1">
		<title>Insert title here</title>
	</head>
	
	<body>
		<form action="${LinkServletNovoProduto}" method="post">
			Nome: <input type="text" name="nome" /><br>
			Unidade Compra: <input type="number" name="unidadeCompra" /><br>
			Descri��o: <input type="text" name="descricao" /><br>
			Quantidade Prevista por M�s: <input type="number" step="any" name="qtdPrevistoMes" /><br>
			Pre�o M�ximo Comprado: <input type="number" step="any" name="precoMaxComprado" /><br>
			
			<input type="submit" />
		</form>
		
		<br><a href="listaProdutos">Ver produtos cadastrados</a>
	</body>
</html>