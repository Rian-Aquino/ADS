/*
 * Created by SharpDevelop.
 * User: Rian
 * Date: 28/10/2022
 * Time: 17:08
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;

namespace Projeto_Atendimento
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		private Senhas _senhas;
		private Guiches _guiches;
		
		private Guiche selected;
		
		public MainForm()
		{
			InitializeComponent();
		
			this._senhas = new Senhas();
			this._guiches = new Guiches();
			
			Guiche guiche = this._guiches.adicionar();
			comboBox1.Items.Add(guiche.id);
			this.selected = guiche;
		}
		
		void renderizarSenhas() {
			var senhas = this._senhas.filaSenhas.Select(_senha => _senha.dadosParciais()).ToArray();
			
			listBox.Items.Clear();
			listBox.Items.AddRange(senhas);
		}
		
		void renderizarAtendimentos(Guiche guiche) {
			var atendimentos = guiche.atendimentos.Select(_senha => _senha.dadosCompletos()).ToArray();
			
			listBox1.Items.Clear();
			listBox1.Items.AddRange(atendimentos);
		}
		
		// Gerar senha
		void Button1Click(object sender, EventArgs e)
		{
			this._senhas.gerar();
			renderizarSenhas();
		}
		
		// Adicionar guiche
		void Button2Click(object sender, EventArgs e)
		{
			Guiche guiche = this._guiches.adicionar();
			comboBox1.Items.Add(guiche.id);
		}
		
		// Chamar senha
		void Button3Click(object sender, EventArgs e)
		{
			this.selected.chamar(this._senhas.filaSenhas);
			renderizarAtendimentos(this.selected);
			renderizarSenhas();
		}
		
		void ComboBox1SelectedIndexChanged(object sender, EventArgs e)
		{
			this.selected = this._guiches.listaGuiches.Find(_guiche => _guiche.id == comboBox1.SelectedIndex + 1);
			renderizarAtendimentos(this.selected);
		}
		
	}
}
