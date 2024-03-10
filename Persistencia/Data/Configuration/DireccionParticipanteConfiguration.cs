using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class DireccionParticipanteConfiguration : IEntityTypeConfiguration<Direccionparticipante>
    {
        public void Configure(EntityTypeBuilder<Direccionparticipante> builder)
        {
            builder.HasKey(e => e.ParticipanteId).HasName("PRIMARY");

            builder.ToTable("direccionparticipante");

            builder.Property(e => e.ParticipanteId)
                .ValueGeneratedNever()
                .HasColumnName("participante_id");
            builder.Property(e => e.Direccion)
                .HasMaxLength(255)
                .HasColumnName("direccion");

            builder.HasOne(d => d.Participante).WithOne(p => p.Direccionparticipante)
                .HasForeignKey<Direccionparticipante>(d => d.ParticipanteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("direccionparticipante_ibfk_1");
        }
    }
}