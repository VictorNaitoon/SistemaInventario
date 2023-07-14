using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.AccesoDatos.Repositorio.IRepositorio
{
    public interface IRepositorio<T> where T : class
    {
        //Para hacer los métodos asincronos ponemos el Task, menos para los métodos Remover
        Task<T> Obtener(int id);
        Task<IEnumerable<T>> ObtenerTodos(
            Expression<Func<T, bool>> filtro = null,    //Recibe una expresio que funciona como filtro para empezar a filtrar la lista
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, //Ordena la lista. 
            string incluirPropiedades = null, // este se encarga de hacer todos los enlaces con otros objetos
            bool isTracking = true //Esto es cuando querramos acceder a un objeto o una lista de objetos y al mismo tiempo lo queremos modificar
            //Siempre será true pero cuando sea false es cuando estemos trabajando con el mismo objeto
            );
        Task<T> ObtenerPrimero(
            Expression<Func<T, bool>> filtro = null,
            string incluirPropiedades = null,
            bool isTracking = true
            );
        Task Agregar(T entidad);
        void Remover(T entidad);
        void RemoverRango(IEnumerable<T> entidad);

    }
}
