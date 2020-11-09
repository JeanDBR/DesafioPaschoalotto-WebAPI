using Microsoft.AspNetCore.Mvc;
using DesafioPaschoalotto_WebAPI.Models;

namespace DesafioPaschoalotto_WebAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ParcelaController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            Parcela retorno = new Parcela();
            return Ok(retorno);
        }
    }
}