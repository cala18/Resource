using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class AdministradorConfiguration : IEntityTypeConfiguration<Administrador>
    {
        public void Configure(EntityTypeBuilder<Administrador> builder)
        {
            builder.HasKey(e => e.Id).HasName("PRIMARY");

            builder.ToTable("administrador");

            builder.HasIndex(e => e.ParticipanteId, "participante_id");

            builder.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            builder.Property(e => e.Contraseña)
                .HasMaxLength(255)
                .HasColumnName("contraseña");
            builder.Property(e => e.ParticipanteId).HasColumnName("participante_id");
            builder.Property(e => e.Registro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp")
                .HasColumnName("registro");

            builder.HasOne(d => d.Participante).WithMany(p => p.Administradors)
                .HasForeignKey(d => d.ParticipanteId)
                .HasConstraintName("administrador_ibfk_1");
        }
    }
}