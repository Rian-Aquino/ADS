
using System;
using Projeto_Locação.Utils;

namespace Projeto_Locação.Methods
{
	static public class ConsultarContratosLiberados
	{		
		public static void call(Locacao locacao, Menu menu) {
			try {
				Messages.Wl("");
				Messages.Wl("Consultar contratos liberados");
				Messages.Wl("");
				
				var count = 0;
				foreach (var contrato in locacao.contratos.lista) {
					if (contrato.liberados.Count > 0) {
						Messages.Wl("Contrato " + contrato.id);
						Messages.Wl("  Data de Saída: " + contrato.dtSaida);
						Messages.Wl("  Data de Retorno: " + contrato.dtRetorno);
						Messages.Wl("  Locados: ");
						
						foreach (var locado in contrato.locados) {
							Messages.Wl("   + " + locado.quantidade + " - " + locado.tipo.tipo);
						}
						
						count++;
					}
				}
				
				if(count == 0) {
					Messages.Wl("Não há nenhum contrato liberado no momento");
					Messages.Continue();
					menu.Render();
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
