
using System;
using System.Collections.Generic;

namespace Projeto_Transporte
{
	/// <summary>
	/// Description of Evento.
	/// </summary>
	public class Evento
	{
		public List<Visitante> visitantes {
			get;
			set;
		}
		
		public Evento() {
			this.visitantes = new List<Visitante>();
		}
		
		public void cadastrar(Visitante visitante) {
			visitantes.Add(visitante);
		}
		
		public Visitante pesquisar(Visitante visitante) {
			return this.visitantes.Find(v => v.inscricao == visitante.inscricao);
		}
	}
}
