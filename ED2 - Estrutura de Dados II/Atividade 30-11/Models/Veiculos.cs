using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportePilha.Models
{
    class Veiculos
    {
        private List<Veiculo> veiculos;

        public List<Veiculo> Veiculosl
        {
            get { return veiculos; }
            set { veiculos = value; }
        }

        public void incluir(Veiculo vei)
        {
            vei.Id = veiculos.Count + 1;
            veiculos.Add(vei);
        }


    }
}
