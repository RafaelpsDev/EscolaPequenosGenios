using EscolaPequenosGenios.Domain.Entities;
using EscolaPequenosGenios.Infrastructure.Configurations;
using Microsoft.EntityFrameworkCore;

namespace EscolaPequenosGenios.Repository.Context
{
    public class EscolaPequenosGeniosContext : DbContext

    {
        public EscolaPequenosGeniosContext(DbContextOptions<EscolaPequenosGeniosContext> options) : base(options)
        {
            
        }
        public DbSet<UsuarioEntity> TB_USUARIOS { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UsuarioEntity>().
                ToTable(u => u.HasCheckConstraint("CK_Setor_ValidValues", "[Setor] IN ('Secretaria', 'Adm')"));
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
