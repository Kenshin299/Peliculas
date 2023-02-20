using System;
using System.Collections.Generic;
using System.Text;

namespace Peliculas.DAL.Exceptions
{
    public class PeliculasException : Exception
    {
        public PeliculasException(string message) : base(message) 
        { 
            Console.WriteLine(message);
        }
    }
}
