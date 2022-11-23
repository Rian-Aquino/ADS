/*
 * Created by SharpDevelop.
 * User: Rian
 * Date: 22/11/2022
 * Time: 18:25
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace Atividade_Log
{
	/// <summary>
	/// Description of Ambiente.
	/// </summary>
	public class Ambiente
	{
		public int id {
			get;
			set;
		}
		
		public string nome {
			get;
			set;
		}
		
		public Queue<Log> logs {
			get;
			set;
		}
		
		public Ambiente(int i, string n = "")
		{
			this.id = i;
			this.nome = n;
			this.logs = new Queue<Log>();
		}
		
		public void registrar(Log log) {
			if(logs.Count >= 100) {
				logs.Dequeue();
			}
			
			logs.Enqueue(log);
		}
		
		public override string ToString()
		{
			return string.Format("  -\n   Id: {0}\n   Nome: {1}\n  -", id, nome);
		}

	}
}
