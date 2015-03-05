using Aplicacion.Abstracciones;
using Dominio;
using Dominio.Repositorios;
using Dominio.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion
{
    public class CreacionTipoDocumentoServicio : ICreacionTipoDocumentoServicio
    {
        private readonly ITipoDocumentoRepositorio _tipodocumentoRepositorio;

        public CreacionTipoDocumentoServicio(ITipoDocumentoRepositorio tipodocumentoRepositorio)
        {
            _tipodocumentoRepositorio = tipodocumentoRepositorio;
        }

        public OperationResult Crear(Dominio.TipoDocumento tipodocumento)
        {
            List<string> _messages = new List<string>();
            //TODO: validaciones de documento que requieran ir a base de datos
            //TODO: logica de negocioS
            try
            {
                _tipodocumentoRepositorio.Insert(tipodocumento);
                _tipodocumentoRepositorio.SaveChanges();
                return new OperationResult();
            }
            catch (Exception ex)
            {
                _messages.Add(ex.Message);
                return new OperationResult(_messages);
            }

        }

        public Dominio.TipoDocumento Obtener(int id)
        {
            return _tipodocumentoRepositorio.GetByID(id);
        }

        public OperationResult Actualizar(Dominio.TipoDocumento tipodocumento)
        {
            List<string> _messages = new List<string>();
            //TODO: validaciones de documento que requieran ir a base de datos
            //TODO: logica de negocioS
            try
            {
                TipoDocumento documento = _tipodocumentoRepositorio.GetByID(tipodocumento.Id);
                documento.Tipo = tipodocumento.Tipo;
                _tipodocumentoRepositorio.Update(documento);
                _tipodocumentoRepositorio.SaveChanges();
                return new OperationResult();
            }
            catch (Exception ex)
            {
                _messages.Add(ex.Message);
                return new OperationResult(_messages);
            }
        }

        public OperationResult Eliminar(int id)
        {
            List<string> _messages = new List<string>();
            try
            {
                _tipodocumentoRepositorio.Delete(id);
                _tipodocumentoRepositorio.SaveChanges();
                return new OperationResult();
            }
            catch (Exception ex)
            {
                _messages.Add(ex.Message);
                return new OperationResult(_messages);
            }
        }
    }
}
