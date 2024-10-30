using Microsoft.EntityFrameworkCore;

namespace AnyApi.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }
    }
}