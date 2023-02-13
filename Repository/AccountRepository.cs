using Microsoft.AspNetCore.Identity;
using SysgestColegios.Data;
using SysgestColegios.Models;

namespace SysgestColegios.Repository
{
    public class AccountRepository /*: IAccountRepository*/
    {
        //private readonly sysgest_colegiosContext _context;
        //public AccountRepository(sysgest_colegiosContext context)
        //{
        //    _context = context;
        //}

        //public bool SignInAccount(SignIn signUp)
        //{

        //    List<Tabuser> tabusers = _context.Tabusers.ToList();
        //    bool validar = tabusers.Exists(x => x.Userpassword == signUp.PassWord);

        //    if (!validar)
        //    {
        //        var x_user = new Tabuser()
        //        {
        //            Nome = signUp.UserName,
        //            Userpassword = signUp.PassWord
        //        };

        //        return false;
        //    }
        //    else
        //    {
        //        var _user = new Tabuser()
        //        {
        //            Nome = signUp.UserName,
        //            Userpassword = signUp.PassWord
        //        };
        //        return true;
        //    }

        //}
    }
}
