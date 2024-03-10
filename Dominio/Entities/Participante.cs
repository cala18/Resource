using System;
using System.Collections.Generic;

namespace Persistencia;

public partial class Participante
{
    public int Id { get; set; }

    public int? TipoDocumentoId { get; set; }

    public string NumeroDocumento { get; set; } = null!;

    public string NombresApellidos { get; set; } = null!;

    public DateOnly FechaNacimiento { get; set; }

    public string? Telefono { get; set; }

    public string CorreoElectronico { get; set; } = null!;

    public byte[]? ImagenRegistro { get; set; }

    public virtual ICollection<Administrador> Administradors { get; set; } = new List<Administrador>();

    public virtual Direccionparticipante? Direccionparticipante { get; set; }

    public virtual Tipodocumento? TipoDocumento { get; set; }
}
