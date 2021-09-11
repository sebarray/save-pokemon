using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using save_pokemon.model;

namespace save_pokemon.Data
{
    public class save_pokemonContext : DbContext
    {
        public save_pokemonContext (DbContextOptions<save_pokemonContext> options)
            : base(options)
        {
        }

        public DbSet<save_pokemon.model.Pokemon> Pokemon { get; set; }
    }
}
