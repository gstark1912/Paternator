using Dominio.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Repositorios
{
    public interface IEmpresaRepositorio : IRepositorio<Empresa>
    {
        PagedDataResult<Empresa> GetPagedByDescription(string desc, PagedDataParameters pagedDataParameters);
    }
}
