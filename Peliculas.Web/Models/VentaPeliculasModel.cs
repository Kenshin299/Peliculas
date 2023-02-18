namespace Peliculas.Web.Models
{
    public class VentaPeliculasModel
    {
        public int Id { get; set; }
        public int IdPeliculas { get; set; }
        public int IdUsuario { get; set; }
        public float Precio { get; set; }
        public DateTime Fecha { get; set; }
    }
}
