
using System;

namespace Projeto_Transporte
{
	/// <summary>
	/// Description of Veiculo.
	/// </summary>
	public class Veiculo
	{
		public string placa {
			get;
			set;
		}
		
		public string motorista {
			get;
			set;
		}
		
		public int lotacao {
			get;
			set;
		}
		
		public Veiculo(string placa, string motorista = "", int lotacao = 0) {
			this.placa = placa;
			this.motorista = motorista;
			this.lotacao = lotacao;
		}
		
		public override string ToString()
		{
			return string.Format("{0} - {1} - Lotação: {2}", placa, motorista, lotacao);
		}

	}
}
