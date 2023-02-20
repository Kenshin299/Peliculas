using Microsoft.EntityFrameworkCore;
using Peliculas.DAL.Context;
using Peliculas.DAL.Core;
using System;

namespace Peliculas.DAL.DbFactory
{
    public class DbFactory : IDbFactory, IDisposable
    {
        private readonly PeliculasContext peliculasContext;

        public DbFactory(PeliculasContext peliculasContext) => this.peliculasContext = peliculasContext;
        private bool isDisposed;
        public DbContext GetDbContext => this.peliculasContext;
        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }
        public void Dispose(bool disposing)
        {
            if (!this.isDisposed)
            {
                if (this.peliculasContext != null) 
                {
                    this.peliculasContext.Dispose();
                }

            }
            this.isDisposed = true;
        }
    }
}
