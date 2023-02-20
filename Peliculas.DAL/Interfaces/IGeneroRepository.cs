using Peliculas.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Generos.DAL.Interfaces
{
    public interface IGeneroRepository
    {
        void Add(Genero genero);
        void Remove (Genero genero);
        void Update(Genero genero);
        List<Genero> GetAll();
        Genero GetById(int generoId);
    }
}
