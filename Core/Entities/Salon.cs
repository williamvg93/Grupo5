using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;

public class Salon : BaseEntiti
{
    public string Nombre { get; set; }
    public int Capacidad { get; set; }
    public int IdMatriculaFk { get; set; }
    public Matricula Matriculas { get; set; }

}
