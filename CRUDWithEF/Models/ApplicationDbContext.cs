using Microsoft.EntityFrameworkCore;

namespace CRUDWithEF.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }
        // fetch the data from DB & store at application side
        // Dbset will translate LINQ quries in the SQL & fire in the DB
        public DbSet<Book> Books { get; set; }
    }
}
