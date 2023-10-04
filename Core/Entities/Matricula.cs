using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;

public class Matricula : BaseEntiti
{
    public string Nombre { get; set; }
    public ICollection<Salon> Salones { get; set; }
}
