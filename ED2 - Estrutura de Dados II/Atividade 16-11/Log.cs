/*
 * Created by SharpDevelop.
 * User: Rian
 * Date: 22/11/2022
 * Time: 18:23
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Atividade_Log
{
	/// <summary>
	/// Description of Log.
	/// </summary>
	public class Log
	{
		
		public DateTime dtAcesso {
			get;
			set;
		}
		
		public Usuario usuario {
			get;
			set;
		}
		
		public bool tipoAcesso {
			get;
			set;
		}

		public Log(Usuario u, bool ta)
		{
			this.dtAcesso = DateTime.Now;
			this.usuario = u;
			this.tipoAcesso = ta;
		}
		
		public override string ToString()
		{
			return string.Format("  [ Log {0}, Usuario [{1}, {2}], Permitido: {3} ]", dtAcesso, usuario.id, usuario.nome, tipoAcesso);
		}

	}
}
