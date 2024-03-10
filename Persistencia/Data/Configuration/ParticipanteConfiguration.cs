using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class ParticipanteConfiguration : IEntityTypeConfiguration<Participante>
    {
        public void Configure(EntityTypeBuilder<Participante> builder)
        {
            builder.HasKey(e => e.Id).HasName("PRIMARY");

            builder.ToTable("participante");

            builder.HasIndex(e => e.CorreoElectronico, "correo_electronico").IsUnique();

            builder.HasIndex(e => e.TipoDocumentoId, "tipo_documento_id");

            builder.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            builder.Property(e => e.CorreoElectronico)
                .HasMaxLength(100)
                .HasColumnName("correo_electronico");
            builder.Property(e => e.FechaNacimiento).HasColumnName("fecha_nacimiento");
            builder.Property(e => e.ImagenRegistro).HasColumnName("imagenRegistro");
            builder.Property(e => e.NombresApellidos)
                .HasMaxLength(100)
                .HasColumnName("nombres_apellidos");
            builder.Property(e => e.NumeroDocumento)
                .HasMaxLength(20)
                .HasColumnName("numero_documento");
            builder.Property(e => e.Telefono)
                .HasMaxLength(15)
                .HasColumnName("telefono");
            builder.Property(e => e.TipoDocumentoId).HasColumnName("tipo_documento_id");

            builder.HasOne(d => d.TipoDocumento).WithMany(p => p.Participantes)
                .HasForeignKey(d => d.TipoDocumentoId)
                .HasConstraintName("participante_ibfk_1");
        }
    }
}