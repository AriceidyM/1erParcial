using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parcial.Models
{
    public class Inscripcion
    {
        public int InscripcionId { get; set; }
        public string Semestre { get; set; }
        public string Limite { get; set; }
        public string Tomados { get; set; }
        public int Dispoibles { get; set; }

        public Inscripcion()
        {
            InscripcionId = 0;
            Semestre = string.Empty;
            Limite = string.Empty;
            Tomados = string.Empty;
            Dispoibles = 0;
        }

    }
}
