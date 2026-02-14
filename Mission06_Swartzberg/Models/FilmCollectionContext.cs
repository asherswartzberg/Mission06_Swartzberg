using Microsoft.EntityFrameworkCore;

namespace Mission06_Swartzberg.Models
{
    public class FilmCollectionContext : DbContext
    {
        public FilmCollectionContext(DbContextOptions<FilmCollectionContext> options) : base(options) { }
        public DbSet<Movie> Movies { get; set; }
    }
}
