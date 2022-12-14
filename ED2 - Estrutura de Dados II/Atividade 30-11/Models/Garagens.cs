using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportePilha.Models
{
    class Garagens
    {
        private List<Garagem> garagens;
        private bool jornadaAtiva;

        public List<Garagem> Garagensl
        {
            get { return garagens; }
            set { garagens = value; }
        }

        public void incluir(Garagem garagem)
        {
            garagem.Id = garagens.Count + 1;
            garagens.Add(garagem);
        }

        public void iniciarJornada()
        {
            jornadaAtiva = true;

        }

        public List<Transporte> encerrarJornada(List<Transporte> lTrans)
        {
            jornadaAtiva = false;

            return lTrans;
        }

    }
}
