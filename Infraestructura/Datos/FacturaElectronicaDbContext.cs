using Dominio.Entities;
using Infraestructura.Datos.Mapeos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura.Datos
{
    public class FacturaElectronicaDbContext : DbContext, IFacturaElectronicaDbContext
    {
        #region Propiedades

        public IDbSet<JuegoVersion> JuegoVersion { get; set; }
        public IDbSet<Equipo> Equipo { get; set; }
        public IDbSet<Jugador> Jugador { get; set; }
        public IDbSet<Liga> Liga { get; set; }
        public IDbSet<Partido> Partido { get; set; }
        public IDbSet<ResultadoPartido> ResultadoPartido { get; set; }

        #endregion

        #region Constructores

        public FacturaElectronicaDbContext()
            : base("name=facturaElectronicaConnectionStrings")
        {
        }

        #endregion

        #region Metodos

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new JuegoVersionConfiguracionMapeo());
            modelBuilder.Configurations.Add(new EquipoConfiguracionMapeo());
            modelBuilder.Configurations.Add(new JugadorConfiguracionMapeo());
            modelBuilder.Configurations.Add(new LigaConfiguracionMapeo());
            modelBuilder.Configurations.Add(new PartidoConfiguracionMapeo());
            modelBuilder.Configurations.Add(new ResultadoPartidoConfiguracionMapeo());
            base.OnModelCreating(modelBuilder);
        }

        public new void SaveChanges()
        {
            base.SaveChanges();
        }

        #endregion
    }
}
