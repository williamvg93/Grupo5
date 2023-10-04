using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;

public class Departamento : BaseEntiti
{
    public string Nombre { get; set; }
    public int IdClienteFk { get; set; }
    public Pais Paises { get; set; }
    public ICollection<Ciudad> Ciudades { get; set; }
}
