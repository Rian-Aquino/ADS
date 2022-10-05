using System;
using System.Collections.Generic;

class Livro
{
    private int isbn;
    private string titulo;
    private string autor;
    private string editora;
    private List<Exemplar> exemplares;

    public Livro(int i, string t, string a, string e)
    {
        this.isbn = i;
        this.titulo = t;
        this.autor = a;
        this.editora = e;
        this.exemplares = new List<Exemplar>();
    }

    public Livro(int i)
    {
        this.isbn = i;
        this.titulo = "";
        this.autor = "";
        this.editora = "";
        this.exemplares = new List<Exemplar>();
    }

    public int Isbn
    {
        get { return isbn; }
        set { isbn = value; }
    }

    public string Titulo
    {
        get { return titulo; }
        set { titulo = value; }
    }

    public string Autor
    {
        get { return autor; }
        set { autor = value; }
    }

    public string Editora
    {
        get { return editora; }
        set { editora = value; }
    }

    public List<Exemplar> Exemplares
    {
        get { return exemplares; }
        set { exemplares = value; }
    }

    public void adicionarExemplar(Exemplar exemplar)
    {
        this.exemplares.Add(exemplar);
    }

    public int qtdeExemplares()
    {
        return this.exemplares.Count;
    }

    public int qtdeDisponiveis()
    {
        int counter = 0;
        this.exemplares.ForEach(delegate (Exemplar exemplar)
        {
            if (exemplar.disponivel())
            {
                counter++;
            }
        });

        return counter;
    }

    public int qtdeEmprestimos()
    {
        int counter = 0;
        this.exemplares.ForEach(delegate (Exemplar exemplar)
        {
            counter += exemplar.qtdeEmprestimo();
        });

        return counter;
    }

    public double percDisponibilidade()
    {
        double disponiveis = Convert.ToDouble(this.qtdeDisponiveis());
        double exemplares = Convert.ToDouble(this.qtdeExemplares());

        if (qtdeDisponiveis() > 0)
        {
            return disponiveis / exemplares * 100;
        }

        return 0;
    }
}