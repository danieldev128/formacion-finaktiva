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
    public class InventarioController: ControllerBase
    {
        private IinventarioService _inventarioService;

        public InventarioController(IinventarioService inventarioService) {

            _inventarioService = inventarioService;

        }


        [HttpGet]
        [Route("ObtenerInventario")]

        public IActionResult ObtenerInventario() {

            Response<List<InventarioDTO>> r = new Response<List<InventarioDTO>>();
            try 
            {
                r.Data = this._inventarioService.MostrarInventario();
                return Ok(r);
            
            } catch(Exception ex) {

                r.Header.Code = HttpCodes.BadRequest;
                r.Header.Message = ex.Message;
                return BadRequest(r);
            }
        
        }

        [HttpPost]
        [Route("AgregarInventario")]

        public IActionResult AgregarInventario(InventarioDTO inventarioDTO)
        {
            Response<List<InventarioDTO>> r = new Response<List<InventarioDTO>>();
            try 
            {
                _inventarioService.AgregarInventario(inventarioDTO);
                return Ok();
            } catch (Exception ex) {
                r.Header.Code = HttpCodes.BadRequest;
                r.Header.Message = ex.Message;
                return BadRequest(r);           
 
            }
        
        
        
        }


    }
}
