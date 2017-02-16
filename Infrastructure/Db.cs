using SelectListExample.Business;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Business;

namespace SelectListExample.Infrastructure
{
    public class Db : DbContext
    {
        public IDbSet<UnsoldReason> UnsoldReasons { get; set; }
        public IDbSet<UserLocationUnit> UserLocationUnits { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.HasDefaultSchema("dbo");
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Entity<UnsoldReason>().Property(x => x.Id);
            modelBuilder.Entity<UnsoldReason>().HasKey(x => new { x.Id });
            modelBuilder.Entity<UserLocationUnit>().Property(x => x.Id).HasColumnName("UserLocationUnitId");
            modelBuilder.Entity<UserLocationUnit>().HasKey(x => new { x.Id});

        }
    }
}
