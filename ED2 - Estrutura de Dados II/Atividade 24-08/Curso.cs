using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_24_08
{
    class Curso
    {
      private int id;
      private string descricao;
      private Disciplina[] disciplinas;
      private int qtdDisciplinas;
      private int maxDisciplinas;

      public int Id { get => id; }
      public string Descricao { get => descricao; }
      public Disciplina[] Disciplinas { get => disciplinas; }
      public int QtdDisciplinas { get => qtdDisciplinas; }

      public Curso(int id, string descricao) {
        this.id = id;
        this.descricao = descricao;
        this.qtdDisciplinas = 0;
        this.maxDisciplinas = 12;
        this.disciplinas = new Disciplina[this.maxDisciplinas];
      }

      public Curso(int id): this(id, "") {}

      public bool adicionarDisciplina(Disciplina disciplina) {
        bool podeAdicionar = (this.qtdDisciplinas < this.maxDisciplinas);

        if(podeAdicionar) {
          this.disciplinas[this.qtdDisciplinas] = disciplina;
          this.qtdDisciplinas++;
        }

        return podeAdicionar;
      }

      public Disciplina pesquisarDisciplina(Disciplina disciplina) {
        Disciplina disciplinaEncontrado = new Disciplina(-1);
        foreach (Disciplina d in disciplinas)
        {
          if(d != null && d.Equals(disciplina)) {
            disciplinaEncontrado = d;
            break;
          }
        }

        return disciplinaEncontrado;
      }

      public bool removerDisciplina(Disciplina disciplina) {
        bool podeRemover;
        int i = 0;

        while (i < this.maxDisciplinas && !this.disciplinas[i].Equals(disciplina)) 
        {
            i++;
        }

        podeRemover = (i < this.maxDisciplinas);
        if (podeRemover)
        {
            while (i < this.maxDisciplinas - 1)
            {
                this.disciplinas[i] = this.disciplinas[i + 1];
                i++;
            }

            this.disciplinas[i] = new Disciplina(-1, "");
            this.qtdDisciplinas--;
        }

        return podeRemover;
      }

      public override string ToString() {
          return this.id.ToString() + " - " + this.descricao;
      }

      public bool Equals(Curso curso) {
        return this.id.Equals(curso.id);
      }
    }
}
