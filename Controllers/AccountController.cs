using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SysgestColegios.Data;
using SysgestColegios.Models;
using SysgestColegios.Repository;

namespace SysgestColegios.Controllers
{
    
    [ApiController]
    [Route("api/[controller]")]
    public class AccountController : ControllerBase
    {

        private readonly sysgest_colegiosContext _context;
        public AccountController(sysgest_colegiosContext context)
        {
            _context = context;
        }

        [HttpPost("sigIn")]
        public async Task<IActionResult> SigIn([FromBody] SignIn signIn)
        {
            IEnumerable<Tabuser> objList = _context.Tabusers;

            int id = objList.ToList().Find(x => x.Userlogin == signIn.UserName).Iduser;
            objList = objList.Where((x => x.Iduser == id)).ToList();
            var passW = objList.ToList().Exists(x => x.Userpassword == signIn.PassWord);
            var nameUser = objList.ToList().Exists(x => x.Userlogin == signIn.UserName);

            if (passW && nameUser)
            {
                Tabuser user = objList.FirstOrDefault(x => x.Userpassword == signIn.PassWord);
                return Ok(user.Iduser);
            }
            return Unauthorized();
        }
    }
}
