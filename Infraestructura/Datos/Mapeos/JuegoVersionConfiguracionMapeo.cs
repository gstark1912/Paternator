using Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura.Datos.Mapeos
{
    public class JuegoVersionConfiguracionMapeo : EntityTypeConfiguration<JuegoVersion>
    {
        public JuegoVersionConfiguracionMapeo()
        {
            this.HasKey(x => x.IDJuegoVersion);

            this.Property(e => e.IDJuegoVersion).IsRequired();
            this.Property(e => e.Descripcion).IsRequired();
        }
    }
}
