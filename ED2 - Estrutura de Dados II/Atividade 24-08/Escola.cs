using System;

namespace Atividade_24_08
{
    class Escola
    {
      private Curso[] cursos;
      private int qtdCursos;
      private int maxCursos;

      public Curso[] Cursos { get => cursos; }
      public int QtdCursos { get => qtdCursos; }

      public Escola() {
        this.maxCursos = 5;
        this.qtdCursos = 0;
        this.cursos = new Curso[this.maxCursos];
      }

      public bool adicionarCurso(Curso curso) {
        bool podeAdicionar = (this.qtdCursos < this.maxCursos);

        if(podeAdicionar) {
          this.cursos[this.qtdCursos] = curso;
          this.qtdCursos++;
        }

        return podeAdicionar;
      }

      public Curso pesquisarCurso(Curso curso) {
        Curso cursoEncontrado = new Curso(-1);

        foreach (Curso c in cursos)
        {
          if(c != null && c.Equals(curso)) {
            cursoEncontrado = c;
            break;
          }
        }

        return cursoEncontrado;
      }

      public bool removerCurso(Curso curso) {
        bool podeRemover;
        int i = 0;

        while (i < this.maxCursos && !this.cursos[i].Equals(curso)) 
        {
            i++;
        }

        podeRemover = (i < this.maxCursos);
        if (podeRemover)
        {
            while (i < this.maxCursos - 1)
            {
                this.cursos[i] = this.cursos[i + 1];
                i++;
            }

            this.cursos[i] = new Curso(-1, "");
            this.qtdCursos--;
        }

        return podeRemover;
      }
      
    }
}
