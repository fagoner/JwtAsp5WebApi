using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JwtAsp5WebApi.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class ProtectedController : ControllerBase
    {

        [AllowAnonymous]
        [HttpGet]
        public ActionResult<string> Ping()
        {
            System.Console.WriteLine("Ping request..");

            return Ok("pong");
        }

        [Authorize]
        [HttpGet("resource")]
        public ActionResult ProtectedResource()
        {
            return Ok(new
            {
                Message = "Deluxe and protected Hello World"
            });
        }


    }

}