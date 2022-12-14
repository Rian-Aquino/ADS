
using System;
using Projeto_Locação.Utils;

namespace Projeto_Locação.Methods
{
	static public class CadastrarTipoEquipamento
	{		
		public static void call(Locacao locacao, Menu menu) {
			try {
				Messages.Wl("");
				Messages.Wl("Cadastrar Tipo de Equipamento ");
				Messages.Wl("");
			
				Messages.W("Id: ");
				var id = Convert.ToInt32(Console.ReadLine());
				
				Messages.W("Tipo: ");
				var tipo = Console.ReadLine();
				
				Messages.W("Diária: ");
				var diaria = Convert.ToDouble(Console.ReadLine());
				
				locacao.tiposEquipamentos.cadastrar(new TipoEquipamento(id, tipo, diaria));
				
				Messages.SuccessMessage("Tipo de equipamento cadastrado com sucesso!");
				Messages.Continue();
				menu.Render();
				
			} catch (Exception) {
				Messages.ErrorMessage("Não foi possível cadastrar tipo de equipamento");
				Messages.Continue();
				menu.Render();
			}
			
		}
	}
}
