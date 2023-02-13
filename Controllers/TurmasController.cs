using Microsoft.AspNetCore.Mvc;
using SysgestColegios.Data;
using SysgestColegios.Models;

namespace SysgestColegios.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TurmasController : ControllerBase
    {
        private readonly sysgest_colegiosContext _context;
        public TurmasController(sysgest_colegiosContext context)
        {
            _context = context;
        }

        [HttpGet(Name = "GetTurmas")]
        public IEnumerable<InfoProfessor> GetTurmas(int IdUserProfessor)
        {
            List<InfoProfessor> professors = new List<InfoProfessor>();
            InfoProfessor professor = null;
            IEnumerable <Tabanoslectivo> AnoLectivo_LastRow = _context.Tabanoslectivos;
            var AnoLista = AnoLectivo_LastRow.ToList();
            var AnoInactivo = AnoLista.FindAll(x => x.Inactivo == false);
            var _Ano = AnoInactivo.LastOrDefault().Idano;
            IEnumerable<TbProfessorTurma> objList = _context.TbProfessorTurmas;
            var query = from t in _context.TbProfessorTurmas
                        join user in _context.Tabusers on t.Iduser equals user.Iduser
                        join tm in _context.Tabturmas on t.Idturma equals tm.Idturma
                        join prof in _context.Tdocentes on user.IdDocente equals prof.Id
                        where t.Iduser == IdUserProfessor && tm.Idano == _Ano
                        select new
                        {                           
                            user.IdDocente,
                            prof.Nome,
                            _turma = tm.Nome,
                            tm.Idturma,
                            //tm.Numvagas

                        };
            //var collection = query.ToList();
            foreach (var item in query)
            {
               //int _qtd = collection.Count(x => x.Idturma == item.Idturma);
               // int _vagas = Convert.ToInt32(item.Numvagas) - _qtd;

                professor = new InfoProfessor
                {
                    Id_Professor = Convert.ToInt32(item.IdDocente),
                    Professor = item.Nome,
                    Turma = item._turma,
                    IdTurma = Convert.ToInt32(item.Idturma.ToString())
                    //NumVagas = _vagas
                };
                professors.Add(professor);
            }
            
            return professors; //objList.ToList().FindAll(x => x.Iduser == id);                        
        }
    }
}
