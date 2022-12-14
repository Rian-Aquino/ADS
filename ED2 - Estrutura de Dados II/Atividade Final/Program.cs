
using System;
using System.Linq;
using System.Collections.Generic;
	
using Projeto_Locação.Utils;
using Projeto_Locação.Methods;

namespace Projeto_Locação
{
	class Program
	{
		public static void Main(string[] args)
		{
			var locacao = new Locacao();
			
			var e1 = new TipoEquipamento(1, "Computador", 10);
			var e2 = new TipoEquipamento(2, "Impressora", 15);
			var e3 = new TipoEquipamento(3, "Scanner", 20);
			
			for (int i = 0; i < 20; i++) {
				e1.estoque.Enqueue(new Equipamento(i + 1));
				e2.estoque.Enqueue(new Equipamento(i + 21));
				e3.estoque.Enqueue(new Equipamento(i + 41));
			}
			
			locacao.tiposEquipamentos.cadastrar(e1);
			locacao.tiposEquipamentos.cadastrar(e2);
			locacao.tiposEquipamentos.cadastrar(e3);
			
			var c1 = new Contrato(1, new DateTime(1, 1, 1), new DateTime(1, 2, 1));
			var c2 = new Contrato(2);
			var c3 = new Contrato(3);
			
			c1.locados.Add(new Locado(e1, 10));
			c1.locados.Add(new Locado(e2, 10));
			c1.locados.Add(new Locado(e3, 10));
			
			locacao.contratos.cadastrar(c1);
			
			//
			
			var menu = new Menu();
			
        	menu.options = new List<Option>{
				new Option("Cadastrar tipo de equipamento", () => CadastrarTipoEquipamento.call(locacao, menu)),
				new Option("Consultar tipo de equipamento", () => ConsultarTipoEquipamento.call(locacao, menu)),
				new Option("Cadastrar equipamento", () => CadastrarEquipamento.call(locacao, menu)),
				new Option("Registrar Contrato de Locação", () => CadastrarContrato.call(locacao, menu)),
				new Option("Consultar Contratos de Locação", () => ConsultarContrato.call(locacao, menu)),
				new Option("Liberar Contrato de Locação", () => LiberarContrato.call(locacao, menu)),
				new Option("Consultar Contratos de Locação liberados", () => ConsultarContratosLiberados.call(locacao, menu)),
				new Option("Devolver equipamentos de Contrato de Locação liberado", () => DevolverEquipamentos.call(locacao, menu)),
	            new Option("Sair", () => Environment.Exit(0)),
        	};
			
			menu.Render();
		}
	}
}