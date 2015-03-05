using Dominio.Entities;
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
    public class JuegoVersionRepositorio : Repositorio<JuegoVersion>, IJuegoVersionRepositorio
    {
        public JuegoVersionRepositorio(IFacturaElectronicaDbContext contexto)
            : base(contexto)
        {
        }
    }
}
