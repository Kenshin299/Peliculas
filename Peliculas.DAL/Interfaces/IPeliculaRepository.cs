using Peliculas.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Peliculas.DAL.Interfaces
{
    public interface IPeliculaRepository
    {
        void Add(Pelicula pelicula);
        void Remove(Pelicula pelicula);
        void Update(Pelicula pelicula);
        List<Pelicula> GetAll();
        Pelicula GetById(int peliculaId);
    }
}
