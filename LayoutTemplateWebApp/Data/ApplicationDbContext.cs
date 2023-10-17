using LayoutTemplateWebApp.Model;
using Microsoft.EntityFrameworkCore;

namespace LayoutTemplateWebApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Event> Event { get; set; } // DbSet para la entidad Event
        // Agrega otros DbSet para las demás entidades de tu modelo aquí
    }
}
