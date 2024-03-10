using System;
using System.Collections.Generic;

namespace Persistencia;

public partial class Administrador
{
    public int Id { get; set; }

    public string Contraseña { get; set; } = null!;

    public DateTime? Registro { get; set; }

    public int? ParticipanteId { get; set; }

    public virtual Participante? Participante { get; set; }
}
