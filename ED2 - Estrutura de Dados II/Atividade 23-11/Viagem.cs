
using System;
using System.Collections.Generic;

namespace Projeto_Transporte
{
	/// <summary>
	/// Description of Viagem.
	/// </summary>
	public class Viagem
	{
		public Veiculo veiculo {
			get;
			set;
		}
		
		public DateTime dtViagem {
			get;
			set;
		}
		
		public List<Visitante> passageiros {
			get;
			set;
		}
		
		public Viagem(Veiculo veiculo, DateTime dtViagem, List<Visitante> passageiros) {
			this.veiculo = veiculo;
			this.dtViagem = dtViagem;
			this.passageiros = passageiros;
		}
		
		public override string ToString()
		{
			return string.Format(
				"[Viagem] Veiculo: {0}, Data: {1}, Passageiros: {2}",
				veiculo, dtViagem, passageiros.Count);
		}

	}
}
