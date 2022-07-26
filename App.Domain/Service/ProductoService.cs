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
    public interface IProductoService
    {
        List<ProductoDTO> ObtenerProducto();
        ProductoDTO AgregarProducto(ProductoDTO productoDto);
        ProductoDTO Editar(int idProducto);
    }
    public class ProductoService : IProductoService
    {
        private IProductoRepository _repository;
        private IMapper _mapper;

        public ProductoService(IProductoRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;

        }

        public List<ProductoDTO> ObtenerProducto()
        {



            var productos = _mapper.Map<List<ProductoDTO>>(_repository.ObtenerVwProductos());
            return productos;
        }

        public ProductoDTO AgregarProducto(ProductoDTO productoDto) {
            var productoR = _mapper.Map<Producto>(productoDto);
            var result = _repository.AgregarProducto(productoR);
            return _mapper.Map<ProductoDTO>(result);
        }

        public ProductoDTO Editar(int idProducto) {

            var productoEdit = _mapper.Map<ProductoDTO>(_repository.editarProducto(idProducto));
            Console.WriteLine("Este es el producto:");
            Console.WriteLine(productoEdit);
           
            return (productoEdit);


        }

    }

   
}
