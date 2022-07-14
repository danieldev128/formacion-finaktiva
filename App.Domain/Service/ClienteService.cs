using App.Common.DTO;
using App.Infrastructure.Database.Entities;
using App.Infrastructure.Repositories;
using AutoMapper;
using Infraestructure.Common.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Service
{

    public interface IClienteService {

        List<ClienteDTO> ObtenerClientes();
        ClienteDTO AgregarCliente(ClienteDTO clienteDto);
    }
    public class ClienteService : IClienteService
    {
        private IClienteRepository _repository;
        private IMapper _mapper;
        public ClienteService(IClienteRepository repository, IMapper mapper)
        {

            _repository = repository;
            _mapper = mapper;

        }

        public List<ClienteDTO> ObtenerClientes()
        {
            

            var clientes = _mapper.Map<List<ClienteDTO>>(_repository.ObtenerClientes());
            return clientes;
           
        }

        public ClienteDTO AgregarCliente(ClienteDTO clienteDto) {

            var cliente = _mapper.Map<Cliente>(clienteDto);
            var result = _repository.AgregarCliente(cliente);



            return _mapper.Map<ClienteDTO>(result);
        
        
        }
    }
}
