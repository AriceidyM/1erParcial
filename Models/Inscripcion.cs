using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Parcial.Models
{
    public class Inscripcion
    {
        [Key]
        public int InscripcionId { get; set; }

        [Required(ErrorMessage = "Semestre no puede estar vacio")]
        public string Semestre { get; set; }

        [Required]
        [Range(minimum: 1, maximum: 27, ErrorMessage = "Credito muy elevados, colocar un  maximo de 27")]
        public int Limite { get; set; }

        [Required]
        [Range(minimum: 1, maximum: 27, ErrorMessage = "El limite de creditos es 27")]
        public int Tomados { get; set; }
        public int Dispoibles { get; set; }

        public Inscripcion()
        {
            InscripcionId = 0;
            Semestre = string.Empty;
            Limite = 0;
            Tomados = 0;
            Dispoibles = 0;
        }

    }
}
