using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SysgestColegios.Data;
using SysgestColegios.Data.Procedimento;
using SysgestColegios.Models;
using System.Data;

namespace SysgestColegios.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassesController : ControllerBase
    {
        private readonly sysgest_colegiosContext _context;
        public ClassesController(sysgest_colegiosContext context)

        {
            _context = context;
        }

        [HttpGet(Name = "GetClasses")]
        public IEnumerable<ListaQtdVagaClasses> GetClasses()
        {

            List<ListaQtdVagaClasses> ListaClasses = new List<ListaQtdVagaClasses>();
            ListaQtdVagaClasses classe = null;
            QtdClasses_VagasGenericas x_data = new QtdClasses_VagasGenericas();
            var _data = x_data.QtdCassesGenericas_Vagas();


            foreach (DataRow item in _data.Rows)
            {
                classe = new ListaQtdVagaClasses
                {
                    Classe = item["CLASSE"].ToString(),
                    QTD = item["QTD"].ToString(),
                    Vagas = item["VAGAS"].ToString()
                };
                ListaClasses.Add(classe);

            }
            return ListaClasses;
        }
    }
}
