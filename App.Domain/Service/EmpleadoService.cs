using App.Common.DTO;
using App.Infrastructure.Database.Entities;
using App.Infrastructure.Repositories;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Service
{
    public interface IEmpleadoService
    {
        List<EmpleadoDTO> ObtenerEmpleado();

        EmpleadoDTO AgregarEmpleado(EmpleadoDTO empleadoDto);
    }
    public class EmpleadoService : IEmpleadoService
    {
        private IEmpleadoRepository _repository;
        private IMapper _mapper;

        public EmpleadoService(IEmpleadoRepository repository, IMapper mapper) {

            _repository = repository;
            _mapper = mapper;
        
        }

        public List<EmpleadoDTO> ObtenerEmpleado() {

            var empleados = _mapper.Map<List<EmpleadoDTO>>(_repository.ObtenerEmpleado());

            return empleados;
      
        }

       

        public EmpleadoDTO AgregarEmpleado(EmpleadoDTO empleadoDto)
        {
            var empleado = _mapper.Map<Empleado>(empleadoDto);
            var result = _repository.AgregarEmpleado(empleado);

            return _mapper.Map<EmpleadoDTO>(result);
        }
    }

  
}
