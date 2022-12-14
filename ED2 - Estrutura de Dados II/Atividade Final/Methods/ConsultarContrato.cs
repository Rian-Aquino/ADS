
using System;
using Projeto_Locação.Utils;

namespace Projeto_Locação.Methods
{
	static public class ConsultarContrato
	{		
		public static void call(Locacao locacao, Menu menu) {
			try {
				Messages.Wl("");
				Messages.Wl("Consultar contrato");
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
				
				Messages.SuccessMessage("Encontrado:");
				Messages.Wl("Data de Saída: " + contrato.dtSaida);
				Messages.Wl("Data de Retorno: " + contrato.dtRetorno);
				Messages.Wl("Locados: ");
				
				foreach (var locado in contrato.locados) {
					Messages.Wl(" + " + locado.quantidade + " - " + locado.tipo.tipo);
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
