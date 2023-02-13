using SysgestColegios.Data;
using SysgestColegios.Models;

namespace SysgestColegios.Repository
{
    public class UserRepository
    {
        sysgest_colegiosContext _context;
        public UserRepository(sysgest_colegiosContext context)
        {
            _context = context;
        }

        public List<Tabuser> GetAllTabusers()
        {
            var record = _context.Tabusers.Select(x => new Tabuser()
            {
                Nome = x.Nome,
                Userpassword = x.Userpassword,
            });

            return (List<Tabuser>)record;
        }
    }
}
