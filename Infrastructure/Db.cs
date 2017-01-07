using SelectListExample.Business;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace SelectListExample.Infrastructure
{
    public class Db : DbContext
    {
        public IDbSet<UnsoldReason> UnsoldReasons { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.HasDefaultSchema("dbo");
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Entity<UnsoldReason>().Property(x => x.Id);
            modelBuilder.Entity<UnsoldReason>().HasKey(x => new { x.Id });
        }
    }
}
