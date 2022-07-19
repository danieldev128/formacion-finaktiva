using App.Common.DTO;
using App.Domain.Contracts;
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
    public interface IFacturaService
    {
        public List<FacturaDTO> ObtenerFactura();
        public FacturaDTO AgregarFactura(FacturaDTO facturaDto);
    }
    public class FacturaService:IFacturaService
    {
        IFacturaRepository _repository;
        IMapper _mapper;
        public FacturaService(IFacturaRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public List<FacturaDTO> ObtenerFactura() 
        {
            var factura = _mapper.Map<List<FacturaDTO>>(_repository.ObtenerFactura());
            return factura;
        }
        public FacturaDTO AgregarFactura(FacturaDTO facturaDto) 
        {
            var productoR = _mapper.Map<Factura>(facturaDto);
            var result = _repository.AgregarFactura(productoR);
            return _mapper.Map<FacturaDTO>(result);
        }

    }

   
}
