namespace Peliculas.Web.Models
{
    public class AlquilerPeliculasModel
    {
        public int Id { get; set; }
        public int IdPeliculas { get; set; }
        public int IdUsuario { get; set; }
        public float Precio { get; set; }
        public DateTime Fecha { get; set; }
        public bool Devuelta { get; set; }
        public DateTime FechaDevolucion { get; set; }
        public int IdUsuarioDevolucion { get; set; }
    }
}
