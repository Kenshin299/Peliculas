namespace Peliculas.Web.Exceptions
{
    public class PeliculasExecption : Exception
    {
        public PeliculasExecption( string message ) : base(message)
        {
            Console.WriteLine(message);
        }
    }
}
