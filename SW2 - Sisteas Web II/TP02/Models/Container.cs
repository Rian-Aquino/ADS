using System.ComponentModel.DataAnnotations.Schema;

/*
 Dupla:
    Gabriel Ferreira de Souza
    Rian Gustavo Quintanilha de Aquino
 */

namespace TP02.Models
{
    public class Container
    {
        public int ID { get; set; }
        public String Numero { get; set; }
        public TipoEnum Tipo { get; set; }
        public TamanhoEnum Tamanho { get; set; }

        public int BLID { get; set; }
        public BL? BL { get; set; }
    }
}
