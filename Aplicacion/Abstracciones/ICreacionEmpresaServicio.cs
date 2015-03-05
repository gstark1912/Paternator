using Dominio;
using Dominio.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Abstracciones
{
    public interface ICreacionEmpresaServicio
    {
        OperationResult Crear(Empresa empresa);

        Empresa Obtener(int id);

        OperationResult Actualizar(Empresa empresa);

        OperationResult Eliminar(int id);

        PagedDataResult<Empresa> GetEmpresasPaginadas(string desc, PagedDataParameters pagedDataParameters);
    }
}
