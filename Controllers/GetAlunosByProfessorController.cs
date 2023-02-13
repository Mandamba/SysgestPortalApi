using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using SysgestColegios.Data;
using SysgestColegios.Data.Procedimento;
using SysgestColegios.Models;
using System.Data;

namespace SysgestColegios.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetAlunosByProfessorController : ControllerBase
    {
        private readonly sysgest_colegiosContext _context;
        public GetAlunosByProfessorController(sysgest_colegiosContext context)

        {
            _context = context;
        }

        [HttpGet(Name = "GetAlunosByProfessor")]
        public IEnumerable<ObjInfoAluno> GetAlunosByProfessor(int _IdUser)
        {
            List<ObjInfoAluno> alunos = new List<ObjInfoAluno>();
            ObjInfoAluno aluno = null;
            AlunosPorProfessor x_data = new AlunosPorProfessor();
            IEnumerable<Tabanoslectivo> AnoLectivo = _context.Tabanoslectivos;

            var AnoLista = AnoLectivo.ToList();
            var AnoInactivo = AnoLista.FindAll(x => x.Inactivo == false);
            var _Ano = AnoInactivo.LastOrDefault().Idano;

            var _data = x_data.GenerateAlunosByProfessor(_IdUser);
            var Listalunos = _context.Tabalunos.ToList();


            //IEnumerable<Tabaluno> objList = _context.Tabalunos;
            //var query = from al in _context.Tabalunos
            //            join mtr in _context.Tabmatriculas on al.Idaluno equals mtr.Idaluno
            //            join cl in _context.Tabclasses on mtr.Idclasse equals cl.Idclasse
            //            join cicl in _context.Tabciclos on cl.Idciclo equals cicl.Idciclo
            //            join tm in _context.Tabturmas on mtr.Idturma equals tm.Idturma
            //            join stat in _context.Tabstatuses on mtr.Idstatus equals stat.Idstatus
            //            join altm in _context.DsAlunoTurmas on tm.Idturma equals altm.IdTurma
            //            join prfT in _context.TbProfessorTurmas on tm.Idturma equals prfT.Idturma
            //            join anoL in _context.Tabanoslectivos on tm.Idano equals anoL.Idano
            //            join us in _context.Tabusers on prfT.Iduser equals us.Iduser
            //            where prfT.Iduser == _IdUser && (stat.Idstatus == 2 || stat.Idstatus == 4) && tm.Ano == _Ano
            //            select new
            //            {
            //                al.Numaluno,
            //                al.Nome,
            //                al.Sexo,
            //                _classe = cl.Nome,
            //                cl.Idclasse,
            //                _turma = tm.Nome,
            //                tm.Idturma,
            //                _estado = stat.Nome,
            //                al.ApiId,
            //                al.Foto,
            //                al.Idaluno,
            //                Status = stat.Nome,
            //                altm.NumOrdem
            //            };
            foreach (DataRow item in _data.Rows)
            {
                int IsGenero = Convert.ToInt32(item["Sexo"].ToString());
                string _apiID = Convert.ToString(item["Apid"]);
                var _foto = Listalunos.Find(x => x.Numaluno == Convert.ToInt32(item["Num_Aluno"])).Foto;


                aluno = new ObjInfoAluno
                {
                    Numero = Convert.ToInt32(item["Num_Aluno"]),
                    Nome = item["Nome"].ToString(),
                    Genero = Convert.ToBoolean(IsGenero) ? "Femenino" : "Masculino",
                    Classe = item["Classe"].ToString(),

                    Turma = item["Turmas"].ToString(),
                    Estado = item["Estado"].ToString(),     
                    ApiId = _apiID,
                    IdClasse = Convert.ToInt32(item["IDCLASSE"].ToString()),

                    Id_Turma = Convert.ToInt32(item["IDTURMA"].ToString()),
                    FotoByte = (_foto), //item.Foto,
                    NumOrdem = Convert.ToInt32(item["NumOrdem"].ToString())
                };
                alunos.Add(aluno);

            }

            var collections = alunos.DistinctBy(x => x.Numero);
            return collections.DistinctBy(x=>x.Nome); //objList.ToList().FindAll(x => x.Iduser == id);     
        }
    }
}
