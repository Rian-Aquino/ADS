/*
 * Created by SharpDevelop.
 * User: Rian
 * Date: 29/10/2022
 * Time: 21:31
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace Projeto_Medicamento
{
	/// <summary>
	/// Description of Medicamentos.
	/// </summary>
	public class Medicamentos
	{
		private List<Medicamento> _listaMedicamentos ;

		public List<Medicamento> listaMedicamentos  { get { return _listaMedicamentos ; } set { _listaMedicamentos  = value; } }

		public Medicamentos()
		{
			this._listaMedicamentos = new List<Medicamento>();
		}
		
		public void adicionar(Medicamento medicamento)
		{
			this._listaMedicamentos.Add(medicamento);
		}
		
		public bool deletar(Medicamento medicamento)
		{
			return medicamento.qtdeDisponivel() > 0 && this._listaMedicamentos.Remove(medicamento);
		}
		
		public Medicamento pesquisar(Medicamento medicamento)
		{
			var selecionado = this._listaMedicamentos.Find(m => m.Equals(medicamento));
			return selecionado ?? new Medicamento();
		}
	}
}
