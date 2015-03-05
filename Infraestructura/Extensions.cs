using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Dominio.Resources;

namespace Infraestructura
{
    public static class Extensions
    {
        public static IQueryable<T> IncludeMultiple<T>(this IQueryable<T> query, params Expression<Func<T, object>>[] includes) where T : class
        {
            if (includes != null)
            {
                query = includes.Aggregate(query,
                          (current, include) => current.Include(include));
            }

            return query;
        }

        /// <summary>
        /// A partir de un IQueryable aplicado a una entidad definida, se aplica la estrategia de Paginado
        /// y se devuelve la misma query con el agregado del paginado.
        /// </summary>        
        public static IQueryable<T> PagedData<T>(this IQueryable<T> query, PagedDataParameters parameters) where T : class
        {
            return new StrategyPagedData(parameters).ApplyStrategy(query);
        }
    }
}
