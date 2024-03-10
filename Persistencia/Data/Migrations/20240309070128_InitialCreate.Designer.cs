﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistencia;

#nullable disable

namespace Persistencia.Data.Migrations
{
    [DbContext(typeof(Prueba4CContext))]
    [Migration("20240309070128_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Persistencia.Administrador", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Contraseña")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("contraseña");

                    b.Property<int?>("ParticipanteId")
                        .HasColumnType("int")
                        .HasColumnName("participante_id");

                    b.Property<DateTime?>("Registro")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp")
                        .HasColumnName("registro")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "ParticipanteId" }, "participante_id");

                    b.ToTable("administrador", (string)null);
                });

            modelBuilder.Entity("Persistencia.Direccionparticipante", b =>
                {
                    b.Property<int>("ParticipanteId")
                        .HasColumnType("int")
                        .HasColumnName("participante_id");

                    b.Property<string>("Direccion")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("direccion");

                    b.HasKey("ParticipanteId")
                        .HasName("PRIMARY");

                    b.ToTable("direccionparticipante", (string)null);
                });

            modelBuilder.Entity("Persistencia.Participante", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("CorreoElectronico")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("correo_electronico");

                    b.Property<DateOnly>("FechaNacimiento")
                        .HasColumnType("date")
                        .HasColumnName("fecha_nacimiento");

                    b.Property<byte[]>("ImagenRegistro")
                        .HasColumnType("longblob")
                        .HasColumnName("imagenRegistro");

                    b.Property<string>("NombresApellidos")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("nombres_apellidos");

                    b.Property<string>("NumeroDocumento")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("numero_documento");

                    b.Property<string>("Telefono")
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)")
                        .HasColumnName("telefono");

                    b.Property<int?>("TipoDocumentoId")
                        .HasColumnType("int")
                        .HasColumnName("tipo_documento_id");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "CorreoElectronico" }, "correo_electronico")
                        .IsUnique();

                    b.HasIndex(new[] { "TipoDocumentoId" }, "tipo_documento_id");

                    b.ToTable("participante", (string)null);
                });

            modelBuilder.Entity("Persistencia.Tipodocumento", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Nacionalidad")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("nacionalidad");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("tipo");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.ToTable("tipodocumento", (string)null);
                });

            modelBuilder.Entity("Persistencia.Administrador", b =>
                {
                    b.HasOne("Persistencia.Participante", "Participante")
                        .WithMany("Administradors")
                        .HasForeignKey("ParticipanteId")
                        .HasConstraintName("administrador_ibfk_1");

                    b.Navigation("Participante");
                });

            modelBuilder.Entity("Persistencia.Direccionparticipante", b =>
                {
                    b.HasOne("Persistencia.Participante", "Participante")
                        .WithOne("Direccionparticipante")
                        .HasForeignKey("Persistencia.Direccionparticipante", "ParticipanteId")
                        .IsRequired()
                        .HasConstraintName("direccionparticipante_ibfk_1");

                    b.Navigation("Participante");
                });

            modelBuilder.Entity("Persistencia.Participante", b =>
                {
                    b.HasOne("Persistencia.Tipodocumento", "TipoDocumento")
                        .WithMany("Participantes")
                        .HasForeignKey("TipoDocumentoId")
                        .HasConstraintName("participante_ibfk_1");

                    b.Navigation("TipoDocumento");
                });

            modelBuilder.Entity("Persistencia.Participante", b =>
                {
                    b.Navigation("Administradors");

                    b.Navigation("Direccionparticipante");
                });

            modelBuilder.Entity("Persistencia.Tipodocumento", b =>
                {
                    b.Navigation("Participantes");
                });
#pragma warning restore 612, 618
        }
    }
}