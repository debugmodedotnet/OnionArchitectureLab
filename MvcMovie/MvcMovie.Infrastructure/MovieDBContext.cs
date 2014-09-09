using MvcMovie.Core;
using System.Data.Entity;

namespace MvcMovie.Infrastructure
{
    public class MovieDBContext : DbContext
    {

        public DbSet<Movie> Movies { get; set; }

    }
}
