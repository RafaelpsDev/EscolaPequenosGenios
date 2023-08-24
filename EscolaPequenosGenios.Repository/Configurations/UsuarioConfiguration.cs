using EscolaPequenosGenios.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EscolaPequenosGenios.Infrastructure.Configurations
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<UsuarioEntity>
    {
        public void Configure(EntityTypeBuilder<UsuarioEntity> builder)
        {
            builder.HasKey(u => u.Id);            
            builder.Property(u => u.Cpf).IsRequired().HasMaxLength(20).HasColumnName("CPF").HasColumnType("VARCHAR(20)");
            builder.Property(u => u.Usuario).IsRequired().HasMaxLength(20).HasColumnName("USUARIO").HasColumnType("VARCHAR(20)");
            builder.Property(u => u.Nome).IsRequired().HasMaxLength(100).HasColumnName("NOME").HasColumnType("VARCHAR(100)");
            builder.Property(u => u.Senha).IsRequired().HasColumnName("SENHA").HasColumnType("VARCHAR(150)");
            builder.Property(u => u.Setor).IsRequired().HasMaxLength(20).HasColumnName("SETOR").HasColumnType("VARCHAR(20)");
        }
    }
}
