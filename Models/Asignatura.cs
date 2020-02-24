using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Parcial.Models
{
    public class Asignatura
    {
        [Key]

        public int AsignaturaId { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public int PreRequisito { get; set; }
        public int Creditos { get; set; }

        public Asignatura()
        {
            AsignaturaId = 0;
            Codigo = string.Empty;
            Descripcion = string.Empty;
            PreRequisito = 0;
            Creditos = 0;
        }
    }
}
