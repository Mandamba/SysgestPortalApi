using Microsoft.AspNetCore.Identity;
using SysgestColegios.Models;

namespace SysgestColegios.Repository
{
    public interface IAccountRepository
    {
        bool SignInAccount(SignIn signUp);
    }
}
