
using System;

namespace Projeto_Locação
{
	/// <summary>
	/// Description of Equipamento.
	/// </summary>
	public class Equipamento
	{
		public int id {
			get;
			set;
		}
		
		public bool avariado {
			get;
			set;
		}
		
		public Equipamento(int id, bool avariado = false) {
			this.id = id;
			this.avariado = avariado;
		}
	}
}
