
using System;
using System.Collections.Generic;

namespace Projeto_Locação
{
	/// <summary>
	/// Description of TipoEquipamento.
	/// </summary>
	public class TipoEquipamento
	{
		public int id {
			get;
			set;
		}
		
		public string tipo {
			get;
			set;
		}
		
		public double diaria {
			get;
			set;
		}
		
		public Queue<Equipamento> estoque {
			get;
			set;
		}
		
		public TipoEquipamento(int id, string tipo = "", double diaria = 0.0) {
			this.id = id;
			this.tipo = tipo;
			this.diaria = diaria;
			this.estoque = new Queue<Equipamento>();
		}
		
		public void cadastrarEquipamento(int qtd = 1) {
			for (int i = 0; i < qtd; i++) {
				estoque.Enqueue(new Equipamento(estoque.Count + 1));
			}
		}
	}
}
