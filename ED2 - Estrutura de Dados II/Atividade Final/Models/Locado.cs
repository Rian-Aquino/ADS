
using System;

namespace Projeto_Locação
{
	/// <summary>
	/// Description of Locado.
	/// </summary>
	public class Locado
	{
		public TipoEquipamento tipo {
			get;
			set;
		}
		
		public int quantidade {
			get;
			set;
		}
		
		public Locado(TipoEquipamento tipo, int quantidade) {
			this.tipo = tipo;
			this.quantidade = quantidade;
		}
	}
}
