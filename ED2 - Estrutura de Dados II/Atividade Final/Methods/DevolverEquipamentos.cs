
using System;
using Projeto_Locação.Utils;

namespace Projeto_Locação.Methods
{
	static public class DevolverEquipamentos
	{		
		public static void call(Locacao locacao, Menu menu) {
			try {
				Messages.Wl("");
				Messages.Wl("Devolver equipamentos");
				Messages.Wl("");
			
				Messages.W("Id do Contrato: ");
				var id = Convert.ToInt32(Console.ReadLine());
				
				var contrato = locacao.contratos.consultar(new Contrato(id));
				
				if(contrato == null) {
					Messages.ErrorMessage("Contrato não foi encontrado");
					Messages.Continue();
					menu.Render();
					return;
				}
				
				if(contrato.liberados.Count < 1) {
					Messages.ErrorMessage("Contrato não foi liberado ainda");
					Messages.Continue();
					menu.Render();
					return;
				}
				var totalDias = contrato.dtRetorno.Subtract(contrato.dtSaida).Days;
				
				var valor = 0.0;
				foreach (var locado in contrato.locados) {
					valor += locado.tipo.diaria * locado.quantidade * totalDias;
					
					for (int i = 0; i < locado.quantidade; i++) {
						var equipamento = contrato.liberados.Pop();
						locado.tipo.estoque.Enqueue(equipamento);
					}
				}
				
				
				
				Messages.SuccessMessage("Devolvidos:");
				
				foreach (var locado in contrato.locados) {
					Messages.Wl(" + " + locado.quantidade + " - " + locado.tipo.tipo + " - Diária: R$" + locado.tipo.diaria);
				}
				
				Messages.Wl("");
				Messages.Wl("Dias locados: " + totalDias);
				Messages.Wl("Valor total: R$" + valor);
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
