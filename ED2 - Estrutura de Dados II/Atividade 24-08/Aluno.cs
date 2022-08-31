using System;

namespace Atividade_24_08
{
    class Aluno
    {
      private int id;
      private string nome;

      public int Id { get => id; }
      public string Nome { get => nome; }

      public Aluno(int id, string nome) {
        this.id = id;
        this.nome = nome;
      }

      public Aluno(int id): this(id, "") {}

      public Curso getCursoMatriculado(Escola escola) {
        Curso cursoMatriculado = new Curso(-1);

        for(int i = 0; i < escola.QtdCursos; i++) {
          for(int j = 0; j < escola.Cursos[i].QtdDisciplinas; j++) {
            for(int k = 0; k < escola.Cursos[i].Disciplinas[j].QtdAlunos; k++) {
              if (escola.Cursos[i].Disciplinas[j].Alunos[k].Equals(this)) {
                cursoMatriculado = escola.Cursos[i];
              }
            }
          }
        }

        return cursoMatriculado;
      }

      public bool podeMatricular(Escola escola, Curso curso) {
        return this.getCursoMatriculado(escola).Equals(curso);
      }

      public bool Equals(Aluno aluno) {
        return this.id.Equals(aluno.id);
      }
    }
}
