using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SysgestColegios.Data.Procedimento;
using SysgestColegios.Data;
using SysgestColegios.Models;
using System.Data;

namespace SysgestColegios.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AllTurmasController : ControllerBase
    {
        private readonly sysgest_colegiosContext _context;
        public AllTurmasController(sysgest_colegiosContext context)

        {
            _context = context;
        }

        [HttpGet(Name = "GetAllTurmas")]
        public IEnumerable<ListaQtdVagaTurmas> GetAllTurmass()
        {

            List<ListaQtdVagaTurmas> ListaClasses = new List<ListaQtdVagaTurmas>();
            ListaQtdVagaTurmas classe = null;
            QtdTurmasGenericas_Vagas x_data = new QtdTurmasGenericas_Vagas();
            var _data = x_data.QtdAllTurmasGenericas_Vagas();


            foreach (DataRow item in _data.Rows)
            {
                classe = new ListaQtdVagaTurmas
                {
                    Turma = item["TURMA"].ToString(),
                    QTD = item["QTD"].ToString(),
                    Vagas = item["VAGAS"].ToString()
                };
                ListaClasses.Add(classe);

            }
            return ListaClasses;
        }
    }
}
