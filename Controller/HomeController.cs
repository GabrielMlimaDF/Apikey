using Microsoft.AspNetCore.Mvc;

namespace ApiKey.Controller
{
    [ApiController]
    public class HomeController: ControllerBase
    {
        private readonly ContextApp _contextApp;

        public HomeController(ContextApp contextApp)
        {
            _contextApp = contextApp;
        }


        [Route("")]
        [HttpGet("")]
        public ActionResult Get()
        {
            return Ok("Funcionando");
        }
    }
}
