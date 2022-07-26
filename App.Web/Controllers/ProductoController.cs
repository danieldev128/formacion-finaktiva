using App.Common.DTO;
using App.Common.Enums;
using App.Domain.Contracts;
using App.Domain.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController:ControllerBase
    {
        private IProductoService _productoService;
        public ProductoController(IProductoService productoservice)
        {
            _productoService = productoservice;
        }
        [HttpGet]
        [Route("ObtenerProducto")]

        public IActionResult ObtenerProducto() {

            Response <List<ProductoDTO>> r = new Response<List<ProductoDTO>>();

            try {

                r.Data = this._productoService.ObtenerProducto();
                return Ok(r);
            }
            catch (Exception ex) {
                r.Header.Code = HttpCodes.BadRequest;
                r.Header.Message = ex.Message;
                return BadRequest(r);
            }
            
        }

        [HttpPost("AgregarProducto")]
        //[Route("AgregarProducto")]

        public IActionResult AgregarProducto(ProductoDTO productoDTO) {

            Response<List<ProductoDTO>> r = new Response<List<ProductoDTO>>();

            try {

                _productoService.AgregarProducto(productoDTO);
                return Ok();
            
            } catch (Exception ex) {
                r.Header.Code = HttpCodes.BadRequest;
                r.Header.Message = ex.Message;
                return BadRequest(r);
            }
        }

        [HttpPost("EditarProducto")]
        public IActionResult editarProducto(int idProducto){
            Response<ProductoDTO> r = new Response<ProductoDTO>();
            try
            {

                r.Data = this._productoService.Editar(idProducto);
                return Ok(r);

            }
            catch (Exception ex) {
                r.Header.Code = HttpCodes.BadRequest;
                r.Header.Message = ex.Message;
                return BadRequest(r);

            }
        
        
        }
        ////public IActionResult ActualizarProducto(ProductoDTO productoDTO) {

        ////    Response<List<ProductoDTO>> r = new Response<List<ProductoDTO>>();

        ////    try {
        ////        _productoService.Ac(productoDTO);
        ////        return BadRequest(r);
            
        ////    } catch (Exception ex) {

        ////        r.Header.Code = HttpCodes.BadRequest;
        ////        r.Header.Message = ex.Message;
        ////        return BadRequest(r);
            
            
        ////    }
        
        
        //}


    }
}
