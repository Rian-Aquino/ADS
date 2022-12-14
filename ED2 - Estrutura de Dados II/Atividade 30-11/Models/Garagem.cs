using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportePilha.Models
{
    class Garagem
    {
        private int id;
        private string local;
        private Stack<Veiculo> veiculos;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Local
        {
            get { return local; }
            set { local = value; }
        }

        public Stack<Veiculo> Veiculos
        {
            get { return veiculos; }
            set { veiculos = value; }
        }

        public int qtdeDeVeiculos()
        {
            return veiculos.Count;
        }

        public int potencialDeTransporte()
        {
            return veiculos.Count;
        }


        public override bool Equals(object obj)
        {
            return this.local.Equals(((Garagem)obj).local);
        }
    }
}
