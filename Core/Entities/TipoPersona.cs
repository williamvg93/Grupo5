using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;

public class TipoPersona : BaseEntiti
{
    public string Descripcion { get; set; }
    public ICollection<Persona> MyProperty { get; set; }
}
