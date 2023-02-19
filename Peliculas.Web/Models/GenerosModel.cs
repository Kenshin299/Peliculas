using Peliculas.Web.Exceptions;

namespace Peliculas.Web.Models
{
    public class GenerosModel
    {
        public int Id { get; set; }
        public string generos;
        public string Generos
        {
            get { return this.generos; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new PeliculasExecption("Este campo es requerido");
                }
                else if (value.Length > 50)
                {
                    throw new PeliculasExecption("La longitud del nombre es muy largo");
                }
                else
                {
                    this.generos = value;
                }
            }
        }
    }
}
