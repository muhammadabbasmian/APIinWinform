using Microsoft.EntityFrameworkCore;

namespace APIinWinform.Models
{
    public class DataBasecontext: DbContext
    {
        public DataBasecontext(DbContextOptions<DataBasecontext> options) : base(options)
        {
        }
        public DbSet<student> students { get; set; }
    }
}
