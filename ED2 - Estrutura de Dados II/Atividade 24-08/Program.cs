using System;

namespace Atividade_24_08
{
    class Program
    {
        static int painel() {
            Console.WriteLine();
            Console.WriteLine("  + Selecione: ----------------------------------------------------------+");
            Console.WriteLine("  |                                                                      |");
            Console.WriteLine("  | 0. Sair                          " + "  5. Pesquisar disciplina           |");
            Console.WriteLine("  | 1. Adicionar curso               " + "  6. Remover disciplina do curso    |");
            Console.WriteLine("  | 2. Pesquisar curso               " + "  7. Matricular aluno na disciplina |");
            Console.WriteLine("  | 3. Remover curso                 " + "  8. Remover aluno da disciplina    |");
            Console.WriteLine("  | 4. Adicionar disciplina no curso " + "  9. Pesquisar aluno                |");
            Console.WriteLine("  +----------------------------------------------------------------------+");

            Console.WriteLine();
            Console.Write("  > ");

            return Convert.ToInt32(Console.ReadLine());
        }

        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine(" [ Sistema de Matrícula Escolar ]");

            Escola escola = new Escola();

            int cursoIncrement = 0;
            int disciplinaIncrement = 0;
            Aluno[] listaAlunos = {
                new Aluno(1, "Rian"),
                new Aluno(2, "Diogo"),
                new Aluno(3, "Guilherme"),
                new Aluno(4, "Gabriel"),
            };

            int seletor;

            escola.adicionarCurso(new Curso(++cursoIncrement, "ADM"));
            escola.adicionarCurso(new Curso(++cursoIncrement, "ADS"));
            escola.Cursos[1].adicionarDisciplina(new Disciplina(++disciplinaIncrement, "Mat"));

