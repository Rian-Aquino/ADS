using Microsoft.EntityFrameworkCore;

/*
 Dupla:
    Gabriel Ferreira de Souza
    Rian Gustavo Quintanilha de Aquino
 */

namespace Server.Data
{
    public class TP04Context: DbContext
    {
        public TP04Context(DbContextOptions<TP04Context> options)
           : base(options)
        {
        }

        public DbSet<Common.Models.Note> Note { get; set; } = default!;
    }
}
