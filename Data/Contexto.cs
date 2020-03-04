using Microsoft.EntityFrameworkCore;
using Parcial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parcial.Data
{
    public class Contexto: DbContext
    {
        public DbSet<Pagos> Pagos { get; set; }
        public DbSet<Estudiantes> Estudiantes { get; set; }
        public DbSet<Asignatura> Asignatura { get; set; }
        public DbSet<Inscripcion> Inscripcion { get; set; }
        public DbSet<InscripcionDetalle> InscripcionDetalles { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source= Database/Parcial.db");
        }
    }
}
