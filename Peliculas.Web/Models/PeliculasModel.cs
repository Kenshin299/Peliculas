namespace Peliculas.Web.Models
{
    public class PeliculasModel
    {
        public int Id { get; set; }
        public string NombrePelicula { get; set; }
        public int DisponiblesAlquiler { get; set; }
        public int DisponiblesVenta { get; set; }
        public float PrecioAlquiler { get; set; }
        public float PrecioVenta { get; set; }
    }
}
