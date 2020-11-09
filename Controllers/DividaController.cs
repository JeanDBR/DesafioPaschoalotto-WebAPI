using Microsoft.AspNetCore.Mvc;
using DesafioPaschoalotto_WebAPI.Models;

namespace DesafioPaschoalotto_WebAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class DividaController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                Parcela[] retorno = new Parcela[2];
                retorno[0] = new Parcela(1,new Divida(1, "3000", 8, "Simples", 1434652549), 1, 3, new Date(2019, 3, 11));
                retorno[1] = new Parcela(1,new Divida(1, "3000", 8, "Simples", 1434652549), 2, 3, new Date(2019, 4, 11));
                retorno[1] = new Parcela(1,new Divida(1, "3000", 8, "Simples", 1434652549), 2, 3, new Date(2019, 5, 11));
                return Ok(retorno);
            }
            catch (System.Exception)
            {
                
                throw;
            }
        }
    }
}