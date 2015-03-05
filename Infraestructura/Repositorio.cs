using Dominio.Repositorios;
using Infraestructura.Datos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura
{
    public class Repositorio<TEntidad> : IRepositorio<TEntidad> where TEntidad : class
    {
        private readonly IFacturaElectronicaDbContext _contexto;
        protected DbSet<TEntidad> dbSet { get; set; }
        public IFacturaElectronicaDbContext contexto { get { return _contexto; } }

        public Repositorio(IFacturaElectronicaDbContext ctx)
        {
            _contexto = ctx;
            dbSet = _contexto.Set<TEntidad>();
        }

        public void Insert(TEntidad entity)
        {
            if (entity == null)
                throw new ArgumentNullException("Entidad", "La entidad no puede ser null.");

            dbSet.Add(entity);
        }

        public void Update(TEntidad entity)
        {
            dbSet.Attach(entity);
            _contexto.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            dbSet.Remove(this.GetByID(id));
        }

        public TEntidad GetByID(int id)
        {
            return dbSet.Find(id);
        }

        public List<TEntidad> GetAll()
        {
            return dbSet.ToList();
        }

        public void SaveChanges()
        {
            _contexto.SaveChanges();
        }
    }
}
