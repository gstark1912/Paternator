using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Entities;

namespace Infraestructura.Datos.Mapeos
{
    public class EquipoConfiguracionMapeo : EntityTypeConfiguration<Equipo>
    {
        public EquipoConfiguracionMapeo()
        {
            this.HasKey(x => x.IDEquipo);
            this.Property(e => e.IDEquipo).IsRequired();
            this.Property(e => e.IDLiga).IsRequired();
            this.Property(e => e.Descripcion).IsRequired();
            this.Property(e => e.DescripcionAbreviada).IsRequired();
        }
    }
}
