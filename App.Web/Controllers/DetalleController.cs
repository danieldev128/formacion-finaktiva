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

    public class DetalleController : ControllerBase
    {
        
        private IDetalleService _detalleService;

        public DetalleController(IDetalleService detalleService)
        {
            _detalleService = detalleService;
        
        }

        [HttpGet]
        [Route("ObtenerDetalle")]

        public IActionResult ObtenerDetalle() 
        {
            Response<List<DetalleDTO>> r = new Response<List<DetalleDTO>>();

            try
            {
                r.Data = this._detalleService.ObtenerDetalles();

                return Ok(r);

            }
            catch(Exception ex)
            {
                r.Header.Code = HttpCodes.BadRequest;
                r.Header.Message = ex.Message;
                return BadRequest(r);
            
            }
        
        }
        [HttpPost]
        [Route("IngresarDetalle")]

        public IActionResult IngresarDetalle(DetalleDTO detalleDto) {

            Response<List<DetalleDTO>> r = new Response<List<DetalleDTO>>();

            try
            {
                _detalleService.AgregarDetalle(detalleDto);
                return Ok();

            }
            catch (Exception ex) {

                r.Header.Code = HttpCodes.BadRequest;
                r.Header.Message = ex.Message;
                return BadRequest(r);
            
            }
        
        
        }

    }
}
