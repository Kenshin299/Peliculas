using Peliculas.Web.Exceptions;

namespace Peliculas.Web.Models
{
    public class PeliculasModel
    {
        public int Id;
        public string nombrePelicula;
        public string NombrePelicula 
        { 
            get { return this.nombrePelicula; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new PeliculasExecption("Este campo es requerido");
                }
                else if (value.Length > 500)
                {
                    throw new PeliculasExecption("La longitud del nombre es muy largo");
                }
                else
                {
                    this.nombrePelicula = value;
                }
            } 
        }
        public int DisponiblesAlquiler { get; set; }
        public int DisponiblesVenta { get; set; }
        public float PrecioAlquiler { get; set; }
        public float PrecioVenta { get; set; }
    }
}
