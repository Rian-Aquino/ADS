/*
 * Created by SharpDevelop.
 * User: Rian
 * Date: 29/10/2022
 * Time: 14:59
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace Projeto_Atendimento
{
	/// <summary>
	/// Description of Senhas.
	/// </summary>
	public class Senhas
	{
		private  int _proximoAtendimento ;
		private  Queue<Senha> _filaSenhas ;
		
		private int contador = 1;
		
		public  int proximoAtendimento  { get { return _proximoAtendimento ; } set { _proximoAtendimento  = value; } }
		public  Queue<Senha> filaSenhas  { get { return _filaSenhas ; } set { _filaSenhas  = value; } }

		
		public Senhas()
		{
			this._proximoAtendimento = 1;
			this._filaSenhas = new Queue<Senha>();
		}
		
		public void gerar()
		{
			this._filaSenhas.Enqueue(new Senha(contador++));
		}
	}
}
