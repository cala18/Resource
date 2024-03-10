using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace Persistencia.Data.Configuration
{
    public class TipoDocumentoConfiguration : IEntityTypeConfiguration<Tipodocumento>
    {
        public void Configure(EntityTypeBuilder<Tipodocumento> builder)
        {
            builder.HasKey(e => e.Id).HasName("PRIMARY");

            builder.ToTable("tipodocumento");

            builder.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            builder.Property(e => e.Nacionalidad)
                .HasMaxLength(50)
                .HasColumnName("nacionalidad");
            builder.Property(e => e.Tipo)
                .HasMaxLength(50)
                .HasColumnName("tipo");
        }
    }
}