using Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura.Datos
{
    public interface IFacturaElectronicaDbContext
    {
        DbEntityEntry Entry(object entity);

        IDbSet<Empresa> Empresas { get; set; }

        IDbSet<TipoDocumento> TiposDocumentos { get; set; }

        DbSet Set(Type entityType);
        DbSet<TEntity> Set<TEntity>() where TEntity : class;

        void SaveChanges();
    }
}
