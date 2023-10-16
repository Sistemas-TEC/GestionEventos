using Microsoft.EntityFrameworkCore;

namespace LayoutTemplateWebApp.DbContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Event> Events { get; set; } // DbSet para la entidad Event
        // Agrega otros DbSet para las demás entidades de tu modelo aquí
    }
}
