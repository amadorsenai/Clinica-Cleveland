using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.Cleveland.WebApi.Interfaces;
using Senai.Cleveland.WebApi.Repositories;

namespace Senai.Cleveland.WebApi.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class MedicosController : ControllerBase
    {

        private IMedicosInterface MedicosRepository { get; set; }

        public MedicosController()
        {
            MedicosRepository = new MedicosRepository();
        }

        [HttpGet]
        public IActionResult ListarTodos()
        {
            return Ok(MedicosRepository.ListarTodos());
        }

    }
}