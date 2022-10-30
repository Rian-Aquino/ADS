/*
 * Created by SharpDevelop.
 * User: Rian
 * Date: 29/10/2022
 * Time: 20:30
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Projeto_Medicamento
{
	class Program
	{
		static Medicamentos medicamentos = new Medicamentos();
		
		public static int menu(bool pause = true)
		{
			if(pause) {
				Console.WriteLine("");
				Console.Write(" Aperte qualquer tecla para continuar. . . ");
				Console.ReadKey(true);
				
				Console.Clear();
				Console.WriteLine("");
			}
			
			Console.WriteLine("");
			
			Console.WriteLine(" +-------- Selecione uma opção: --------+");
			Console.WriteLine(" +--------------------------------------+");
			Console.WriteLine(" | 0. Finalizar processo                |");
			Console.WriteLine(" | 1. Cadastrar medicamento             |");
			Console.WriteLine(" | 2. Consultar medicamento (sintético) |");
			Console.WriteLine(" | 3. Consultar medicamento (analítico) |");
			Console.WriteLine(" | 4. Comprar medicamento               |");
			Console.WriteLine(" | 5. Vender medicamento                |");
			Console.WriteLine(" | 6. Listar medicamentos               |");
			Console.WriteLine(" +--------------------------------------+");
			
			Console.Write(" > ");
			return Convert.ToInt32(Console.ReadLine());
		}
		
		public static void printAlert(int type, string message)
		{
			string[] prefixes = {"OK", "FAIL"};
			
			Console.WriteLine();
			Console.WriteLine(" " + prefixes[type - 1] + " - " + message);
		}
		
		public static void cadastrarMedicamento() {
			Console.WriteLine("");
			Console.WriteLine(" + Preencha as informações:");
			
			Console.Write("  - Id: ");
			int id = Convert.ToInt32(Console.ReadLine());
			
			Console.Write("  - Nome: ");
			string nome = Console.ReadLine();
			
			Console.Write("  - Laboratório: ");
			string laboratorio = Console.ReadLine();
			
			medicamentos.adicionar(new Medicamento(id, nome, laboratorio));
			printAlert(1, "Medicamento cadastrado com sucesso!");
			
		}
		
		public static void consultarMedicamento(int type) {
			Console.WriteLine("");
			Console.WriteLine(" + Preencha as informações:");
			
			Console.Write("  - Id: ");
			int id = Convert.ToInt32(Console.ReadLine());
			
			var medicamento = medicamentos.pesquisar(new Medicamento(id));
			if(medicamento.id == 0) {
				printAlert(2, "Medicamento não foi encontrado.");
				return;
			}
			
			switch (type) {
				case 1:
					Console.WriteLine();
					Console.WriteLine(" +");
					Console.WriteLine(" | Id: " + medicamento.id);
					Console.WriteLine(" |");
					Console.WriteLine(" | Nome: " + medicamento.nome);
					Console.WriteLine(" | Laboratório: " + medicamento.laboratorio);
					Console.WriteLine(" | Qtd. Disponível: : " + medicamento.qtdeDisponivel());
					Console.WriteLine(" +");
					break;
				case 2:
					Console.WriteLine();
					Console.WriteLine(" +");
					Console.WriteLine(" | Id: " + medicamento.id);
					Console.WriteLine(" |");
					Console.WriteLine(" | Nome: " + medicamento.nome);
					Console.WriteLine(" | Laboratório: " + medicamento.laboratorio);
					Console.WriteLine(" | Qtd. Disponível: : " + medicamento.qtdeDisponivel());
					Console.WriteLine(" |");
					Console.WriteLine(" +-- Lotes: ");
					
					foreach (var lote in medicamento.lotes) {
						Console.WriteLine(" +-+");
						Console.WriteLine(" | | Id: " + lote.id);
						Console.WriteLine(" | | Qtd: " + lote.qtde);
						Console.WriteLine(" | | Dt. Venc.: " + lote.venc);
					}
					
					Console.WriteLine(" +-+");
					
					break;
				default: printAlert(2, "Consulta inválida"); break;
			}
			
			printAlert(1, "Medicamento encontrado com sucesso!");
		}
		
		public static void comprarMedicamento() {
			Console.WriteLine("");
			Console.WriteLine(" + Encontre o medicamento:");
			
			Console.Write("  - Id: ");
			int idMedicamento = Convert.ToInt32(Console.ReadLine());
			
			var medicamento = medicamentos.pesquisar(new Medicamento(idMedicamento));
			if(medicamento.id == 0) {
				printAlert(2, "Medicamento não foi encontrado.");
				return;
			}
			
			//
			Console.WriteLine("");
			Console.WriteLine(" + Preencha as informações:");
			
			Console.Write("  - Id: ");
			int id = Convert.ToInt32(Console.ReadLine());
			
			Console.Write("  - Qtd: ");
			int qtd = Convert.ToInt32(Console.ReadLine());
			
			Console.Write("  - Vence em quantos meses? ");
			int meses = Convert.ToInt32(Console.ReadLine());
			
			medicamento.comprar(new Lote(id, qtd, DateTime.Now.AddMonths(meses)));
			printAlert(1, "Lote de medicamento comprado com sucesso!");
		}
		
		public static void venderMedicamento() {
			Console.WriteLine("");
			Console.WriteLine(" + Encontre o medicamento:");
			
			Console.Write("  - Id: ");
			int idMedicamento = Convert.ToInt32(Console.ReadLine());
			
			var medicamento = medicamentos.pesquisar(new Medicamento(idMedicamento));
			if(medicamento.id == 0) {
				printAlert(2, "Medicamento não foi encontrado.");
				return;
			}
			
			//
			Console.WriteLine("");
			Console.WriteLine(" + Preencha as informações:");
			
			Console.Write("  - Vender quantas unidades? ");
			int qtd = Convert.ToInt32(Console.ReadLine());
			
			var success = medicamento.vender(qtd);
			
			if(success) printAlert(1, "Venda realizada com sucesso!");
			else printAlert(2, "Não há unidades suficientes");
		}
		
		public static void listarMedicamentos() {
			foreach (var medicamento in medicamentos.listaMedicamentos) {
				Console.WriteLine();
				Console.WriteLine(" +");
				Console.WriteLine(" | Id: " + medicamento.id);
				Console.WriteLine(" |");
				Console.WriteLine(" | Nome: " + medicamento.nome);
				Console.WriteLine(" | Laboratório: " + medicamento.laboratorio);
				Console.WriteLine(" | Qtd. Disponível: : " + medicamento.qtdeDisponivel());
				Console.WriteLine(" +");
			}
		}
		
		public static void Main(string[] args)
		{
			Console.WriteLine("");
			Console.WriteLine(" +--------- PROJETO MEDICAMENTO --------+");
			
			var opcao = menu(false);
			
			while (opcao != 0) {
				switch (opcao) {
						case 0: break;
						case 1: cadastrarMedicamento(); break;
						case 2: consultarMedicamento(1); break;
						case 3: consultarMedicamento(2); break;
						case 4: comprarMedicamento(); break;
						case 5: venderMedicamento(); break;
						case 6: listarMedicamentos(); break;
						default: Console.WriteLine(" x - Opção inválida, tente uma outra."); break;
				}
				
				opcao = menu();
			}			
			
		}
	}
}