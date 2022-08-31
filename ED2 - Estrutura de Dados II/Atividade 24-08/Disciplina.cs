using System;

namespace Atividade_24_08
{
    class Disciplina
    {
      private int id;
      private string descricao;
      private Aluno[] alunos;
      private int qtdAlunos;
      private int maxAlunos;

      public int Id { get => id; }
      public string Descricao { get => descricao; }
      public Aluno[] Alunos { get => alunos; }
      public int QtdAlunos { get => qtdAlunos; }

      public Disciplina(int id, string descricao) {
        this.id = id;
        this.descricao = descricao;
        this.qtdAlunos = 0;
        this.maxAlunos = 15;
        this.alunos = new Aluno[this.maxAlunos];
      }

      public Disciplina(int id): this(id, "") {}

      public bool matricularAluno(Aluno aluno) {
          bool podeAdicionar = (this.qtdAlunos < this.maxAlunos);

          if(podeAdicionar) {
            this.alunos[this.qtdAlunos] = aluno;
            this.qtdAlunos++;
        }

        return podeAdicionar;
      }

      public bool desmatricularAluno(Aluno aluno) {
        bool podeRemover;
        int i = 0;

        while (i < this.maxAlunos && !this.alunos[i].Equals(aluno)) 
        {
            i++;
        }

        podeRemover = (i < this.maxAlunos);
        if (podeRemover)
        {
            while (i < this.maxAlunos - 1)
            {
                this.alunos[i] = this.alunos[i + 1];
                i++;
            }

            this.alunos[i] = new Aluno(-1, "");
            this.qtdAlunos--;
        }

        return podeRemover;
      }

      public bool Equals(Disciplina disciplina) {
        return this.id.Equals(disciplina.id);
      }
    }
}
