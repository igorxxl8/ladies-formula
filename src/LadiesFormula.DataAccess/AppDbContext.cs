using Microsoft.EntityFrameworkCore;

namespace LadiesFormula.DataAccess
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
    }
}
