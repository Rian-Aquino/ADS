/*
 * Created by SharpDevelop.
 * User: Rian
 * Date: 28/10/2022
 * Time: 21:11
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Projeto_Atendimento
{
	/// <summary>
	/// Description of Senha.
	/// </summary>
	public class Senha
	{
		private  int _id;
		private  DateTime _dataGerac;
		private  DateTime _dataAtend;
		
		public  int id  { get { return _id ; } set { _id  = value; } }
		public  DateTime dataGerac  { get { return _dataGerac ; } set { _dataGerac  = value; } }
		public  DateTime dataAtend  { get { return _dataAtend ; } set { _dataAtend  = value; } }
		
		public Senha(int id)
		{
			this._id = id;
			this._dataGerac = DateTime.Now;
		}
		
		public String dadosParciais()
		{
			return this._id + " - " + this._dataGerac;
		}
		
		public String dadosCompletos()
		{
			return this._id + " - " + this._dataGerac + " - " + this._dataAtend;
		}
	}
}
