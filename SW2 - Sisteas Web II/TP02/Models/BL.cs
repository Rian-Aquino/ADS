using System.ComponentModel.DataAnnotations.Schema;
using TP02.Models;

/*
 Dupla:
    Gabriel Ferreira de Souza
    Rian Gustavo Quintanilha de Aquino
 */

namespace TP02.Models
{
    public class BL
    {
        public int ID { get; set; }
        public String Numero { get; set; }
        public String Consignee { get; set; }
        public String Navio { get; set; }

        public ICollection<Container> Containers { get; set; } = new List<Container>();
    }
}