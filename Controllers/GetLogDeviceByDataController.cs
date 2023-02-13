using Microsoft.AspNetCore.Mvc;
using SysgestColegios.Data;
using SysgestColegios.Models;

namespace SysgestColegios.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GetLogDeviceByDataController : Controller
    {
        DateTime? _date = null;
        public class logEntradaSaidaByData
        {
            public int NumInterno { get; set; }
            public string Nome { get; set; }
            public string Descricao { get; set; }
            public string Hora { get; set; }
            public DateTime Data { get; set; }
        }

        private readonly sysgest_colegiosContext _context;

        public GetLogDeviceByDataController(sysgest_colegiosContext context)
        {
            _context = context;
        }


        [HttpGet(Name = "GetLogDeviceByData")]
        public IEnumerable<logEntradaSaidaByData> GetLogsDeviceByData(string data)
        {
            List<logEntradaSaidaByData> logs1 = new List<logEntradaSaidaByData>();
            logEntradaSaidaByData log1 = null;
            IEnumerable<LogTorniquete> objList = _context.LogTorniquetes;
            var query = from log in _context.LogTorniquetes
                        where log.DataRegisto.Date.Month.ToString() + "/" + log.DataRegisto.Date.Year.ToString() == data
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
                log1 = new logEntradaSaidaByData
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
