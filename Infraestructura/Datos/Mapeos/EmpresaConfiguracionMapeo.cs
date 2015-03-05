using Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Linq;
using System.Text;

namespace Infraestructura.Datos.Mapeos
{
    public class EmpresaConfiguracionMapeo : EntityTypeConfiguration<Empresa>
    {
        public EmpresaConfiguracionMapeo()
        {
            this.ToTable("LegalEntity");

            this.HasKey(x => x.Id);

            this.Property(e => e.Id).HasColumnName("IDLegEnt").IsRequired();
            this.Property(e => e.Nombre).HasColumnName("Name").IsRequired();
            this.Property(e => e.Direccion).HasColumnName("Address");
            this.Property(e => e.Logo).IsRequired();
        }
    }
}
