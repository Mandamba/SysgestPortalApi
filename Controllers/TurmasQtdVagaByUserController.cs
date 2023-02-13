using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SysgestColegios.Data.Procedimento;
using SysgestColegios.Models;
using System.Data;

namespace SysgestColegios.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TurmasQtdVagaByUserController : ControllerBase
    {
        [HttpGet(Name = "TurmasQtdVagaByUser")]
        public IEnumerable<ListaQtdVagaTurmas> TurmasQtdVaga_ByUser(int value)
        {
            List<ListaQtdVagaTurmas> ListaTurmas = new List<ListaQtdVagaTurmas>();
            ListaQtdVagaTurmas turmas = null;
            QtdVagas_Turmas x_data = new QtdVagas_Turmas();
            var _data = x_data.Qtd_Vagas(value);


            foreach (DataRow item in _data.Rows)
            {
                turmas = new ListaQtdVagaTurmas
                {
                    Turma = item["TURMA"].ToString(),
                    QTD = item["QTD"].ToString(),
                    Vagas = item["VAGAS"].ToString()
                };
                ListaTurmas.Add(turmas);

            }
            return ListaTurmas;
        }
    }
}
