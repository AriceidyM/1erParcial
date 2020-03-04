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
    public class EstudianteController
    {
        public bool Guardar(Estudiantes Estudiantes)
        {
            Contexto db = new Contexto();
            bool paso = false;

            try
            {
                if (Estudiantes.EstudianteId == 0)
                {
                    paso = Insertar(Estudiantes);
                }
                else
                {
                    paso = Modificar(Estudiantes);
                }
            }
            catch (Exception)
            {

                throw;
            }
            return paso;
        }

        private bool Insertar(Estudiantes Estudiantes)
        {
            Contexto contexto = new Contexto();
            bool paso = false;

            try
            {
                contexto.Estudiantes.Add(Estudiantes);
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        private bool Modificar(Estudiantes Estudiantes)
        {
            Contexto contexto = new Contexto();
            bool paso = false;

            try
            {
                contexto.Estudiantes.Add(Estudiantes);
                contexto.Entry(Estudiantes).State = EntityState.Modified;
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        public Estudiantes Buscar(int id)
        {
            Contexto db = new Contexto();
            Estudiantes estudiantes = new Estudiantes();

            try
            {
                estudiantes = db.Estudiantes.Find(id);
            }
            catch (Exception)
            {

                throw;
            }
            return estudiantes;
        }

        public bool Eliminar(int id)
        {
            Contexto db = new Contexto();
            bool paso = false;
            Estudiantes estudiantes = new Estudiantes();

            try
            {
                estudiantes = db.Estudiantes.Find(id);
                db.Entry(estudiantes).State = EntityState.Deleted;
                paso = db.SaveChanges() > 0;

            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        public List<Estudiantes> GetEstudiantes(Expression<Func<Estudiantes, bool>> expression)
        {
            List<Estudiantes> lista;
            Contexto db = new Contexto();
            try
            {
                lista = db.Estudiantes.Where(expression).ToList();
            }
            catch (Exception)
            {

                throw;
            }
            return lista;
        }
    }
}
