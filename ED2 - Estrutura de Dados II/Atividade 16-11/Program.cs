/*
 * Created by SharpDevelop.
 * User: Rian
 * Date: 22/11/2022
 * Time: 18:19
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Linq;
using System.Collections.Generic;
	
namespace Atividade_Log
{
	class Program
    {		
		static void ErrorMessage(string msg) {
			Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\n  X " + msg);
            Console.ResetColor();
		}
		
		static void SuccessMessage(string msg) {
			Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\n  V " + msg);
            Console.ResetColor();
		}
		
		static void Continue() {
			Console.WriteLine();
			Console.ForegroundColor = ConsoleColor.DarkGray;
			Console.Write("  Pressione qualquer tecla para continuar . . .");
			Console.ResetColor();
			Console.ReadKey();
		}
		
		static void CadastrarAmbientePage(Cadastro cadastro, Menu menu) {
			try {
				Console.Clear();
				Console.WriteLine("\n  Home / Ambientes / Cadastro");
				Console.WriteLine();
				
				Console.WriteLine("  Cadastrar um novo ambiente");
				Console.WriteLine();
				
				Console.Write("  Id: ");
				int id = Convert.ToInt32(Console.ReadLine());
				
				Console.Write("  Nome: ");
				string nome = Console.ReadLine();
				
				cadastro.adicionarAmbiente(new Ambiente(id, nome));
				
				SuccessMessage("Ambiente cadastrado com sucesso");
			} catch (Exception) {
				ErrorMessage("Algo deu errado, por favor tente novamente");
			} finally {
				Continue();				
				menu.Render();
			}
		}
		
		static void ConsultarAmbientePage(Cadastro cadastro, Menu menu) {
			try {
				Console.Clear();
				Console.WriteLine("\n  Home / Ambientes / Consulta");
				Console.WriteLine();
				
				Console.WriteLine("  Consulte um ambiente existente");
				Console.WriteLine();
				
				Console.Write("  Id: ");
				int id = Convert.ToInt32(Console.ReadLine());
				
				var ambiente = cadastro.pesquisarAmbiente(new Ambiente(id));
				
				if(ambiente != null) {
					SuccessMessage("Ambiente encontrado");
					Console.WriteLine();
					Console.WriteLine(ambiente.ToString());
				} else {
					ErrorMessage("Ambiente não encontrado");
				}
				
			} catch (Exception) {
				ErrorMessage("Algo deu errado, por favor tente novamente");
			} finally {
				Continue();				
				menu.Render();
			}
		}
		
		static void RemoverAmbientePage(Cadastro cadastro, Menu menu) {
			try {
				Console.Clear();
				Console.WriteLine("\n  Home / Ambientes / Remover");
				Console.WriteLine();
				
				Console.WriteLine("  Deletar um ambiente existente");
				Console.WriteLine();
				
				Console.Write("  Id: ");
				int id = Convert.ToInt32(Console.ReadLine());
				
				var sucesso = cadastro.removerAmbiente(cadastro.pesquisarAmbiente(new Ambiente(id)));
				
				if(sucesso) {
					SuccessMessage("Ambiente removido com sucesso");
				} else {
					ErrorMessage("Não foi possível remover o ambiente");
				}
				
			} catch (Exception) {
				ErrorMessage("Algo deu errado, por favor tente novamente");
			} finally {
				Continue();				
				menu.Render();
			}
		}
		
        static void CadastrarUsuarioPage(Cadastro cadastro, Menu menu) {
			try {
				Console.Clear();
				Console.WriteLine("\n  Home / Usuários / Cadastro");
				Console.WriteLine();
				
				Console.WriteLine("  Cadastrar um novo usuário");
				Console.WriteLine();
				
				Console.Write("  Id: ");
				int id = Convert.ToInt32(Console.ReadLine());
				
				Console.Write("  Nome: ");
				string nome = Console.ReadLine();
				
				cadastro.adicionarUsuario(new Usuario(id, nome));
				
				SuccessMessage("Usuário cadastrado com sucesso");
			} catch (Exception) {
				ErrorMessage("Algo deu errado, por favor tente novamente");
			} finally {
				Continue();				
				menu.Render();
			}
		}
		
		static void ConsultarUsuarioPage(Cadastro cadastro, Menu menu) {
			try {
				Console.Clear();
				Console.WriteLine("\n  Home / Usuários / Consulta");
				Console.WriteLine();
				
				Console.WriteLine("  Consulte um usuário existente");
				Console.WriteLine();
				
				Console.Write("  Id: ");
				int id = Convert.ToInt32(Console.ReadLine());
				
				var usuario = cadastro.pesquisarUsuario(new Usuario(id));
				
				if(usuario != null) {
					SuccessMessage("Usuário encontrado");
					Console.WriteLine();
					Console.WriteLine(usuario.ToString());
				} else {
					ErrorMessage("Usuário não encontrado");
				}
				
			} catch (Exception) {
				ErrorMessage("Algo deu errado, por favor tente novamente");
			} finally {
				Continue();				
				menu.Render();
			}
		}
		
		static void RemoverUsuarioPage(Cadastro cadastro, Menu menu) {
			try {
				Console.Clear();
				Console.WriteLine("\n  Home / Usuários / Remover");
				Console.WriteLine();
				
				Console.WriteLine("  Deletar um usuário existente");
				Console.WriteLine();
				
				Console.Write("  Id: ");
				int id = Convert.ToInt32(Console.ReadLine());
				
				var sucesso = cadastro.removerUsuario(cadastro.pesquisarUsuario(new Usuario(id)));
				
				if(sucesso) {
					SuccessMessage("Usuario removido com sucesso");
				} else {
					ErrorMessage("Não foi possível remover o usuário");
				}
				
			} catch (Exception) {
				ErrorMessage("Algo deu errado, por favor tente novamente");
			} finally {
				Continue();				
				menu.Render();
			}
		}
		
		static void ConcederPermissaoPage(Cadastro cadastro, Menu menu) {
			try {
				Console.Clear();
				Console.WriteLine("\n  Home / Usuários / Conceder Permissão");
				Console.WriteLine();
				
				Console.WriteLine("  Conceder permissão para o usuário acessar um ambiente");
				Console.WriteLine();
				
				Console.Write("  Id do Usuário: ");
				int idUsuario = Convert.ToInt32(Console.ReadLine());
				
				var usuario = cadastro.pesquisarUsuario(new Usuario(idUsuario));
				
				if(usuario != null) {
					Console.WriteLine();
					Console.WriteLine("  Permissão a " + usuario.nome + " para acessar o ambiente:");
					
					Console.Write("  Id do Ambiente: ");
					int idAmbiente = Convert.ToInt32(Console.ReadLine());
					
					var ambiente = cadastro.pesquisarAmbiente(new Ambiente(idAmbiente));
					
					if(ambiente != null) {
						var sucesso = usuario.concederPermissao(ambiente);
				
						if(sucesso) {
							SuccessMessage("Permissão concedida");
						} else {
							ErrorMessage("Não foi possível conceder a permissão. Verifique se o usuário já a possui");
						}
						
					} else {
						ErrorMessage("Ambiente não encontrado");
					}
					
				} else {
					ErrorMessage("Usuário não encontrado");
				}
				
			} catch (Exception) {
				ErrorMessage("Algo deu errado, por favor tente novamente");
			} finally {
				Continue();				
				menu.Render();
			}
		}
		
		static void RevogarPermissaoPage(Cadastro cadastro, Menu menu) {
			try {
				Console.Clear();
				Console.WriteLine("\n  Home / Usuários / Revogar Permissão");
				Console.WriteLine();
				
				Console.WriteLine("  Revogar permissão para o usuário acessar um ambiente");
				Console.WriteLine();
				
				Console.Write("  Id do Usuário: ");
				int idUsuario = Convert.ToInt32(Console.ReadLine());
				
				var usuario = cadastro.pesquisarUsuario(new Usuario(idUsuario));
				
				if(usuario != null) {
					Console.WriteLine();
					Console.WriteLine("  Revogar o acesso de " + usuario.nome + " para o ambiente:");
					
					Console.Write("  Id do Ambiente: ");
					int idAmbiente = Convert.ToInt32(Console.ReadLine());
					
					var ambiente = cadastro.pesquisarAmbiente(new Ambiente(idAmbiente));
					
					if(ambiente != null) {
						var sucesso = usuario.revogarPermissao(ambiente);
				
						if(sucesso) {
							SuccessMessage("Permissão revogada");
						} else {
							ErrorMessage("Não foi possível revogar a permissão. Verifique se o usuário realmente a possui");
						}
						
					} else {
						ErrorMessage("Ambiente não encontrado");
					}
					
				} else {
					ErrorMessage("Usuário não encontrado");
				}
				
			} catch (Exception) {
				ErrorMessage("Algo deu errado, por favor tente novamente");
			} finally {
				Continue();				
				menu.Render();
			}
		}
		
		static void RegistrarAcessoPage(Cadastro cadastro, Menu menu) {
			try {
				Console.Clear();
				Console.WriteLine("\n  Home / Ambientes / Registrar acesso");
				Console.WriteLine();
				
				Console.WriteLine("  Registrar tentativa de acesso ao ambiente");
				Console.WriteLine();
				
				Console.Write("  Id do Ambiente: ");
				int idAmbiente = Convert.ToInt32(Console.ReadLine());
				
				var ambiente = cadastro.pesquisarAmbiente(new Ambiente(idAmbiente));
				
				if(ambiente != null) {
					Console.WriteLine();
					Console.WriteLine("  Tentativa de acesso para " + ambiente.nome + " por:");
					
					Console.Write("  Id do Usuário: ");
					int idUsuario = Convert.ToInt32(Console.ReadLine());
					
					var usuario = cadastro.pesquisarUsuario(new Usuario(idUsuario));
					
					if(usuario != null) {
						ambiente.registrar(new Log(usuario, usuario.ambientes.Contains(ambiente)));
			
						SuccessMessage("Acesso registrado");
					} else {
						ErrorMessage("Usuário não encontrado");
					}
					
				} else {
					ErrorMessage("Ambiente não encontrado");
				}
				
			} catch (Exception) {
				ErrorMessage("Algo deu errado, por favor tente novamente");
			} finally {
				Continue();				
				menu.Render();
			}
		}
		
		static void ConsultarLogsPage(Cadastro cadastro, Menu menu) {
			try {
				Console.Clear();
				Console.WriteLine("\n  Home / Ambientes / Logs");
				Console.WriteLine();
				
				Console.WriteLine("  Consulte os logs de um ambiente existente");
				Console.WriteLine();
				
				Console.Write("  Id: ");
				int id = Convert.ToInt32(Console.ReadLine());
				
				var ambiente = cadastro.pesquisarAmbiente(new Ambiente(id));
				
				if(ambiente != null) {
					SuccessMessage("Ambiente encontrado");
					Console.WriteLine();
					Console.WriteLine("  Logs:");
					Console.WriteLine();
					
					if(ambiente.logs.Count == 0) {
						Console.WriteLine("  Esse ambiente ainda não possui logs de acesso");
					} else {
						foreach (var log in ambiente.logs) {
							Console.WriteLine(log.ToString());
						}
					}
				} else {
					ErrorMessage("Ambiente não encontrado");
				}
				
			} catch (Exception) {
				ErrorMessage("Algo deu errado, por favor tente novamente");
			} finally {
				Continue();				
				menu.Render();
			}
		}
		
		static void Main(string[] args)
        {
        	var cadastro = new Cadastro();
        	
        	// Mock
        	cadastro.adicionarAmbiente(new Ambiente(1, "Armazém"));
        	cadastro.adicionarAmbiente(new Ambiente(2, "Sala de Reuniões"));
        	cadastro.adicionarAmbiente(new Ambiente(3, "Escritórios"));
        	cadastro.adicionarAmbiente(new Ambiente(4, "Laboratório"));
        	cadastro.adicionarAmbiente(new Ambiente(5, "Hall de Entrada"));
        	cadastro.adicionarAmbiente(new Ambiente(6, "Sala de Espera"));
        	
        	cadastro.adicionarUsuario(new Usuario(1, "Rian"));
        	cadastro.adicionarUsuario(new Usuario(2, "Diogo"));
        	cadastro.adicionarUsuario(new Usuario(3, "Guilherme"));
        	cadastro.adicionarUsuario(new Usuario(4, "Gabriel"));
        	
        	cadastro.pesquisarUsuario(new Usuario(1)).concederPermissao(cadastro.pesquisarAmbiente(new Ambiente(1)));
        	
        	cadastro.pesquisarAmbiente(new Ambiente(1)).registrar(new Log(
        		cadastro.pesquisarUsuario(new Usuario(1)), true
        	));
        	
        	cadastro.pesquisarAmbiente(new Ambiente(1)).registrar(new Log(
        		cadastro.pesquisarUsuario(new Usuario(2)), true
        	));
        	
        	cadastro.pesquisarAmbiente(new Ambiente(1)).registrar(new Log(
        		cadastro.pesquisarUsuario(new Usuario(3)), true
        	));
        	
        	// Menus Setup
        	var MenuHome = new Menu();
        	var MenuAmbientes = new Menu("Home / Ambientes");
        	var MenuUsuarios = new Menu("Home / Usuários");
        	
        	MenuHome.options = new List<Option>{
				new Option("Ambientes", MenuAmbientes.Render),
	            new Option("Usuários", MenuUsuarios.Render),
	            new Option("Registrar Acesso", () =>  RegistrarAcessoPage(cadastro, MenuAmbientes)),
	            new Option("Sair", () => Environment.Exit(0)),
        	};
        	
        	MenuAmbientes.options = new List<Option>{
        		new Option("Cadastrar ambiente", () => CadastrarAmbientePage(cadastro, MenuAmbientes)),
	            new Option("Consultar ambiente", () =>  ConsultarAmbientePage(cadastro, MenuAmbientes)),
	            new Option("Consultar Logs", () =>  ConsultarLogsPage(cadastro, MenuAmbientes)),
	            new Option("Remover ambiente", () =>  RemoverAmbientePage(cadastro, MenuAmbientes)),
	            new Option("Voltar", MenuHome.Render),
        	};
        	
        	MenuUsuarios.options = new List<Option>{
    			new Option("Cadastrar usuário", () => CadastrarUsuarioPage(cadastro, MenuUsuarios)),
	            new Option("Consultar usuário", () =>  ConsultarUsuarioPage(cadastro, MenuUsuarios)),
	            new Option("Conceder permissão", () =>  ConcederPermissaoPage(cadastro, MenuUsuarios)),
	            new Option("Revogar permissão", () =>  RevogarPermissaoPage(cadastro, MenuUsuarios)),
	            new Option("Remover usuário", () =>  RemoverUsuarioPage(cadastro, MenuUsuarios)),
	            new Option("Voltar", MenuHome.Render),
        	};
        	
        	MenuHome.Render();
        }
    }

}