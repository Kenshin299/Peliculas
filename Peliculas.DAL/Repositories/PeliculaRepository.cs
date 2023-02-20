using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.Logging;
using Peliculas.DAL.Context;
using Peliculas.DAL.Entities;
using Peliculas.DAL.Exceptions;
using Peliculas.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Peliculas.DAL.Repositories
{
    public class PeliculaRepository : IPeliculaRepository
    {
        private readonly PeliculasContext context;
        private readonly ILogger<PeliculaRepository> logger;
        public PeliculaRepository(PeliculasContext context, ILogger<PeliculaRepository> logger)  
        {
            this.context = context;
            this.logger = logger;
        }
        public void Add(Pelicula pelicula)
        {
            try
            {
                if (this.context.Peliculas.Any(cd => cd.CodePelicula == pelicula.CodePelicula)) 
                {
                    throw new PeliculasException("La pelicula ya se encuentra registrada");
                }
                this.context.Peliculas.Add(pelicula);
                this.context.SaveChanges();
            }
            catch (Exception ex)
            {
                this.logger.LogError($"Ha ocurrido un error: {ex.Message}", ex.ToString());
            }
        }

        public List<Pelicula> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Pelicula GetById(int peliculaId)
        {
            throw new System.NotImplementedException();
        }

        public void Remove(Pelicula pelicula)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Pelicula pelicula)
        {
            throw new System.NotImplementedException();
        }
    }
}
