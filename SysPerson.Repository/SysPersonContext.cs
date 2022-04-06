using SysPerson.Domain.Entities;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace SysPerson.Repository
{
    public sealed class SysPersonContext : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Configurations.Add(new EntityTypeConfiguration<Pessoa>());

            base.OnModelCreating(modelBuilder);
        }

        public SysPersonContext() : base("SqlServer")
        {
            
        }
    }
}
