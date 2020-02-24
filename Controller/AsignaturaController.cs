﻿using Microsoft.EntityFrameworkCore;
using Parcial.Data;
using Parcial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Parcial.Controller
{
    public class AsignaturaController
    {
        public bool Guardar(Asignatura asignatura)
        {
            Contexto db = new Contexto();
            bool paso = false;

            try
            {
                if (asignatura.AsignaturaId == 0)
                {
                    paso = Insertar(asignatura);
                }
                else
                {
                    paso = Modificar(asignatura);
                }
            }
            catch (Exception)
            {

                throw;
            }
            return paso;
        }

        private bool Insertar(Asignatura asignatura)
        {
            Contexto db = new Contexto();
            bool paso = false;

            db.Asignatura.Add(asignatura);
            paso = db.SaveChanges() > 0;

            return paso;
        }

        private bool Modificar(Asignatura asignatura)
        {
            Contexto db = new Contexto();
            bool paso = false;

            db.Asignatura.Add(asignatura).State = EntityState.Modified;
            paso = db.SaveChanges() > 0;

            return paso;
        }

        public Asignatura Buscar(int id)
        {
            Contexto db = new Contexto();
            Asignatura asignatura = new Asignatura();

            try
            {
                asignatura = db.Asignatura.Find(id);
            }
            catch (Exception)
            {

                throw;
            }
            return asignatura;
        }

        public bool Eliminar(int id)
        {
            Contexto db = new Contexto();
            bool paso = false;
            Asignatura asignatura = new Asignatura();

            try
            {
                asignatura = db.Asignatura.Find(id);
                db.Entry(asignatura).State = EntityState.Deleted;

                paso = db.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;
            }

            return paso;
        }

        public List<Asignatura> GetAsignatura(Expression<Func<Asignatura, bool>> expression)
        {
            List<Asignatura> lista;
            Contexto db = new Contexto();
            try
            {
                lista = db.Asignatura.Where(expression).ToList();
            }
            catch (Exception)
            {

                throw;
            }
            return lista;
        }
    }
}
