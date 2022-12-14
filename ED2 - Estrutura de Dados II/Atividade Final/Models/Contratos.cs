
using System;
using System.Collections.Generic;

namespace Projeto_Locação
{
	/// <summary>
	/// Description of Contratos.
	/// </summary>
	public class Contratos
	{
		public List<Contrato> lista {
			get;
			set;
		}
		
		public Contratos() {
			this.lista = new List<Contrato>();
		}
		
		public void cadastrar(Contrato contrato) {
			this.lista.Add(contrato);
		}
		
		public Contrato consultar(Contrato contrato) {
			return this.lista.Find(c => c.id == contrato.id);
		}
	}
}
