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
    public class FacturaController : ControllerBase
    {

        private IFacturaService _facturaService;

        public FacturaController(IFacturaService clienteService)
        {
            _facturaService = clienteService;
        }
        [HttpGet]
        [Route("ObtenerFactura")]

        public IActionResult ObtenerFactura()
        {
            Response<List<FacturaDTO>> r = new Response<List<FacturaDTO>>();

            try
            {
                r.Data = this._facturaService.ObtenerFactura();
                return Ok(r);
            }
            catch (Exception ex) {

                r.Header.Code = HttpCodes.BadRequest;
                r.Header.Message = ex.Message;
                return BadRequest(r);
            }

        }

        [HttpPost]
        [Route("IngresarFactura")]

        public IActionResult IngresarFactura(FacturaDTO facturaDto) 
        {
            Response<List<FacturaDTO>> r = new Response<List<FacturaDTO>>();
            try {
                _facturaService.AgregarFactura(facturaDto);
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
