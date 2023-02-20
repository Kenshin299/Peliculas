using Microsoft.EntityFrameworkCore;
using Peliculas.DAL.Entities;

namespace Peliculas.DAL.Context
{
    public class PeliculasContext : DbContext
    {
        public PeliculasContext() 
        {
            
        }

        public DbSet<Pelicula> Peliculas { get; set; }
        public DbSet<Genero> Generos { get; set; }

    }
}
