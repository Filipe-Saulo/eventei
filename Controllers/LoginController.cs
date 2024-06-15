using eventei.Models;
using Microsoft.AspNetCore.Mvc;
using CamadaNegocios;
using BancoDados;

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
            D_Usuarios[] d_Usuarios = new D_Usuarios[0];
            ValidaLogin objUsuario = new ValidaLogin();
            d_Usuarios = objUsuario.DevolverUsuario();
            return Ok(d_Usuarios);
        }
        //essa informacao acima é retornado para a porta h_ttps://localhost:7204/api/Login no qual vai ser tratado no front end
    }
}
