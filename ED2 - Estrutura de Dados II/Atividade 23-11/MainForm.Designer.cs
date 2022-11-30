/*
 * Created by SharpDevelop.
 * User: Rian
 * Date: 30/11/2022
 * Time: 01:40
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Projeto_Transporte
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPageEvento;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button buttonVisitante;
		private System.Windows.Forms.TextBox textBoxVisitanteNome;
		private System.Windows.Forms.ListBox listBoxVisitantes;
		private System.Windows.Forms.TabPage tabPageTransporte;
		private System.Windows.Forms.SplitContainer splitContainer3;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button buttonCheckin;
		private System.Windows.Forms.TextBox textBoxCheckin;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.ListBox listBoxViagem;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TabPage tabPageVeiculo;
		private System.Windows.Forms.SplitContainer splitContainer2;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox textBoxLotacao;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox textBoxMotorista;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button buttonVeiculo;
		private System.Windows.Forms.TextBox textBoxPlaca;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ListBox listBoxVeiculos;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label labelLotacao;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.ListBox listBoxEmbarque;
		private System.Windows.Forms.Label labelMotorista;
		private System.Windows.Forms.Label labelPlaca;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Button buttonViagem;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.ListBox listBoxJornada;
		private System.Windows.Forms.ListBox listBoxProxVeiculos;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Button buttonHabilitarVeiculo;
		private System.Windows.Forms.TextBox textBoxHabilitarVeiculo;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.tabPageTransporte = new System.Windows.Forms.TabPage();
			this.splitContainer3 = new System.Windows.Forms.SplitContainer();
			this.labelLotacao = new System.Windows.Forms.Label();
			this.label20 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.listBoxEmbarque = new System.Windows.Forms.ListBox();
			this.labelMotorista = new System.Windows.Forms.Label();
			this.labelPlaca = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.buttonCheckin = new System.Windows.Forms.Button();
			this.textBoxCheckin = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.buttonViagem = new System.Windows.Forms.Button();
			this.listBoxViagem = new System.Windows.Forms.ListBox();
			this.label10 = new System.Windows.Forms.Label();
			this.tabPageVeiculo = new System.Windows.Forms.TabPage();
			this.splitContainer2 = new System.Windows.Forms.SplitContainer();
			this.label12 = new System.Windows.Forms.Label();
			this.textBoxLotacao = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.textBoxMotorista = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.buttonVeiculo = new System.Windows.Forms.Button();
			this.textBoxPlaca = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.listBoxVeiculos = new System.Windows.Forms.ListBox();
			this.label7 = new System.Windows.Forms.Label();
			this.tabPageEvento = new System.Windows.Forms.TabPage();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.label4 = new System.Windows.Forms.Label();
			this.buttonVisitante = new System.Windows.Forms.Button();
			this.textBoxVisitanteNome = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.listBoxVisitantes = new System.Windows.Forms.ListBox();
			this.label3 = new System.Windows.Forms.Label();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.textBoxHabilitarVeiculo = new System.Windows.Forms.TextBox();
			this.buttonHabilitarVeiculo = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.listBoxJornada = new System.Windows.Forms.ListBox();
			this.listBoxProxVeiculos = new System.Windows.Forms.ListBox();
			this.label21 = new System.Windows.Forms.Label();
			this.tabPageTransporte.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
			this.splitContainer3.Panel1.SuspendLayout();
			this.splitContainer3.Panel2.SuspendLayout();
			this.splitContainer3.SuspendLayout();
			this.tabPageVeiculo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
			this.splitContainer2.Panel1.SuspendLayout();
			this.splitContainer2.Panel2.SuspendLayout();
			this.splitContainer2.SuspendLayout();
			this.tabPageEvento.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(4, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(262, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Sistema de transporte";
			// 
			// tabPageTransporte
			// 
			this.tabPageTransporte.Controls.Add(this.splitContainer3);
			this.tabPageTransporte.Location = new System.Drawing.Point(4, 22);
			this.tabPageTransporte.Name = "tabPageTransporte";
			this.tabPageTransporte.Padding = new System.Windows.Forms.Padding(12);
			this.tabPageTransporte.Size = new System.Drawing.Size(575, 189);
			this.tabPageTransporte.TabIndex = 4;
			this.tabPageTransporte.Text = "Transporte";
			this.tabPageTransporte.UseVisualStyleBackColor = true;
			// 
			// splitContainer3
			// 
			this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer3.Location = new System.Drawing.Point(12, 12);
			this.splitContainer3.Name = "splitContainer3";
			// 
			// splitContainer3.Panel1
			// 
			this.splitContainer3.Panel1.Controls.Add(this.labelLotacao);
			this.splitContainer3.Panel1.Controls.Add(this.label20);
			this.splitContainer3.Panel1.Controls.Add(this.label18);
			this.splitContainer3.Panel1.Controls.Add(this.label17);
			this.splitContainer3.Panel1.Controls.Add(this.listBoxEmbarque);
			this.splitContainer3.Panel1.Controls.Add(this.labelMotorista);
			this.splitContainer3.Panel1.Controls.Add(this.labelPlaca);
			this.splitContainer3.Panel1.Controls.Add(this.label14);
			this.splitContainer3.Panel1.Controls.Add(this.label13);
			this.splitContainer3.Panel1.Controls.Add(this.label8);
			this.splitContainer3.Panel1.Controls.Add(this.buttonCheckin);
			this.splitContainer3.Panel1.Controls.Add(this.textBoxCheckin);
			this.splitContainer3.Panel1.Controls.Add(this.label9);
			// 
			// splitContainer3.Panel2
			// 
			this.splitContainer3.Panel2.Controls.Add(this.buttonViagem);
			this.splitContainer3.Panel2.Controls.Add(this.listBoxViagem);
			this.splitContainer3.Panel2.Controls.Add(this.label10);
			this.splitContainer3.Size = new System.Drawing.Size(551, 165);
			this.splitContainer3.SplitterDistance = 310;
			this.splitContainer3.TabIndex = 0;
			// 
			// labelLotacao
			// 
			this.labelLotacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelLotacao.Location = new System.Drawing.Point(91, 67);
			this.labelLotacao.Name = "labelLotacao";
			this.labelLotacao.Size = new System.Drawing.Size(95, 23);
			this.labelLotacao.TabIndex = 12;
			this.labelLotacao.Text = "-";
			// 
			// label20
			// 
			this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label20.Location = new System.Drawing.Point(15, 67);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(70, 23);
			this.label20.TabIndex = 11;
			this.label20.Text = "Lotação:";
			// 
			// label18
			// 
			this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label18.Location = new System.Drawing.Point(202, 13);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(92, 23);
			this.label18.TabIndex = 10;
			this.label18.Text = "Check-In";
			// 
			// label17
			// 
			this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label17.Location = new System.Drawing.Point(15, 102);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(107, 43);
			this.label17.TabIndex = 9;
			this.label17.Text = "Fila de Embarque";
			// 
			// listBoxEmbarque
			// 
			this.listBoxEmbarque.FormattingEnabled = true;
			this.listBoxEmbarque.Location = new System.Drawing.Point(127, 102);
			this.listBoxEmbarque.Name = "listBoxEmbarque";
			this.listBoxEmbarque.Size = new System.Drawing.Size(167, 43);
			this.listBoxEmbarque.TabIndex = 8;
			// 
			// labelMotorista
			// 
			this.labelMotorista.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelMotorista.Location = new System.Drawing.Point(91, 50);
			this.labelMotorista.Name = "labelMotorista";
			this.labelMotorista.Size = new System.Drawing.Size(95, 23);
			this.labelMotorista.TabIndex = 7;
			this.labelMotorista.Text = "-";
			// 
			// labelPlaca
			// 
			this.labelPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelPlaca.Location = new System.Drawing.Point(91, 33);
			this.labelPlaca.Name = "labelPlaca";
			this.labelPlaca.Size = new System.Drawing.Size(76, 23);
			this.labelPlaca.TabIndex = 6;
			this.labelPlaca.Text = "-";
			// 
			// label14
			// 
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.Location = new System.Drawing.Point(15, 50);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(70, 23);
			this.label14.TabIndex = 5;
			this.label14.Text = "Motorista:";
			// 
			// label13
			// 
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(15, 62);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(136, 23);
			this.label13.TabIndex = 4;
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(15, 33);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(70, 23);
			this.label8.TabIndex = 3;
			this.label8.Text = "Veículo:";
			// 
			// buttonCheckin
			// 
			this.buttonCheckin.Location = new System.Drawing.Point(202, 66);
			this.buttonCheckin.Name = "buttonCheckin";
			this.buttonCheckin.Size = new System.Drawing.Size(92, 23);
			this.buttonCheckin.TabIndex = 2;
			this.buttonCheckin.Text = "Confirmar";
			this.buttonCheckin.UseVisualStyleBackColor = true;
			this.buttonCheckin.Click += new System.EventHandler(this.ButtonCheckinClick);
			// 
			// textBoxCheckin
			// 
			this.textBoxCheckin.Location = new System.Drawing.Point(202, 39);
			this.textBoxCheckin.Name = "textBoxCheckin";
			this.textBoxCheckin.Size = new System.Drawing.Size(92, 20);
			this.textBoxCheckin.TabIndex = 1;
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(14, 11);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(137, 23);
			this.label9.TabIndex = 0;
			this.label9.Text = "Próxima Viagem";
			// 
			// buttonViagem
			// 
			this.buttonViagem.Location = new System.Drawing.Point(19, 12);
			this.buttonViagem.Name = "buttonViagem";
			this.buttonViagem.Size = new System.Drawing.Size(204, 32);
			this.buttonViagem.TabIndex = 3;
			this.buttonViagem.Text = "Realizar Viagem";
			this.buttonViagem.UseVisualStyleBackColor = true;
			this.buttonViagem.Click += new System.EventHandler(this.ButtonViagemClick);
			// 
			// listBoxViagem
			// 
			this.listBoxViagem.FormattingEnabled = true;
			this.listBoxViagem.HorizontalScrollbar = true;
			this.listBoxViagem.Location = new System.Drawing.Point(19, 79);
			this.listBoxViagem.Name = "listBoxViagem";
			this.listBoxViagem.Size = new System.Drawing.Size(204, 69);
			this.listBoxViagem.TabIndex = 2;
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(19, 50);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(204, 23);
			this.label10.TabIndex = 1;
			this.label10.Text = "Viagens Recentes";
			// 
			// tabPageVeiculo
			// 
			this.tabPageVeiculo.Controls.Add(this.splitContainer2);
			this.tabPageVeiculo.Location = new System.Drawing.Point(4, 22);
			this.tabPageVeiculo.Name = "tabPageVeiculo";
			this.tabPageVeiculo.Padding = new System.Windows.Forms.Padding(12);
			this.tabPageVeiculo.Size = new System.Drawing.Size(575, 189);
			this.tabPageVeiculo.TabIndex = 3;
			this.tabPageVeiculo.Text = "Veículos";
			this.tabPageVeiculo.UseVisualStyleBackColor = true;
			// 
			// splitContainer2
			// 
			this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer2.Location = new System.Drawing.Point(12, 12);
			this.splitContainer2.Name = "splitContainer2";
			// 
			// splitContainer2.Panel1
			// 
			this.splitContainer2.Panel1.Controls.Add(this.label12);
			this.splitContainer2.Panel1.Controls.Add(this.textBoxLotacao);
			this.splitContainer2.Panel1.Controls.Add(this.label11);
			this.splitContainer2.Panel1.Controls.Add(this.textBoxMotorista);
			this.splitContainer2.Panel1.Controls.Add(this.label5);
			this.splitContainer2.Panel1.Controls.Add(this.buttonVeiculo);
			this.splitContainer2.Panel1.Controls.Add(this.textBoxPlaca);
			this.splitContainer2.Panel1.Controls.Add(this.label6);
			// 
			// splitContainer2.Panel2
			// 
			this.splitContainer2.Panel2.Controls.Add(this.listBoxVeiculos);
			this.splitContainer2.Panel2.Controls.Add(this.label7);
			this.splitContainer2.Size = new System.Drawing.Size(551, 165);
			this.splitContainer2.SplitterDistance = 301;
			this.splitContainer2.TabIndex = 0;
			// 
			// label12
			// 
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(14, 104);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(90, 23);
			this.label12.TabIndex = 7;
			this.label12.Text = "Lotação";
			// 
			// textBoxLotacao
			// 
			this.textBoxLotacao.Location = new System.Drawing.Point(110, 104);
			this.textBoxLotacao.Name = "textBoxLotacao";
			this.textBoxLotacao.Size = new System.Drawing.Size(170, 20);
			this.textBoxLotacao.TabIndex = 6;
			// 
			// label11
			// 
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(14, 78);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(90, 23);
			this.label11.TabIndex = 5;
			this.label11.Text = "Motorista";
			// 
			// textBoxMotorista
			// 
			this.textBoxMotorista.Location = new System.Drawing.Point(110, 78);
			this.textBoxMotorista.Name = "textBoxMotorista";
			this.textBoxMotorista.Size = new System.Drawing.Size(170, 20);
			this.textBoxMotorista.TabIndex = 4;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(14, 52);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(90, 23);
			this.label5.TabIndex = 3;
			this.label5.Text = "Placa";
			// 
			// buttonVeiculo
			// 
			this.buttonVeiculo.Location = new System.Drawing.Point(14, 130);
			this.buttonVeiculo.Name = "buttonVeiculo";
			this.buttonVeiculo.Size = new System.Drawing.Size(75, 23);
			this.buttonVeiculo.TabIndex = 2;
			this.buttonVeiculo.Text = "Confirmar";
			this.buttonVeiculo.UseVisualStyleBackColor = true;
			this.buttonVeiculo.Click += new System.EventHandler(this.ButtonVeiculoClick);
			// 
			// textBoxPlaca
			// 
			this.textBoxPlaca.Location = new System.Drawing.Point(110, 52);
			this.textBoxPlaca.Name = "textBoxPlaca";
			this.textBoxPlaca.Size = new System.Drawing.Size(170, 20);
			this.textBoxPlaca.TabIndex = 1;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(14, 13);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(266, 23);
			this.label6.TabIndex = 0;
			this.label6.Text = "Cadastro de Veículos Terceirizados";
			// 
			// listBoxVeiculos
			// 
			this.listBoxVeiculos.FormattingEnabled = true;
			this.listBoxVeiculos.Location = new System.Drawing.Point(19, 39);
			this.listBoxVeiculos.Name = "listBoxVeiculos";
			this.listBoxVeiculos.Size = new System.Drawing.Size(205, 108);
			this.listBoxVeiculos.TabIndex = 2;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(19, 13);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(205, 23);
			this.label7.TabIndex = 1;
			this.label7.Text = "Veículos Cadastrados";
			// 
			// tabPageEvento
			// 
			this.tabPageEvento.Controls.Add(this.splitContainer1);
			this.tabPageEvento.Location = new System.Drawing.Point(4, 22);
			this.tabPageEvento.Name = "tabPageEvento";
			this.tabPageEvento.Padding = new System.Windows.Forms.Padding(12);
			this.tabPageEvento.Size = new System.Drawing.Size(575, 189);
			this.tabPageEvento.TabIndex = 0;
			this.tabPageEvento.Text = "Evento";
			this.tabPageEvento.UseVisualStyleBackColor = true;
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(12, 12);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.label4);
			this.splitContainer1.Panel1.Controls.Add(this.buttonVisitante);
			this.splitContainer1.Panel1.Controls.Add(this.textBoxVisitanteNome);
			this.splitContainer1.Panel1.Controls.Add(this.label2);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.listBoxVisitantes);
			this.splitContainer1.Panel2.Controls.Add(this.label3);
			this.splitContainer1.Size = new System.Drawing.Size(551, 165);
			this.splitContainer1.SplitterDistance = 369;
			this.splitContainer1.TabIndex = 0;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(14, 52);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(149, 23);
			this.label4.TabIndex = 3;
			this.label4.Text = "Nome do Visitante";
			// 
			// buttonVisitante
			// 
			this.buttonVisitante.Location = new System.Drawing.Point(190, 78);
			this.buttonVisitante.Name = "buttonVisitante";
			this.buttonVisitante.Size = new System.Drawing.Size(75, 23);
			this.buttonVisitante.TabIndex = 2;
			this.buttonVisitante.Text = "Confirmar";
			this.buttonVisitante.UseVisualStyleBackColor = true;
			this.buttonVisitante.Click += new System.EventHandler(this.ButtonVisitanteClick);
			// 
			// textBoxVisitanteNome
			// 
			this.textBoxVisitanteNome.Location = new System.Drawing.Point(14, 80);
			this.textBoxVisitanteNome.Name = "textBoxVisitanteNome";
			this.textBoxVisitanteNome.Size = new System.Drawing.Size(170, 20);
			this.textBoxVisitanteNome.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(14, 13);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(340, 23);
			this.label2.TabIndex = 0;
			this.label2.Text = "Inscrição no evento do Centro de Exposição";
			// 
			// listBoxVisitantes
			// 
			this.listBoxVisitantes.FormattingEnabled = true;
			this.listBoxVisitantes.Location = new System.Drawing.Point(19, 39);
			this.listBoxVisitantes.Name = "listBoxVisitantes";
			this.listBoxVisitantes.Size = new System.Drawing.Size(135, 108);
			this.listBoxVisitantes.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(19, 13);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(135, 23);
			this.label3.TabIndex = 1;
			this.label3.Text = "Pessoas Inscritas";
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPageEvento);
			this.tabControl1.Controls.Add(this.tabPageVeiculo);
			this.tabControl1.Controls.Add(this.tabPageTransporte);
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Location = new System.Drawing.Point(0, 47);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(583, 215);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.textBoxHabilitarVeiculo);
			this.tabPage1.Controls.Add(this.buttonHabilitarVeiculo);
			this.tabPage1.Controls.Add(this.button4);
			this.tabPage1.Controls.Add(this.listBoxJornada);
			this.tabPage1.Controls.Add(this.listBoxProxVeiculos);
			this.tabPage1.Controls.Add(this.label21);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(575, 189);
			this.tabPage1.TabIndex = 5;
			this.tabPage1.Text = "Terminal";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// textBoxHabilitarVeiculo
			// 
			this.textBoxHabilitarVeiculo.Location = new System.Drawing.Point(57, 130);
			this.textBoxHabilitarVeiculo.Name = "textBoxHabilitarVeiculo";
			this.textBoxHabilitarVeiculo.Size = new System.Drawing.Size(175, 20);
			this.textBoxHabilitarVeiculo.TabIndex = 7;
			// 
			// buttonHabilitarVeiculo
			// 
			this.buttonHabilitarVeiculo.Location = new System.Drawing.Point(56, 156);
			this.buttonHabilitarVeiculo.Name = "buttonHabilitarVeiculo";
			this.buttonHabilitarVeiculo.Size = new System.Drawing.Size(176, 23);
			this.buttonHabilitarVeiculo.TabIndex = 6;
			this.buttonHabilitarVeiculo.Text = "Habilitar Para Serviço";
			this.buttonHabilitarVeiculo.UseVisualStyleBackColor = true;
			this.buttonHabilitarVeiculo.Click += new System.EventHandler(this.ButtonHabilitarVeiculoClick);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(331, 19);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(175, 23);
			this.button4.TabIndex = 4;
			this.button4.Text = "Terminar Jornada";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// listBoxJornada
			// 
			this.listBoxJornada.FormattingEnabled = true;
			this.listBoxJornada.HorizontalScrollbar = true;
			this.listBoxJornada.Location = new System.Drawing.Point(331, 46);
			this.listBoxJornada.Name = "listBoxJornada";
			this.listBoxJornada.Size = new System.Drawing.Size(175, 134);
			this.listBoxJornada.TabIndex = 3;
			// 
			// listBoxProxVeiculos
			// 
			this.listBoxProxVeiculos.FormattingEnabled = true;
			this.listBoxProxVeiculos.Location = new System.Drawing.Point(57, 46);
			this.listBoxProxVeiculos.Name = "listBoxProxVeiculos";
			this.listBoxProxVeiculos.Size = new System.Drawing.Size(175, 69);
			this.listBoxProxVeiculos.TabIndex = 1;
			// 
			// label21
			// 
			this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label21.Location = new System.Drawing.Point(56, 19);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(176, 23);
			this.label21.TabIndex = 0;
			this.label21.Text = "Próximos Veículos";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(584, 261);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tabControl1);
			this.Name = "MainForm";
			this.Text = "Projeto Transporte";
			this.tabPageTransporte.ResumeLayout(false);
			this.splitContainer3.Panel1.ResumeLayout(false);
			this.splitContainer3.Panel1.PerformLayout();
			this.splitContainer3.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
			this.splitContainer3.ResumeLayout(false);
			this.tabPageVeiculo.ResumeLayout(false);
			this.splitContainer2.Panel1.ResumeLayout(false);
			this.splitContainer2.Panel1.PerformLayout();
			this.splitContainer2.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
			this.splitContainer2.ResumeLayout(false);
			this.tabPageEvento.ResumeLayout(false);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.ResumeLayout(false);

		}
	}
}
