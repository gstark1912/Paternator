using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dominio.Resources
{
    /// <summary>
    /// El propósito de esta clase, es del envío de los parámetros necesarios para una búsqueda con paginado.    
    /// </summary>
    public class PagedDataParameters
    {
        private string _orderField;
        private Enums.OrderBy _orderDirection;
        private int _page;
        private int _rows;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="orderfield">Campo de Orden </param>
        /// <param name="orderdirection">Tipo de Orden</param>
        /// <param name="page">Cantidad de Paginas</param>
        /// <param name="rows">Cantidad de Filas por Pagina</param>
        public PagedDataParameters(string orderfield, Enums.OrderBy orderdirection, int page, int rows)
        {
            _rows = rows;
            _page = page;
            _orderDirection = orderdirection;
            _orderField = orderfield;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="orderfield">Campo de Orden </param>
        /// <param name="orderdirection">Tipo de Orden</param>
        public PagedDataParameters(string orderfield, Enums.OrderBy orderdirection)
        {
            _orderDirection = orderdirection;
            _orderField = orderfield;
        }

        /// <summary>
        /// Campo por el cual se realizara el orden
        /// </summary>
        public string OrderField
        {
            get
            { return _orderField; }
        }

        public Enums.OrderBy OrderDirection
        {
            get
            { return _orderDirection; }
        }

        /// <summary>
        /// Cantidad de Paginas
        /// </summary>
        public int Page
        {
            get
            { return _page; }
        }

        /// <summary>
        /// Cantidad de Filas por Pagina
        /// </summary>
        public int Rows
        {
            get
            { return _rows; }
        }
    }
}
