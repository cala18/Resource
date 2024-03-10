using System;
using System.Collections.Generic;

namespace Persistencia;

public partial class Direccionparticipante
{
    public int ParticipanteId { get; set; }

    public string? Direccion { get; set; }

    public virtual Participante Participante { get; set; } = null!;
}
