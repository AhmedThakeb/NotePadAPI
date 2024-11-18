using Microsoft.EntityFrameworkCore;
using NotePad.Entities;

namespace NotePad.Data
{
    public class ApplicationDbContext : DbContext
    {
        

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Note> Notes { get; set; }
    }
}
