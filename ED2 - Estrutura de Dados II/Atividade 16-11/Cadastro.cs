/*
 * Created by SharpDevelop.
 * User: Rian
 * Date: 22/11/2022
 * Time: 18:45
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.IO;

namespace Atividade_Log
{
	/// <summary>
	/// Description of Cadastro.
	/// </summary>
	public class Cadastro
	{
		public List<Usuario> usuarios {
			get;
			set;
		}
		
		public List<Ambiente> ambientes {
			get;
			set;
		}
		
		public Cadastro()
		{
			this.usuarios = new List<Usuario>();
			this.ambientes = new List<Ambiente>();
		}
		
		
		public void adicionarUsuario(Usuario usuario) {
			this.usuarios.Add(usuario);
		}
		
		public bool removerUsuario(Usuario usuario) {
			if (usuario.ambientes.Count > 0) {
				return false;
			}
			
			return this.usuarios.Remove(usuario);
		}
		
		public Usuario pesquisarUsuario(Usuario usuario) {
			return this.usuarios.Find(u => u.id == usuario.id);
		}
		
		public void adicionarAmbiente(Ambiente ambiente) {
			this.ambientes.Add(ambiente);
		}
		
		public bool removerAmbiente(Ambiente ambiente) {
			return this.ambientes.Remove(ambiente);
		}
		
		public Ambiente pesquisarAmbiente(Ambiente ambiente) {
			return this.ambientes.Find(a => a.id == ambiente.id);
		}
	}
}
