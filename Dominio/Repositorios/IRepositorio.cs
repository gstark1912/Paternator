using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Repositorios
{
    public interface IRepositorio<TEntidad> where TEntidad : class
    {
        void Insert(TEntidad entity);

        void Update(TEntidad entity);

        void Delete(int id);

        TEntidad GetByID(int id);

        List<TEntidad> GetAll();

        void SaveChanges();
    }
}
