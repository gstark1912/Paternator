using Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura.Datos.Mapeos
{
    public class TipoDocumentoConfiguracionMapeo : EntityTypeConfiguration<TipoDocumento>
    {
        public TipoDocumentoConfiguracionMapeo()
        {
            this.ToTable("DocumentType");

            this.HasKey(x => x.Id);

            this.Property(e => e.Id).HasColumnName("IDDocType").IsRequired();
            this.Property(e => e.Tipo).HasColumnName("Type").IsRequired();

        }
    }
}
