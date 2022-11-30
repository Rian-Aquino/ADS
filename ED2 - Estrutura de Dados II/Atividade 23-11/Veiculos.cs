
using System;
using System.Collections.Generic;

namespace Projeto_Transporte
{
	/// <summary>
	/// Description of Veiculos.
	/// </summary>
	public class Veiculos
	{
		public List<Veiculo> cadastrados {
			get;
			set;
		}
		
		public Queue<Veiculo> disponiveis {
			get;
			set;
		}
		
		public Veiculos() {
			this.cadastrados = new List<Veiculo>();
			this.disponiveis = new Queue<Veiculo>();
		}
		
		public void cadastrar(Veiculo veiculo) {
			this.cadastrados.Add(veiculo);
		}
		
		public Veiculo pesquisar(Veiculo veiculo) {
			return this.cadastrados.Find(v => v.placa == veiculo.placa);
		}
		
		public bool habilitar(Veiculo veiculo) {
			var encontrado = pesquisar(veiculo);
			
			if(encontrado == null) return false;
			
			disponiveis.Enqueue(encontrado);
			return true;
		}
	}
}
