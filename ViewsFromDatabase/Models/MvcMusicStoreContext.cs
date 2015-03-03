using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ViewsFromDatabase.Models
{
    public class MvcMusicStoreContext : DbContext
    {
        public MvcMusicStoreContext()
            : base("Name=MvcMusicStoreContext")
        {
        }


        public DbSet<Artist> Artist { get; set; }
        public DbSet<Views> Views { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
