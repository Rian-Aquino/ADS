/*
 * Created by SharpDevelop.
 * User: Rian
 * Date: 29/10/2022
 * Time: 20:31
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Projeto_Medicamento
{
	/// <summary>
	/// Description of Lote.
	/// </summary>
	public class Lote
	{
		private  int _id;
		private  int _qtde;
		private  DateTime _venc;
		
		public  int id { get { return _id; } set { _id = value; } }
		public  int qtde { get { return _qtde; } set { _qtde = value; } }
		public  DateTime venc { get { return _venc; } set { _venc = value; } }
		
		public Lote() {
			this._id = 1;
			this._qtde = 10;
			this._venc = DateTime.Now.AddMonths(24);
		}
		
		public Lote(int id, int qtde, DateTime venc) {
			this._id = id;
			this._qtde = qtde;
			this._venc = venc;
		}
		
		override public string ToString() {
			return this._id + " - " + this._qtde + " - " + this._venc;
		}

	}
}
