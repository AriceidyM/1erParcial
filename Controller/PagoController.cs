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
    public class PagoController
    {
        public bool Guardar(Pagos Pagos)
        {
            Contexto db = new Contexto();
            bool paso = false;

            try
            {
                if (Pagos.PagoId == 0)
                {
                    paso = Insertar(Pagos);
                }
                else
                {
                    paso = Modificar(Pagos);
                }
            }
            catch (Exception)
            {

                throw;
            }
            return paso;
        }

        private bool Insertar(Pagos pagos)
        {
            Contexto db = new Contexto();
            bool paso = false;

            db.Pagos.Add(pagos);
            paso = db.SaveChanges() > 0;

            return paso;
        }

        private bool Modificar(Pagos pagos)
        {
            Contexto db = new Contexto();
            bool paso = false;

            db.Pagos.Add(pagos).State = EntityState.Modified;
            paso = db.SaveChanges() > 0;

            return paso;
        }

        public Pagos Buscar(int id)
        {
            Contexto db = new Contexto();
            Pagos pagos = new Pagos();

            try
            {
                pagos = db.Pagos.Find(id);
            }
            catch (Exception)
            {

                throw;
            }
            return pagos;
        }

        public bool Eliminar(int id)
        {
            Contexto db = new Contexto();
            bool paso = false;
            Pagos pagos = new Pagos();

            try
            {
                pagos = db.Pagos.Find(id);
                db.Entry(pagos).State = EntityState.Deleted;

                paso = db.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;
            }

            return paso;
        }

        public List<Pagos> GetPagos(Expression<Func<Pagos, bool>> expression)
        {
            List<Pagos> lista;
            Contexto db = new Contexto();
            try
            {
                lista = db.Pagos.Where(expression).ToList();
            }
            catch (Exception)
            {

                throw;
            }
            return lista;
        }
    }
}
