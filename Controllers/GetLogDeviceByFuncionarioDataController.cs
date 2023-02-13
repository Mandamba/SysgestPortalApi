using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SysgestColegios.Data;
using SysgestColegios.Models;

namespace SysgestColegios.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GetLogDeviceByFuncionarioDataController : Controller
    {
        public class logEntradaSaida
        {
            public int NumInterno { get; set; }
            public string Nome { get; set; }
            public string Descricao { get; set; }
            public string Hora { get; set; }
            public DateTime Data { get; set; }
        }

        private readonly sysgest_colegiosContext _context;
        public GetLogDeviceByFuncionarioDataController(sysgest_colegiosContext context)
        {
            _context = context;
        }

        [HttpGet(Name = "GetLogDeviceByFuncionarioData")]
        public IEnumerable<logEntradaSaida> GetLogsDeviceByFuncData(int numinterno, string data)
        {
            List<logEntradaSaida> logs1 = new List<logEntradaSaida>();
            logEntradaSaida log1 = null;
            IEnumerable<LogTorniquete> objList = _context.LogTorniquetes;
            var query = from log in _context.LogTorniquetes
                        where log.NumInterno == numinterno && log.DataRegisto.Date.Month.ToString() + "/" + log.DataRegisto.Date.Year.ToString() == data
                        select new
                        {
                            log.NumInterno,
                            log.NomeEntidade,
                            log.DescrActionType,
                            log.HoraRegisto,
                            log.DataRegisto.Date
                        };
            foreach (var item in query)
            {
                log1 = new logEntradaSaida
                {
                    NumInterno = Convert.ToInt32(item.NumInterno),
                    Nome = item.NomeEntidade,

                    Descricao = item.DescrActionType,
                    Hora = item.HoraRegisto,
                    Data = Convert.ToDateTime(item.Date)
                };
                logs1.Add(log1);
            }

            return logs1; //objList.ToList().FindAll(x => x.Iduser == id);     
        }


    }
}
