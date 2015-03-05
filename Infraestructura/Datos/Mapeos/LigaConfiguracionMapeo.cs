using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Entities;

namespace Infraestructura.Datos.Mapeos
{
    public class LigaConfiguracionMapeo : EntityTypeConfiguration<Liga>
    {
        public LigaConfiguracionMapeo()
        {
            this.HasKey(x => x.IDLiga);
            this.Property(e => e.IDLiga).IsRequired();
            this.Property(e => e.Descripcion).IsRequired();
        }
    }
}
