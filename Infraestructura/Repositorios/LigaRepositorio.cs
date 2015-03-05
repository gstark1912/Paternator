using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Entities;
using Dominio.Repositorios;
using Infraestructura.Datos;

namespace Infraestructura.Repositorios
{
    public class LigaRepositorio : Repositorio<Liga>, ILigaRepositorio
    {
        public LigaRepositorio(IFacturaElectronicaDbContext contexto)
            : base(contexto)
        {
        }
    }
}