            do {
                seletor = painel();

                switch (seletor)
                {
                    case 0: break;

                    case 1:
                        {
                            Console.WriteLine();
                            Console.WriteLine("  + Cadastrar curso:");
                            Console.Write("  ? Descrição: ");
                            string cursoDescricao = Console.ReadLine();

                            bool res = escola.adicionarCurso(new Curso(++cursoIncrement, cursoDescricao));

                            if(res) {
                                Console.WriteLine();
                                Console.WriteLine("  v Curso cadastrado com sucesso!");
                            } else {
                                Console.WriteLine();
                                Console.WriteLine("  x Não foi possível cadastrar o curso!");
                            }
                        }
                        break;

                    case 2:
                        {
                            Console.WriteLine();
                            Console.WriteLine("  + Pesquisar curso:");
                            Console.Write("  ? id: ");
                            int id = Convert.ToInt32(Console.ReadLine());

                            Curso curso = escola.pesquisarCurso(new Curso(id));

                            if(curso.Id != -1) {
                                Console.WriteLine();
                                Console.WriteLine("  v Curso encontrado:");
                                Console.WriteLine("  - Id: " + curso.Id);
                                Console.WriteLine("  - Descrição: " + curso.Descricao);
                                Console.WriteLine("  - Disciplinas:");
                                for(int i = 0; i < curso.QtdDisciplinas; i++) {
                                    Console.WriteLine("    - Id: " + curso.Disciplinas[i].Id + ", Descrição: " + curso.Disciplinas[i].Descricao);
                                }
                            } else {
                                Console.WriteLine();
                                Console.WriteLine("  x Não foi possível encontrar o curso!");
                            }
                        }
                        break;
                    case 3:
                        {
                            Console.WriteLine();
                            Console.WriteLine("  + Remover curso:");
                            Console.Write("  ? Id: ");

                            int id = Convert.ToInt32(Console.ReadLine());

                            if(escola.pesquisarCurso(new Curso(id)).Id != -1) {
                                bool res = escola.removerCurso(new Curso(id));

                                if(res) {
                                    Console.WriteLine();
                                    Console.WriteLine("  v Curso removido com sucesso!");
                                } else {
                                    Console.WriteLine();
                                    Console.WriteLine("  x Não foi possível remover o curso!");
                                }
                            } else {
                                Console.WriteLine();
                                Console.WriteLine("  x Não foi possível encontrar o curso!");
                            }

                        }
                        break;

                    //
                    case 4:
                        {

                            if (escola.QtdCursos > 0) {
                                Console.WriteLine();
                                Console.WriteLine("  + Cadastrar Disciplina, selecione o curso:");
                                for(int i = 0; i < escola.QtdCursos; i++) {
                                    Console.WriteLine("  " + i + ". " + escola.Cursos[i].Descricao);
                                }

                                Console.WriteLine();
                                Console.Write("  > ");
                                Curso cursoEncontrado = escola.Cursos[Convert.ToInt32(Console.ReadLine())];

                                Console.WriteLine("  + Adicionar disciplina no curso de " + cursoEncontrado.Descricao + ":");
                                Console.Write("  ? Descrição: ");

                                string disciplinaDescricao = Console.ReadLine();

                                disciplinaIncrement++;
                                bool res = cursoEncontrado.adicionarDisciplina(new Disciplina(disciplinaIncrement, disciplinaDescricao));

                                if(res) {
                                    Console.WriteLine();
                                    Console.WriteLine("  v Disciplina cadastrada com sucesso!");
                                } else {
                                    Console.WriteLine();
                                    Console.WriteLine("  x Não foi possível cadastrar a disciplina!");
                                }
                            } else {
                                    Console.WriteLine();
                                    Console.WriteLine("  x Não existem cursos cadastrados!");
                            }
                            
                        }
                        break;
                    case 5:
                        {
                            Console.WriteLine();
                            Console.WriteLine("  + Pesquisar disciplina:");
                            Console.Write("  ? id: ");
                            int id = Convert.ToInt32(Console.ReadLine());

                            Disciplina disciplina = new Disciplina(-1);

                            for(int i = 0; i < escola.QtdCursos; i++) {
                                Disciplina disciplinaEncontrada = escola.Cursos[i].pesquisarDisciplina(new Disciplina(id));
                                if (disciplinaEncontrada.Id != -1) {
                                    disciplina = disciplinaEncontrada;
                                    break;
                                };
                            }

                            if(disciplina.Id != -1) {
                                Console.WriteLine();
                                Console.WriteLine("  v Disciplina encontrada:");
                                Console.WriteLine("  - Id: " + disciplina.Id);
                                Console.WriteLine("  - Descrição: " + disciplina.Descricao);
                                Console.WriteLine("  - Alunos matriculados:");
                                for(int i = 0; i < disciplina.QtdAlunos; i++) {
                                    Console.WriteLine("    - Id: " + disciplina.Alunos[i].Id + ", Nome: " + disciplina.Alunos[i].Nome);
                                }
                            } else {
                                Console.WriteLine();
                                Console.WriteLine("  x Não foi possível encontrar a disciplina!");
                            }
                        }
                        break;
                    case 6:
                        {
                            Console.WriteLine();
                            Console.WriteLine("  + Remover disciplina:");
                            Console.Write("  ? Id: ");

                            int id = Convert.ToInt32(Console.ReadLine());
                            Disciplina disciplinaEncontrada = new Disciplina(-1);

                            for(int i = 0; i < escola.QtdCursos; i++) {
                                disciplinaEncontrada = escola.Cursos[i].pesquisarDisciplina(new Disciplina(id));

                                if (disciplinaEncontrada.Id != -1) {
                                    bool res = escola.Cursos[i].removerDisciplina(disciplinaEncontrada);
                                    if(res) {
                                        Console.WriteLine();
                                        Console.WriteLine("  v Disciplina removida com sucesso!");
                                    } else {
                                        Console.WriteLine();
                                        Console.WriteLine("  x Não foi possível remover a disciplina!");
                                    }
                                    break;
                                } 
                            }
                            if (disciplinaEncontrada.Id == -1) {
                                    Console.WriteLine();
                                    Console.WriteLine("  x A disciplina não foi encontrada!");
                            }
                        }
                        break;
                    //
                    case 7:
                        {
                            Console.WriteLine();
                            Console.WriteLine("  + Matricular aluno, selecione a disciplina:");

                            for(int i = 0; i < escola.QtdCursos; i++) {
                                Console.WriteLine("  " + i + ". " + escola.Cursos[i].Descricao);
                                for(int j = 0; j < escola.Cursos[i].QtdDisciplinas; j++) {
                                    Console.WriteLine("    " + j + ". " + escola.Cursos[i].Disciplinas[j].Descricao);
                                }
                            }

                            Console.WriteLine();
                            Console.Write("  > Curso: ");
                            int cursoIndex = Convert.ToInt32(Console.ReadLine());

                            Console.Write("  > Disciplina: ");
                            int disciplinaIndex = Convert.ToInt32(Console.ReadLine());

                            Disciplina disciplinaEncontrada = escola.Cursos[cursoIndex].Disciplinas[disciplinaIndex];
                            
                            Console.WriteLine();
                            Console.WriteLine("  + Matricular aluno em " + disciplinaEncontrada.Descricao + ":");
                            Console.Write("  ? Id do aluno: ");
                            int alunoId = Convert.ToInt32(Console.ReadLine());

                            Aluno alunoEncontrado = new Aluno(-1);
                            foreach(Aluno a in listaAlunos) {
                                if (a.Equals(new Aluno(alunoId))) {
                                    alunoEncontrado = a;
                                    break;
                                };
                            }

                            bool res = alunoEncontrado.Id != -1 && disciplinaEncontrada.matricularAluno(alunoEncontrado);

                            if(res) {
                                Console.WriteLine();
                                Console.WriteLine("  v Aluno cadastrado com sucesso!");
                            } else {
                                Console.WriteLine();
                                Console.WriteLine("  x Não foi possível cadastrar o aluno!");
                            }
                        }
                        break;
                    case 8:
                        {
                            Console.WriteLine();
                            Console.WriteLine("  + Desmatricular aluno:");
                            Console.Write("  ? Id: ");

                            int id = Convert.ToInt32(Console.ReadLine());
                            Aluno alunoEncontrado = new Aluno(-1);
                            foreach(Aluno a in listaAlunos) {
                                if (a.Equals(new Aluno(id))) {
                                    alunoEncontrado = a;
                                    break;
                                };
                            }


                            Curso cursoMatriculado = alunoEncontrado.getCursoMatriculado(escola);

                            if (cursoMatriculado.Id != -1) {
                                Console.WriteLine();
                                Console.WriteLine("  + Desmatricular " + alunoEncontrado.Nome + " da disciplina: ");

                                for(int j = 0; j < cursoMatriculado.QtdDisciplinas; j++) {
                                    for(int k = 0; k < cursoMatriculado.Disciplinas[j].QtdAlunos; k++) {
                                        if (cursoMatriculado.Disciplinas[j].Alunos[k].Equals(alunoEncontrado)) {
                                            Console.WriteLine("    " + j + ". " + cursoMatriculado.Disciplinas[j].Descricao);
                                        }
                                    }
                                }

                                Console.WriteLine();
                                Console.Write("  > ");
                                int disciplinaIndex = Convert.ToInt32(Console.ReadLine());

                                Disciplina disciplinaEncontrada = cursoMatriculado.Disciplinas[disciplinaIndex];

                                if (disciplinaEncontrada != null && disciplinaEncontrada.Id != -1) {
                                    bool res = disciplinaEncontrada.desmatricularAluno(alunoEncontrado);
                                    if(res) {
                                        Console.WriteLine();
                                        Console.WriteLine("  v Aluno desmatriculado com sucesso!");
                                    } else {
                                        Console.WriteLine();
                                        Console.WriteLine("  x Não foi possível desmatricular o aluno!");
                                    }
                                } else {
                                    Console.WriteLine();
                                    Console.WriteLine("  x A disciplina não foi encontrada!");
                                }
                            } else {
                                Console.WriteLine();
                                Console.WriteLine("  x O aluno não está matriculado!");
                            }
                        }
                        break;
                    case 9:
                        {
                            Console.WriteLine();
                            Console.WriteLine("  + Pesquisar aluno:");
                            Console.Write("  ? Id: ");

                            int id = Convert.ToInt32(Console.ReadLine());
                            Aluno alunoEncontrado = new Aluno(-1);
                            foreach(Aluno a in listaAlunos) {
                                if (a.Equals(new Aluno(id))) {
                                    alunoEncontrado = a;
                                    break;
                                };
                            }

                            if(alunoEncontrado.Id != -1) {
                                Console.WriteLine();
                                Console.WriteLine("  - Aluno: " + alunoEncontrado.Nome);

                                Curso cursoMatriculado = alunoEncontrado.getCursoMatriculado(escola);

                                
                                if (cursoMatriculado.Id != -1) {
                                    Console.WriteLine("  - Matriculado na(s) disciplina(s):");

                                    for(int j = 0; j < cursoMatriculado.QtdDisciplinas; j++) {
                                        for(int k = 0; k < cursoMatriculado.Disciplinas[j].QtdAlunos; k++) {
                                            if (cursoMatriculado.Disciplinas[j].Alunos[k].Equals(alunoEncontrado)) {
                                                Console.WriteLine("    - " + cursoMatriculado.Disciplinas[j].Descricao);
                                            }
                                        }
                                    }

                                } else {
                                    Console.WriteLine("  (O aluno não está matriculado em nenhuma disciplina)");
                                }


                            } else {
                                Console.WriteLine();
                                Console.WriteLine("  x Não foi possível encontrar o aluno!");
                            }
                        }
                        break;
                    default:
                    break;
                }

            } while(seletor != 0);
        }
    }
}
