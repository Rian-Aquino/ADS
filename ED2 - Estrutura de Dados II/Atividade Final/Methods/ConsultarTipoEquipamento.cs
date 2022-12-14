
using System;
using Projeto_Locação.Utils;

namespace Projeto_Locação.Methods
{
	static public class ConsultarTipoEquipamento
	{		
		public static void call(Locacao locacao, Menu menu) {
			try {
				Messages.Wl("");
				Messages.Wl("Consultar Tipo de Equipamento ");
				Messages.Wl("");
			
				Messages.W("Id: ");
				var id = Convert.ToInt32(Console.ReadLine());
				
				var tipoEquipamento = locacao.tiposEquipamentos.consultar(new TipoEquipamento(id));
				
				if(tipoEquipamento == null) {
					Messages.ErrorMessage("Tipo de equipamento não foi encontrado");
					Messages.Continue();
					menu.Render();
					return;
				}
				
				Messages.SuccessMessage("Encontrado:");
				Messages.Wl("Tipo: " + tipoEquipamento.tipo);
				Messages.Wl("Diária: " + tipoEquipamento.diaria);
				Messages.Wl("Estoque: ");
				
				foreach (var equipamento in tipoEquipamento.estoque) {
					Messages.Wl(" + Item " + equipamento.id + " - Situação: " + (equipamento.avariado ? "AVARIADO" : "NORMAL"));
				}
				
				Messages.Continue();
				menu.Render();
				
			} catch (Exception) {
				Messages.ErrorMessage("Não foi possível realizar a consulta");
				Messages.Continue();
				menu.Render();
			}
			
		}
	}
}
