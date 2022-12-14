
using System;
using Projeto_Locação.Utils;

namespace Projeto_Locação.Methods
{
	static public class LiberarContrato
	{		
		public static void call(Locacao locacao, Menu menu) {
			try {
				Messages.Wl("");
				Messages.Wl("Liberar contrato");
				Messages.Wl("");
			
				Messages.W("Id: ");
				var id = Convert.ToInt32(Console.ReadLine());
				
				var contrato = locacao.contratos.consultar(new Contrato(id));
				
				if(contrato == null) {
					Messages.ErrorMessage("Contrato não foi encontrado");
					Messages.Continue();
					menu.Render();
					return;
				}
				
				foreach (var locado in contrato.locados) {
					var tipo = locacao.tiposEquipamentos.consultar(locado.tipo);
					if(tipo.estoque.Count < locado.quantidade) {
						Messages.ErrorMessage("Operação cancelada. Não há " + locado.tipo + " suficiente no estoque");
						Messages.Continue();
						menu.Render();
						return;
					}
				}
				
				foreach (var locado in contrato.locados) {
					var tipo = locacao.tiposEquipamentos.consultar(locado.tipo);
					
					for (int i = 0; i < locado.quantidade; i++) {
						contrato.liberados.Push(tipo.estoque.Dequeue());
					}
				}
				
				Messages.SuccessMessage("Equipamentos entregues");
				
				Messages.Wl("Data de Retorno: " + contrato.dtRetorno);
				Messages.Wl("Locados: ");
				
				foreach (var locado in contrato.locados) {
					Messages.Wl(" + " + locado.quantidade + " - " + locado.tipo.tipo);
				}
				
				Messages.Continue();
				menu.Render();
				
			} catch (Exception) {
				Messages.ErrorMessage("Não foi possível realizar a operação");
				Messages.Continue();
				menu.Render();
			}
			
		}
	}
}
