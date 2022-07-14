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

    public interface IinventarioService {
        public List<InventarioDTO> MostrarInventario();
        public InventarioDTO AgregarInventario(InventarioDTO inventarioDto);



    }
    public class InventarioService : IinventarioService
    {
        private IinventarioRepository _repository;
        private IMapper _mapper;

        public InventarioService(IinventarioRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public List<InventarioDTO> MostrarInventario(){

            var inventario = _mapper.Map<List<InventarioDTO>>(_repository.ObtenerInventario());
            return inventario;
        
        }
        public InventarioDTO AgregarInventario(InventarioDTO inventarioDto) {

            
            var inventarioR = _mapper.Map<Inventario>(inventarioDto);
            var result = _repository.AgregarInventario(inventarioR);

            

            return _mapper.Map<InventarioDTO>(result);
        
        }
      

    }
}
