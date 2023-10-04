using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;

public class Persona
{
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public ICollection<Matricula> Matriculas { get; set; }
}
