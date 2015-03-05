using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dominio.Resources
{
    /// <summary>
    /// Esta propósito de esta clase es el envío del resultado de una búsqueda por paginado.
    /// </summary>    
    public class PagedDataResult<T>
    {
        private List<T> _results;
        private int _count;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="list">Lista de Resultados</param>
        /// <param name="count">Total de filas en la consulta</param>
        public PagedDataResult(List<T> list, int count)
        {
            this._results = list;
            this._count = count;
        }

        /// <summary>
        /// Listado de una Entidad utilizado como resultado de la búsqueda
        /// </summary>
        public List<T> Results
        {
            get
            {
                return _results;
            }
        }

        /// <summary>
        /// Total de filas contenidas en la consulta, más allá del paginado impuesto
        /// </summary>
        public int TotalCount
        {
            get
            {
                return _count;
            }
        }
    }
}
