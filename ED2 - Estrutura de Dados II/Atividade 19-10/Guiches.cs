/*
 * Created by SharpDevelop.
 * User: Rian
 * Date: 29/10/2022
 * Time: 15:42
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace Projeto_Atendimento
{
	/// <summary>
	/// Description of Guiches.
	/// </summary>
	public class Guiches
	{
		private List<Guiche> _listaGuiches;
		
		public  List<Guiche> listaGuiches  { get { return _listaGuiches ; } set { _listaGuiches  = value; } }
		
		public Guiches()
		{
			this._listaGuiches = new List<Guiche>();
		}
		
		public Guiche adicionar()
		{
			Guiche guiche = new Guiche(this._listaGuiches.Count + 1);
			this._listaGuiches.Add(guiche);
			
			return guiche;
		}
	}
}
