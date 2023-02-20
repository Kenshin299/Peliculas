using System;

namespace Peliculas.DAL.Core
{
    public abstract class BaseEntity
    {
        public BaseEntity()
        {
            this.Fecha = DateTime.Now;
        }

        public DateTime Fecha { get; set; }
        public float Precio { get; set; }


    }
}