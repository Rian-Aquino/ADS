/*
 * Created by SharpDevelop.
 * User: Rian
 * Date: 22/11/2022
 * Time: 18:21
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace Atividade_Log
{
	/// <summary>
	/// Description of Usuario.
	/// </summary>
	public class Usuario
	{
		public int id {
			get;
			set;
		}
		
		public string nome {
			get;
			set;
		}
		
		public List<Ambiente> ambientes {
			get;
			set;
		}
		
		public Usuario(int i, string n = "")
		{
			this.id = i;
			this.nome = n;
			this.ambientes = new List<Ambiente>();
		}
		
		public bool concederPermissao(Ambiente ambiente) {
			var hasPermission = this.ambientes.Contains(ambiente);
			
			if(!hasPermission) {
				this.ambientes.Add(ambiente);
			}
			
			return !hasPermission;
		}
		
		public bool revogarPermissao(Ambiente ambiente) {
			var hasPermission = this.ambientes.Contains(ambiente);
			
			if(hasPermission) {
				this.ambientes.Remove(ambiente);
			}
			
			return hasPermission;
		}
		
		public override string ToString()
		{
			string str = "  -";
			
			str += "\n   Id: " + id;
			str += "\n   Nome: " + nome;
			
			str += "\n   Permissões: ";
			
			foreach (var ambiente in ambientes) {
				str += "\n    - " + ambiente.nome;
			}
			
			str += "\n  -";
			return str;
		}

	}
}
