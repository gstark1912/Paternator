using Dominio;
using Dominio.Repositorios;
using Infraestructura.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura.Repositorios
{
    public class TipoDocumentoRepositorio : Repositorio<TipoDocumento>, ITipoDocumentoRepositorio
    {
        public TipoDocumentoRepositorio(IFacturaElectronicaDbContext ctx)
            : base(ctx)
        {
        }

    }
}
