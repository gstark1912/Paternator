using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Entities;

namespace Infraestructura.Datos.Mapeos
{
    public class PartidoConfiguracionMapeo: EntityTypeConfiguration<Partido>
    {
        public PartidoConfiguracionMapeo()
        {
            this.HasKey(x => x.IDPartido);
            this.Property(e => e.IDPartido).IsRequired();
            this.Property(e => e.Aprobado);
            this.Property(e => e.FechaAprobacion);
            this.Property(e => e.FechaPartido).IsRequired();
            this.Property(e => e.GolesLocal).IsRequired();
            this.Property(e => e.GolesVisitante).IsRequired();
            this.Property(e => e.IDEquipoLocal).IsRequired();
            this.Property(e => e.IDEquipoVisitante).IsRequired();
            this.Property(e => e.IDJuegoVersion).IsRequired();
            this.Property(e => e.IDJugadorLocal).IsRequired();
            this.Property(e => e.IDJugadorVisitante).IsRequired();
            this.Property(e => e.IDResultadoPartido).IsRequired();            
        }
    }
}

