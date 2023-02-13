using System;
using System.Collections.Generic;

namespace SysgestColegios.Models
{
    public partial class Tabturma
    {
        public Tabturma()
        {
            Tabmatriculas = new HashSet<Tabmatricula>();
            TbProfessorTurmas = new HashSet<TbProfessorTurma>();
        }

        public int Idturma { get; set; }
        public string Nome { get; set; } = null!;
        public int Idclasse { get; set; }
        public int? Idcurso { get; set; }
        public int Idturno { get; set; }
        public int Numvagas { get; set; }
        public int Ano { get; set; }
        public bool? Inactivo { get; set; }
        public int Idusr { get; set; }
        public string? Sala { get; set; }
        public int? Idano { get; set; }
        public int? Idplncurric { get; set; }
        public bool? TurmaFechada { get; set; }
        public DateTime? DtFechada { get; set; }
        public bool? ExclCreche { get; set; }
        public string? Horafecho { get; set; }
        public bool? Filldatatemp { get; set; }
        public string? HoraFechoTurma { get; set; }
        public bool? IsChecked { get; set; }
        public int? IdClasseCicloL { get; set; }
        public int? IdDocenteDt { get; set; }
        public bool? AlunosChecked { get; set; }
        public string? ApiId { get; set; }
        public bool AppSync { get; set; }

        public virtual Tabanoslectivo? IdanoNavigation { get; set; }
        public virtual ICollection<Tabmatricula> Tabmatriculas { get; set; }
        public virtual ICollection<TbProfessorTurma> TbProfessorTurmas { get; set; }
    }
}
