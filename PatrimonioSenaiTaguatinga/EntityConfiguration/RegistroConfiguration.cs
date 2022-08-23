using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PatrimonioSenaiTaguatinga.Entities;

namespace PatrimonioSenaiTaguatinga.EntityConfiguration
{
    public class RegistroConfiguration : IEntityTypeConfiguration<Registro>
    {
        public void Configure(EntityTypeBuilder<Registro> builder)
        {
            builder.ToTable("Registro");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Sobrenome).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Login).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Password).IsRequired().HasMaxLength(50);
            builder.Property(x => x.IdNivel).IsRequired();
            builder.HasOne(x => x.Nivel).WithMany(x => x.Registro).HasForeignKey(x => x.IdNivel);
        }
    }
}
