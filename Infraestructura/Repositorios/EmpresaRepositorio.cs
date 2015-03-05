using Dominio;
using Dominio.Repositorios;
using Infraestructura.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Resources;

namespace Infraestructura.Repositorios
{
    public class EmpresaRepositorio : Repositorio<Empresa>, IEmpresaRepositorio
    {
        public EmpresaRepositorio(IFacturaElectronicaDbContext contexto)
            : base(contexto)
        {
        }

        public PagedDataResult<Empresa> GetPagedByDescription(string desc, PagedDataParameters parameters)
        {
            IQueryable<Empresa> data = dbSet.Where(a => a.Nombre.Contains(desc));
            return new PagedDataResult<Empresa>(data.PagedData(parameters).ToList(), data.Count());
        }
    }
}
