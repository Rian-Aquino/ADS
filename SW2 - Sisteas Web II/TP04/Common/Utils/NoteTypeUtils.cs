using Common.Models;

/*
 Dupla:
    Gabriel Ferreira de Souza
    Rian Gustavo Quintanilha de Aquino
 */

namespace Common.Utils
{
    public class NoteTypeUtils
    {
        public static string ToString(NoteType noteType) => Enum.GetName(noteType);
    }
}