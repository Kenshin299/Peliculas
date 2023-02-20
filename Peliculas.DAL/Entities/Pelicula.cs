using Peliculas.DAL.Core;

namespace Peliculas.DAL.Entities
{
    public class Pelicula : Products
    {
        public int CodePelicula { get; set; }
        public int CantidadAlquiler { get; set; }
        public int CantidadVenta { get; set; }
    }
}
