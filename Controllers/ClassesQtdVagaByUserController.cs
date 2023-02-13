using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SysgestColegios.Data.Procedimento;
using SysgestColegios.Models;
using System.Data;

namespace SysgestColegios.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassesQtdVagaByUserController : ControllerBase
    {
        [HttpGet(Name = "ClassesQtdVagaByUser")]
        public IEnumerable<ListaQtdVagaClasses> ClassesQtdVaga_ByUser(int value)
        {
            List<ListaQtdVagaClasses> ListaClasses = new List<ListaQtdVagaClasses>();
            ListaQtdVagaClasses classe = null;
            QtdVagas_Classe x_data = new QtdVagas_Classe();
            var _data = x_data.Qtd_Vagas(value);


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
