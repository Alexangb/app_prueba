using app.infraestructure.repositorio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace app.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        [HttpGet]
        public IActionResult getUsuarios()
        {
            var usuario = new UsuarioRepositorio().GetEUsuarios();
            return Ok(usuario);
        }
    }
}
