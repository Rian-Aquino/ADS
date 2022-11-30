using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Projeto_Transporte
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		Evento evento;
		Terminal terminal;
		int countVisitantes = 0;
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			evento = new Evento();
			terminal = new Terminal();
		}
		
		void ButtonVisitanteClick(object sender, EventArgs e)
		{
			if(textBoxVisitanteNome.Text == "") {
				MessageBox.Show(
					"É preciso preencher o nome do visitante!", "Erro no Cadastro",
					MessageBoxButtons.OK, MessageBoxIcon.Error
				);
				
				return;
			}
			
			var visitante = new Visitante(++countVisitantes, textBoxVisitanteNome.Text);
			evento.cadastrar(visitante);
			listBoxVisitantes.Items.Add(visitante.ToString());
		}
		
		void ButtonVeiculoClick(object sender, EventArgs e)
		{
			if(textBoxPlaca.Text == "" || textBoxMotorista.Text == "" || textBoxLotacao.Text == "") {
				MessageBox.Show(
					"É preciso preencher todos os campos!", "Erro no Cadastro",
					MessageBoxButtons.OK, MessageBoxIcon.Error
				);
				
				return;
			}
			
			try {
				var lotacao = Convert.ToInt32(textBoxLotacao.Text);
				
				var veiculo = new Veiculo(textBoxPlaca.Text, textBoxMotorista.Text, lotacao);
				terminal.veiculos.cadastrar(veiculo);
				
				listBoxVeiculos.Items.Add(veiculo.ToString());
			} catch (Exception) {
				MessageBox.Show(
					"Lotação precisa ser um número", "Erro no Cadastro",
					MessageBoxButtons.OK, MessageBoxIcon.Error
				);
			}
		}
		
		void ButtonHabilitarVeiculoClick(object sender, EventArgs e)
		{
			var placa = textBoxHabilitarVeiculo.Text;
			
			if(textBoxHabilitarVeiculo.Text == "") {
				MessageBox.Show(
					"É preciso preencher todos os campos!", "Erro no Cadastro",
					MessageBoxButtons.OK, MessageBoxIcon.Error
				);
				
				return;
			}
			
			var veiculo = terminal.veiculos.pesquisar(new Veiculo(placa));
			
			if(veiculo == null) {
				MessageBox.Show(
					"Veículo não encontrado", "Erro no Cadastro",
					MessageBoxButtons.OK, MessageBoxIcon.Error
				);
				
				return;
			}
			
			if(terminal.veiculos.disponiveis.Contains(veiculo)) {
				MessageBox.Show(
					"Veículo já está a serviço", "Erro no Cadastro",
					MessageBoxButtons.OK, MessageBoxIcon.Error
				);
				
				return;
			}
			
			terminal.veiculos.habilitar(veiculo);
			listBoxProxVeiculos.Items.Add(veiculo.ToString());
			
			UpdateProxVeiculo();
		}
		
		void UpdateProxVeiculo() {
			var veiculo = terminal.veiculos.disponiveis.Peek();
			
			labelPlaca.Text = veiculo.placa;
			labelMotorista.Text = veiculo.motorista;
			labelLotacao.Text = Convert.ToString(veiculo.lotacao);
		}
		
		void ButtonCheckinClick(object sender, EventArgs e)
		{
			if(textBoxCheckin.Text == "") {
				MessageBox.Show(
					"É preciso preencher todos os campos!", "Erro no Cadastro",
					MessageBoxButtons.OK, MessageBoxIcon.Error
				);
				
				return;
			}
			
			try {
				var inscricao = Convert.ToInt32(textBoxCheckin.Text);
				
				var sucesso = terminal.realizarCheckin(inscricao, evento);
				if(!sucesso) {
					MessageBox.Show(
						"Visitante não cadastrado", "Erro no Check-In",
						MessageBoxButtons.OK, MessageBoxIcon.Error
					);
					
					return;
				}
				
				listBoxEmbarque.Items.Add(evento.pesquisar(new Visitante(inscricao)).ToString());
			} catch (Exception) {
				MessageBox.Show(
					"Inscrição precisa ser um número", "Erro no Check-In",
					MessageBoxButtons.OK, MessageBoxIcon.Error
				);
			}
		}
		
		void ButtonViagemClick(object sender, EventArgs e)
		{
			var sucesso = terminal.realizarViagem();
			if(!sucesso) {
				MessageBox.Show(
					"Não é possível fazer a viagem, espere tempo suficiente ou complete a lotação do veículo", "Erro na Partida",
					MessageBoxButtons.OK, MessageBoxIcon.Error
				);
				
				return;
			}
			
			listBoxViagem.Items.Add(terminal.viagens.Peek().ToString());
			listBoxEmbarque.Items.Clear();
			listBoxEmbarque.Items.AddRange(terminal.embarque.ToArray());
			
			var veiculo = terminal.veiculos.disponiveis.Peek();
			
			labelPlaca.Text = veiculo.placa;
			labelMotorista.Text = veiculo.motorista;
			labelLotacao.Text = Convert.ToString(veiculo.lotacao);
			
			listBoxProxVeiculos.Items.Clear();
			listBoxProxVeiculos.Items.AddRange(terminal.veiculos.disponiveis.ToArray());
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			var jornada = terminal.encerrarJornada();
			listBoxJornada.Items.Add(jornada);
			listBoxProxVeiculos.Items.Clear();
		}
	}
}
