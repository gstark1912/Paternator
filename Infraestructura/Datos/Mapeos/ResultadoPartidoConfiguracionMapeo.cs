using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Entities;

namespace Infraestructura.Datos.Mapeos
{
    public class ResultadoPartidoConfiguracionMapeo : EntityTypeConfiguration<ResultadoPartido>
    {
        public ResultadoPartidoConfiguracionMapeo()
        {
            this.HasKey(x => x.IDResultadoPartido);
            this.Property(e => e.IDResultadoPartido).IsRequired();
            this.Property(e => e.Descripcion).IsRequired();
        }
    }
}
