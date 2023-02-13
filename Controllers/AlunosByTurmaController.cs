using Microsoft.AspNetCore.Mvc;
using SysgestColegios.Data;
using SysgestColegios.Models;

namespace SysgestColegios.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlunosByTurmaController : Controller
    {
        private readonly sysgest_colegiosContext _context;
        public AlunosByTurmaController(sysgest_colegiosContext context)

        {
            _context = context;
        }

        [HttpGet(Name = "GetAlunosByTurma")]
        public IEnumerable<ObjInfoAluno> GetAlunosByTurma(int idTurma)
        {

            List<ObjInfoAluno> alunos = new List<ObjInfoAluno>();
            ObjInfoAluno aluno = null;
            IEnumerable<Tabaluno> objList = _context.Tabalunos;
            var query = from al in _context.Tabalunos
                        join mtr in _context.Tabmatriculas on al.Idaluno equals mtr.Idaluno
                        join cl in _context.Tabclasses on mtr.Idclasse equals cl.Idclasse
                        join cicl in _context.Tabciclos on cl.Idciclo equals cicl.Idciclo
                        join tm in _context.Tabturmas on mtr.Idturma equals tm.Idturma
                        join trn in _context.Tabturnos on mtr.Idturno equals trn.Idturno
                        join crso in _context.Tabcursos on mtr.Idcurso equals crso.Idcurso
                        join stat in _context.Tabstatuses on al.Idstatus equals stat.Idstatus
                        join altm in _context.DsAlunoTurmas on tm.Idturma equals altm.IdTurma
                        where tm.Idturma == idTurma && stat.Idstatus == 2 && stat.Idstatus == 2
                        select new
                        {
                            al.Numaluno,
                            al.Nome,
                            al.Sexo,
                            _classe = cl.Nome,
                            cl.Idclasse,
                            _turma = tm.Nome,
                            tm.Idturma,
                            _estado = stat.Nome,
                            al.ApiId,
                            al.Foto,
                            al.Idaluno,
                            Status = stat.Nome,
                            altm.NumOrdem
                        };
            foreach (var item in query)
            {
                int IsGenero = Convert.ToInt32(item.Sexo);
                string _apiID = Convert.ToString(item.ApiId);
                aluno = new ObjInfoAluno
                {
                    Numero = Convert.ToInt32(item.Numaluno),
                    Nome = item.Nome,
                    Genero = Convert.ToBoolean(IsGenero) ? "Femenino" : "Masculino",
                    Classe = item._classe,
                    Turma = item._turma,
                    Estado = item._estado,
                    ApiId = _apiID,
                    IdClasse = Convert.ToInt32(item.Idclasse.ToString()),
                    Id_Turma = Convert.ToInt32(item.Idturma.ToString()),
                    FotoByte = (item.Foto),
                    NumOrdem = Convert.ToInt32(item.NumOrdem)
                };
                alunos.Add(aluno);

            }

            return alunos; //objList.ToList().FindAll(x => x.Iduser == id);        
        }
    }
}
