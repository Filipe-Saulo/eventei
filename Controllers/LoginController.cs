using eventei.Models;
using Microsoft.AspNetCore.Mvc;

namespace eventei.Controllers
{

    //h_ttps://localhost:7204/api/Login
    [Route("api/[Controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private Login[] _logins = new Login[]
        {
            new Login{ email = "caraio", senha = "porra"},
            new Login{ email = "pinto", senha = "noku"}
        };

        //httpget, httpupdate, httpdelete... por ai vai

        [HttpGet]
        public ActionResult<IEnumerable<Login>> GetLogin()
        {
            return Ok(_logins);
        }
        //essa informacao acima é retornado para a porta h_ttps://localhost:7204/api/Login no qual vai ser tratado no front end
    }
}
