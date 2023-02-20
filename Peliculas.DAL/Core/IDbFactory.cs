using Microsoft.EntityFrameworkCore;

namespace Peliculas.DAL.Core
{
    public class IDbFactory
    {
        DbContext GetDbContext { get; }
    }
}
