using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportePilha.Models
{
    class Viagem
    {
        private int id;
        private Garagem origem;
        private Garagem destino;
        private Veiculo veiculo;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public Garagem Origem
        {
            get { return origem; }
            set { origem = value; }
        }

        public Garagem Destino
        {
            get { return destino; }
            set { destino = value; }
        }
        public Veiculo Veiculo
        {
            get { return veiculo; }
            set { veiculo = value; }
        }

        public override bool Equals(object obj)
        {
            return (this.origem.Equals(((Viagem)obj).origem) && this.destino.Equals(((Viagem)obj).destino));
        }
    }
}
