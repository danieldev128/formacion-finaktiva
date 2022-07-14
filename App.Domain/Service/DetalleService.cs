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
    public interface IDetalleService
    {
        List<DetalleDTO> ObtenerDetalles();
        DetalleDTO AgregarDetalle(DetalleDTO detalleDto);
    }
    public class DetalleService : IDetalleService
    {
        private IDetalleRepository _repository;
        private IMapper _mapper;

        public DetalleService(IDetalleRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;

        }

        public List<DetalleDTO> ObtenerDetalles() 
        {
            var detalles = _mapper.Map<List<DetalleDTO>>(_repository.ObtenerDetalle());
            return detalles;
        
        }

        public DetalleDTO AgregarDetalle(DetalleDTO detalleDto) 
        {

            var detalle = _mapper.Map<Detalle>(detalleDto);
            var result = _repository.AgregarDetalle(detalle);

            return _mapper.Map<DetalleDTO>(result);
        
        }
        
    }

   
}
