
using System;

namespace Projeto_Transporte
{
	/// <summary>
	/// Description of Visitante.
	/// </summary>
	public class Visitante
	{
		public int inscricao {
			get;
			set;
		}
		
		public string nome {
			get;
			set;
		}
		
		public Visitante(int inscricao, string nome = "")
		{
			this.inscricao = inscricao;
			this.nome = nome;
		}
		
		public override string ToString()
		{
			return string.Format("{0} - {1}", inscricao, nome);
		}

	}
}
