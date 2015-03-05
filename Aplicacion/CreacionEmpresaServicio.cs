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
    public class CreacionEmpresaServicio : ICreacionEmpresaServicio
    {
        private readonly IEmpresaRepositorio _empresasRepositorio;

        public CreacionEmpresaServicio(IEmpresaRepositorio empresasRepositorio)
        {
            _empresasRepositorio = empresasRepositorio;
        }

        public OperationResult Crear(Dominio.Empresa empresa)
        {
            List<string> _messages = new List<string>();
            //TODO: validaciones de empresa que requieran ir a base de datos
            //TODO: logica de negocioS
            try
            {
                _empresasRepositorio.Insert(empresa);
                _empresasRepositorio.SaveChanges();
                return new OperationResult();
            }
            catch (Exception ex)
            {
                _messages.Add(ex.Message);
                return new OperationResult(_messages);
            }

        }

        public Dominio.Empresa Obtener(int id)
        {
            return _empresasRepositorio.GetByID(id);
        }

        public OperationResult Actualizar(Dominio.Empresa empresa)
        {
            List<string> _messages = new List<string>();
            //TODO: validaciones de empresa que requieran ir a base de datos
            //TODO: logica de negocioS
            try
            {
                Empresa entidad = _empresasRepositorio.GetByID(empresa.Id);
                entidad.Nombre = empresa.Nombre;
                _empresasRepositorio.Update(entidad);
                _empresasRepositorio.SaveChanges();
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
                _empresasRepositorio.Delete(id);
                _empresasRepositorio.SaveChanges();
                return new OperationResult();
            }
            catch (Exception ex)
            {
                _messages.Add(ex.Message);
                return new OperationResult(_messages);
            }
        }

        public PagedDataResult<Empresa> GetEmpresasPaginadas(string desc, PagedDataParameters pagedDataParameters)
        {
            PagedDataResult<Empresa> resultados = _empresasRepositorio.GetPagedByDescription(desc, pagedDataParameters);
            return new PagedDataResult<Empresa>(resultados.Results, resultados.TotalCount);
        }
    }
}
