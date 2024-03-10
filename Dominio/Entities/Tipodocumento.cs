using System;
using System.Collections.Generic;

namespace Persistencia;

public partial class Tipodocumento
{
    public int Id { get; set; }

    public string Tipo { get; set; } = null!;

    public string Nacionalidad { get; set; } = null!;

    public virtual ICollection<Participante> Participantes { get; set; } = new List<Participante>();
}
