
using System;
using System.Collections.Generic;

namespace Projeto_Locação
{
	/// <summary>
	/// Description of TiposEquipamentos.
	/// </summary>
	public class TiposEquipamentos
	{
		public List<TipoEquipamento> lista {
			get;
			set;
		}
		
		public TiposEquipamentos() {
			this.lista = new List<TipoEquipamento>();
		}
		
		public void cadastrar(TipoEquipamento tiposEquipamento) {
			lista.Add(tiposEquipamento);
		}
		
		public TipoEquipamento consultar(TipoEquipamento tiposEquipamento) {
			return lista.Find(e => e.id == tiposEquipamento.id);
		}
	}
}
