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
    public class ClienteController : ControllerBase
    {



        private IClienteService _clienteServices;
        public ClienteController(IClienteService clienteService)
        {
            _clienteServices = clienteService;

        }

        [HttpGet]
        [Route("ObtenerCliente")]
        public IActionResult ObtenerCliente()
        {
            Response<List<ClienteDTO>> r = new Response<List<ClienteDTO>>();
            try
            {
                r.Data = this._clienteServices.ObtenerClientes();
                
                return Ok(r);

            }
            catch (Exception ex)
            {
                r.Header.Code = HttpCodes.BadRequest;
                r.Header.Message = ex.Message;
                return BadRequest(r);
            }
        }
        [HttpPost]
        [Route("IngresarCliente")]

        public IActionResult IngresarCliente(ClienteDTO clienteDto) {

            Response<List<ClienteDTO>> r = new Response<List<ClienteDTO>>();
            

            try
            {
                _clienteServices.AgregarCliente(clienteDto);
                return Ok();


            }
            catch(Exception ex) {

                r.Header.Code = HttpCodes.BadRequest;
                r.Header.Message = ex.Message;
                return BadRequest(r);


            }

           



        }
    }
}
