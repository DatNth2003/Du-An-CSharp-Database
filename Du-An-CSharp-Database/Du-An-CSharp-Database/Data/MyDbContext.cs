using Microsoft.EntityFrameworkCore;

namespace Du_An_CSharp_Database.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions options) : base(options) { }
        #region[Database Set]
        public DbSet<Users> Users { get; set; }
        #endregion
    }
}
