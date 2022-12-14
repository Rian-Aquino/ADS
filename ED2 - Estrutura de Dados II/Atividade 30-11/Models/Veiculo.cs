using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportePilha.Models
{
    class Veiculo
    {
        private int id;
        private string placa;
        private int lotacao;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Placa
        {
            get { return placa; }
            set { placa = value; }
        }

        public int Lotacao
        {
            get { return lotacao; }
            set { lotacao = value; }
        }

        public override bool Equals(object obj)
        {
            return this.placa.Equals(((Veiculo)obj).placa);
        }
    }
}
