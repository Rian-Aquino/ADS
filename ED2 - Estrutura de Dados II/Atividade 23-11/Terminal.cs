
using System;
using System.Collections.Generic;
using System.Linq;

namespace Projeto_Transporte
{
	/// <summary>
	/// Description of Terminal.
	/// </summary>
	public class Terminal
	{
		public Veiculos veiculos {
			get;
			set;
		}
		
		public Queue<Visitante> embarque {
			get;
			set;
		}
		
		public Stack<Viagem> viagens {
			get;
			set;
		}
		
		public Terminal() {
			this.veiculos = new Veiculos();
			this.embarque = new Queue<Visitante>();
			this.viagens = new Stack<Viagem>();
		}
		
		public bool realizarCheckin(int inscricao, Evento evento) {
			var encontrado = evento.pesquisar(new Visitante(inscricao));
			
			if(encontrado == null) return false;
			
			embarque.Enqueue(encontrado);
			return true;
		}
		
		public bool realizarViagem() {
			if(veiculos.disponiveis.Count == 0) return false;
			
			var proximoVeiculo = veiculos.disponiveis.Peek();
			if(embarque.Count < proximoVeiculo.lotacao) return false;
			
			if(viagens.Count > 0) {
				var ultimaViagem = viagens.Peek();
				if(DateTime.Now.Subtract(ultimaViagem.dtViagem) > TimeSpan.FromMinutes(30)) return false;
			}
			
			var passageiros = embarque.Take(proximoVeiculo.lotacao);
			var veiculo = veiculos.disponiveis.Dequeue();
			veiculos.disponiveis.Enqueue(veiculo);
			
			viagens.Push(new Viagem(veiculo, DateTime.Now, passageiros.ToList()));
			passageiros.Select(i => embarque.Dequeue()).ToList();
			
			
			return true;
		}
		
		public string encerrarJornada() {
			string str = "";
			
			foreach (var veiculo in this.veiculos.disponiveis) {
				str += veiculo.placa + " " + veiculo.motorista + " - ";
				int countViagens = 0;
				int countPassageiros = 0;
				
				foreach (var viagem in this.viagens) {
					if(viagem.veiculo.Equals(veiculo)) {
						countViagens++;
						countPassageiros += viagem.passageiros.Count;
					}
				}
				
				str += countViagens + " viagens, ";
				str += countPassageiros + " passageiros = R$";
				str += countPassageiros * 5 + ",00";
			}
			
			this.veiculos.disponiveis.Clear();
			
			return str;
		}
	}
}
