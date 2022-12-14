
using System;
using Projeto_Locação.Utils;

namespace Projeto_Locação.Methods
{
	static public class CadastrarEquipamento
	{		
		public static void call(Locacao locacao, Menu menu) {
			try {
				Messages.Wl("");
				Messages.Wl("Cadastrar Equipamento em qual tipo?");
				Messages.Wl("");
			
				Messages.W("Id: ");
				var idTipoEquipamento = Convert.ToInt32(Console.ReadLine());
				
				var tipoEquipamento = locacao.tiposEquipamentos.consultar(new TipoEquipamento(idTipoEquipamento));
				
				if(tipoEquipamento == null) {
					Messages.ErrorMessage("Tipo de equipamento não foi encontrado");
					Messages.Continue();
					menu.Render();
					return;
				}
				
				Messages.Wl("");
				Messages.Wl("Quantos equipamentos serão cadastrados?");
				Messages.Wl("");
				
				Messages.W("Qtd: ");
				var qtd = Convert.ToInt32(Console.ReadLine());
				
				tipoEquipamento.cadastrarEquipamento(qtd);
				
				Messages.SuccessMessage(qtd + " equipamento(s) cadastrado(s)!");
				Messages.Continue();
				menu.Render();
				
			} catch (Exception) {
				Messages.ErrorMessage("Não foi possível cadastrar equipamento");
				Messages.Continue();
				menu.Render();
			}
			
		}
	}
}
