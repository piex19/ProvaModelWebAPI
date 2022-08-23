﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PatrimonioSenaiTaguatinga.Entities;

namespace PatrimonioSenaiTaguatinga.EntityConfiguration
{
    public class NivelConfiguration : IEntityTypeConfiguration<Nivel>
    {
        public void Configure(EntityTypeBuilder<Nivel> builder)
        {
            builder.ToTable("Nivel");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).IsRequired().HasMaxLength(50);
            
        }
    }
}
