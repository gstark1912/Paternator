using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Entities;

namespace Infraestructura.Datos.Mapeos
{
    public class JugadorConfiguracionMapeo : EntityTypeConfiguration<Jugador>
    {
        public JugadorConfiguracionMapeo()
        {
            this.HasKey(x => x.IDJugador);
            this.Property(e => e.IDJugador).IsRequired();
            this.Property(e => e.Descripcion).IsRequired();
        }
    }
}
