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
    public class EmpleadoController: ControllerBase
    {

        private IEmpleadoService _empleadoService;
        public EmpleadoController(IEmpleadoService empleadoService)
        {
            _empleadoService = empleadoService;
        }

        [HttpGet]
        [Route("ObtenerEmpleado")]

        public IActionResult ObtenerCliente() 
        {
            Response<List<EmpleadoDTO>> r = new Response<List<EmpleadoDTO>>();
            try
            {
                r.Data = this._empleadoService.ObtenerEmpleado();
                return Ok(r);

            }
            catch (Exception ex) {
                r.Header.Code = HttpCodes.BadRequest;
                r.Header.Message = ex.Message;
                return BadRequest(r);


            }
        
        }
        [HttpPost]
        [Route("IngresarEmpleado")]

        public IActionResult IngresarEmpleado(EmpleadoDTO empleadoDTO)
        {
            Response<List<EmpleadoDTO>> r = new Response<List<EmpleadoDTO>>();
            try
            {
                _empleadoService.AgregarEmpleado(empleadoDTO);
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
