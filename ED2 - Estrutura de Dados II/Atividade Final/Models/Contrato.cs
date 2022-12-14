
using System;
using System.Collections.Generic;

namespace Projeto_Locação
{
	/// <summary>
	/// Description of Contrato.
	/// </summary>
	public class Contrato
	{
		public int id {
			get;
			set;
		}
		
		public DateTime dtSaida {
			get;
			set;
		}
		
		public DateTime dtRetorno {
			get;
			set;
		}
		
		public List<Locado> locados {
			get;
			set;
		}
		
		public Stack<Equipamento> liberados {
			get;
			set;
		}
		
		public Contrato(int id, DateTime dtSaida = default(DateTime), DateTime dtRetorno = default(DateTime)) {
			this.id = id;
			this.dtSaida = dtSaida;
			this.dtRetorno = dtRetorno;
			this.locados = new List<Locado>();
			this.liberados = new Stack<Equipamento>();
		}
	}
}
