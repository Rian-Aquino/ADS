/*
 * Created by SharpDevelop.
 * User: Rian
 * Date: 29/10/2022
 * Time: 14:58
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace Projeto_Atendimento
{
	/// <summary>
	/// Description of Guiche.
	/// </summary>
	public class Guiche
	{
		private  int _id ;
		private  Queue<Senha> _atendimentos ;
		
		public  int id  { get { return _id ; } set { _id  = value; } }
		public  Queue<Senha> atendimentos  { get { return _atendimentos ; } set { _atendimentos  = value; } }
		
		public Guiche()
		{
			this._id = 0;
			this._atendimentos = new Queue<Senha>();
		}
		
		public Guiche(int id)
		{
			this._id = id;
			this._atendimentos = new Queue<Senha>();
		}
		
		public bool chamar(Queue<Senha> filaSenhas)
		{
			if(filaSenhas.Count < 1) return false;
			
			Senha senha = filaSenhas.Dequeue();
			
			senha.dataAtend = DateTime.Now;
			this._atendimentos.Enqueue(senha);
			
			return true;
		}
	}
}
