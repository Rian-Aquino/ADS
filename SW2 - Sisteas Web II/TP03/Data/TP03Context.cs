using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TP03.Models;

/*
 Dupla:
    Gabriel Ferreira de Souza
    Rian Gustavo Quintanilha de Aquino
 */

namespace TP03.Data
{
    public class TP03Context : DbContext
    {
        public TP03Context (DbContextOptions<TP03Context> options)
            : base(options)
        {
        }

        public DbSet<TP03.Models.Produto> Produto { get; set; } = default!;
    }
}
