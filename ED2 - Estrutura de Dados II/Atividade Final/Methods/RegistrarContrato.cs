
using System;
using Projeto_Locação.Utils;

namespace Projeto_Locação.Methods
{
	static public class CadastrarContrato
	{		
		public static void call(Locacao locacao, Menu menu) {
			try {
				Messages.Wl("");
				Messages.Wl("Cadastrar contrato de locação");
				Messages.Wl("");
			
				Messages.W("Id: ");
				var id = Convert.ToInt32(Console.ReadLine());
				
				Messages.W("Data de Retirada: ");
				var dtSaida = Convert.ToDateTime(Console.ReadLine());
				
				Messages.W("Data de Retorno: ");
				var dtRetorno = Convert.ToDateTime(Console.ReadLine());
				
				var contrato = new Contrato(id, dtSaida, dtRetorno);
				
				Messages.Wl("Equipamentos: (Pressione ESC ao final para terminar)");
				
				var count = 0;
				while (Console.ReadKey().Key != ConsoleKey.Escape) {
					Messages.Wl(" - N" + ++count);
					Messages.W("    Id do Tipo de Equipamento: ");
					var idTipoEquipamento = Convert.ToInt32(Console.ReadLine());
					
					var tipoEquipamento = locacao.tiposEquipamentos.consultar(new TipoEquipamento(idTipoEquipamento));
					
					if(tipoEquipamento == null) {
						Messages.ErrorMessage("Tipo de equipamento não foi encontrado");
						Messages.Continue();
						menu.Render();
					}
					
					Messages.W("    Quantidade: ");
					var qtd = Convert.ToInt32(Console.ReadLine());
					
					contrato.locados.Add(new Locado(tipoEquipamento, qtd));
				}
				
				locacao.contratos.cadastrar(contrato);
				
				Messages.SuccessMessage("Contrato cadastrado com sucesso!");
				Messages.Continue();
				menu.Render();
				
			} catch (Exception) {
				Messages.ErrorMessage("Não foi possível cadastrar o contrato");
				Messages.Continue();
				menu.Render();
			}
			
		}
	}
}
