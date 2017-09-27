using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DAL;
using System.Linq.Expressions;

namespace BLL
{
    public class PresupuestosBll
    {
        public static bool Guardar(Presupuestos presupuestos)
        {
            using (var reposi = new Repositorio<Presupuestos>())
            {
                try
                {
                    if (Buscar(p => p.PresupuestoId == presupuestos.PresupuestoId) == null)
                    {
                        return reposi.Guardar(presupuestos);
                    }
                    else
                    {
                        return reposi.Modificar(presupuestos);
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public static bool Modificar(Presupuestos presupuestos)
        {
            bool modifica = false;
            using (var reposi = new Repositorio<Presupuestos>())
            {
                modifica = reposi.Modificar(presupuestos);
            }

            return modifica;
        }

        public static bool Eliminar(Presupuestos presupuestos)
        {
            bool eliminado = false;
            using (var reposi = new Repositorio<Presupuestos>())
            {
                eliminado = reposi.Eliminar(presupuestos);
            }
            return eliminado;
        }

        public static Presupuestos Buscar(Expression<Func<Entidades.Presupuestos, bool>> Busqueda)
        {
            Presupuestos Result = null;
            using (var repoitorio = new Repositorio<Presupuestos>())
            {
                Result = repoitorio.Buscar(Busqueda);
            }
            return Result;
        }

        public static List<Presupuestos> Listar(Expression<Func<Presupuestos, bool>> busqueda)
        {
            List<Presupuestos> Result = null;
            using (var repoitorio = new Repositorio<Presupuestos>())
            {
                try
                {
                    Result = repoitorio.Lista(busqueda).ToList();
                }
                catch
                {

                }
                return Result;
            }
        }

        public static List<Presupuestos> ListarTodo()
        {
            List<Presupuestos> Result = null;
            using (var repoitorio = new Repositorio<Presupuestos>())
            {
                try
                {
                    Result = repoitorio.ListaGet().ToList();
                }
                catch { }
                return Result;
            }
        }
    }
}
