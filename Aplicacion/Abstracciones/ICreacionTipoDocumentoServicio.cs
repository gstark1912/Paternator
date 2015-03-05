using Dominio;
using Dominio.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Abstracciones
{
    public interface ICreacionTipoDocumentoServicio
    {
        OperationResult Crear(TipoDocumento tipodocumento);

        TipoDocumento Obtener(int id);

        OperationResult Actualizar(TipoDocumento tipodocumento);

        OperationResult Eliminar(int id);
    }
}
