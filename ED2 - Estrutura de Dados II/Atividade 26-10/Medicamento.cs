/*
 * Created by SharpDevelop.
 * User: Rian
 * Date: 29/10/2022
 * Time: 20:37
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace Projeto_Medicamento
{
	/// <summary>
	/// Description of Medicamento.
	/// </summary>
	public class Medicamento
	{
		private  int _id;
		private  string _nome;
		private  string _laboratorio;
		private Queue<Lote> _lotes;
		
		public  int id { get { return _id; } set { _id = value; } }
		public  string nome { get { return _nome; } set { _nome = value; } }
		public  string laboratorio { get { return _laboratorio; } set { _laboratorio = value; } }
		public Queue<Lote> lotes { get { return _lotes; } set { _lotes = value; } }

		public Medicamento() {
			this._id = 0;
		}
		
		public Medicamento(int id) {
			this._id = id;
		}
		
		public Medicamento(int id, string nome, string laboratorio) {
			this._id = id;
			this._nome = nome;
			this._laboratorio = laboratorio;
			this._lotes = new Queue<Lote>();
		}
		
		public int qtdeDisponivel() {
			int contador = 0;

			foreach (var lote in this._lotes) {
				contador += lote.qtde;
			}
			
			return contador;
		}
		
		public void comprar(Lote lote) {
			this._lotes.Enqueue(lote);
		}
		
		public bool vender(int qtde) {
			if(this.qtdeDisponivel() < qtde) return false;
			
			while(qtde > 0) {
				var aux = qtde;
				
				qtde -= this._lotes.Peek().qtde;
				
				if(this._lotes.Peek().qtde > 0) {
					this._lotes.Peek().qtde -= aux;
				} 
				
				if(this._lotes.Peek().qtde <= 0) {
					this._lotes.Dequeue();
				}
				
			}
			
			return true;
		}
		
		override public string ToString() {
			return this._id + " - " + this._nome + " - " + this._laboratorio + " - " + this.qtdeDisponivel();
		}
		
		public bool Equals(Medicamento medicamento) {
	        return this._id.Equals(medicamento.id);
      	}
		
	}
}
