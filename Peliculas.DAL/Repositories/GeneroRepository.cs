using Generos.DAL.Interfaces;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.Logging;
using Peliculas.DAL.Context;
using Peliculas.DAL.Entities;
using Peliculas.DAL.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Peliculas.DAL.Repositories
{
    public class GeneroRepository : IGeneroRepository
    {
        private readonly PeliculasContext context;
        private readonly ILogger<GeneroRepository> logger;
        public GeneroRepository(PeliculasContext context, ILogger<GeneroRepository> logger)
        {
            this.context = context;
            this.logger = logger;
        }
        public void Add(Genero genero)
        {
            try
            {
                if (this.context.Generos.Any(cd => cd.CodeGenero == genero.CodeGenero))
                {
                    throw new PeliculasException("El genero ya se encuentra registrado");
                }
                this.context.Generos.Add(genero);
                this.context.SaveChanges();
            }
            catch (Exception ex)
            {
                this.logger.LogError($"Ha ocurrido un error: {ex.Message}", ex.ToString());
            }
        }

        public List<Genero> GetAll()
        {
            throw new NotImplementedException();
        }

        public Genero GetById(int generoId)
        {
            throw new NotImplementedException();
        }

        public void Remove(Genero genero)
        {
            throw new NotImplementedException();
        }

        public void Update(Genero genero)
        {
            throw new NotImplementedException();
        }
    }
}
