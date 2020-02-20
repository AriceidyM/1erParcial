using Microsoft.EntityFrameworkCore;
using Parcial.Data;
using Parcial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Parcial.Controller
{
    public class InscripcionController
    {
        public bool Guardar(Inscripcion inscripcion)
        {
            Contexto db = new Contexto();
            bool paso = false;

            try
            {
                if (inscripcion.InscripcionId == 0)
                {
                    paso = Insertar(inscripcion);
                }
                else
                {
                    paso = Modificar(inscripcion);
                }
            }
            catch (Exception)
            {

                throw;
            }
            return paso;
        }

        private bool Insertar(Inscripcion inscripcion)
        {
            Contexto db = new Contexto();
            bool paso = false;

            db.Inscripcion.Add(inscripcion);
            paso = db.SaveChanges() > 0;

            return paso;
        }

        private bool Modificar(Inscripcion inscripcion)
        {
            Contexto db = new Contexto();
            bool paso = false;

            db.Inscripcion.Add(inscripcion).State = EntityState.Modified;
            paso = db.SaveChanges() > 0;

            return paso;
        }

        public Inscripcion Buscar(int id)
        {
            Contexto db = new Contexto();
            Inscripcion inscripcion = new Inscripcion();

            try
            {
                inscripcion = db.Inscripcion.Find(id);
            }
            catch (Exception)
            {

                throw;
            }
            return inscripcion;
        }

        public bool Eliminar(int id)
        {
            Contexto db = new Contexto();
            bool paso = false;
            Inscripcion inscripcion = new Inscripcion();

            try
            {
                inscripcion = db.Inscripcion.Find(id);
                db.Entry(inscripcion).State = EntityState.Deleted;

                paso = db.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;
            }

            return paso;
        }

        public List<Inscripcion> GetArticulos(Expression<Func<Inscripcion, bool>> expression)
        {
            List<Inscripcion> lista;
            Contexto db = new Contexto();
            try
            {
                lista = db.Inscripcion.Where(expression).ToList();
            }
            catch (Exception)
            {

                throw;
            }
            return lista;
        }
    }
}
