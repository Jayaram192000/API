using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using timer_2.Models;

namespace timer_2.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        {
            
        }

        public DbSet<User> tblUser { get; set; }
    }
}
