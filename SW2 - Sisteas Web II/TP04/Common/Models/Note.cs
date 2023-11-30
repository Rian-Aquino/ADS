using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Dupla:
    Gabriel Ferreira de Souza
    Rian Gustavo Quintanilha de Aquino
 */

namespace Common.Models
{
    public class Note
    {
        public long Id { get; set; }
        public required string Title { get; set; }
        public NoteType Type { get; set; }
        public required string Text { get; set; }
    }
}
