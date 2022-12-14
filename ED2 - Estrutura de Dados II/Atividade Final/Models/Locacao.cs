
using System;

namespace Projeto_Locação
{
	/// <summary>
	/// Description of Locacao.
	/// </summary>
	public class Locacao
	{
		public TiposEquipamentos tiposEquipamentos {
			get;
			set;
		}
		
		public Contratos contratos {
			get;
			set;
		}
		
		public Locacao()
		{
			this.tiposEquipamentos = new TiposEquipamentos();
			this.contratos = new Contratos();
		}
	}
}
