using Dominio;
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

        public IDbSet<Empresa> Empresas { get; set; }

        public IDbSet<TipoDocumento> TiposDocumentos { get; set; }

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
            modelBuilder.Configurations.Add(new EmpresaConfiguracionMapeo());
            modelBuilder.Configurations.Add(new TipoDocumentoConfiguracionMapeo());

            base.OnModelCreating(modelBuilder);
        }

        public new void SaveChanges()
        {
            base.SaveChanges();
        }

        #endregion
    }
}
