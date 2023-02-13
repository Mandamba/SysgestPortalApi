using System;
using System.Collections.Generic;

namespace SysgestColegios.Models
{
    public partial class Tabmatricula
    {
        public int Idmatricula { get; set; }
        public string Numero { get; set; } = null!;
        public int Idaluno { get; set; }
        public int Idanolectivo { get; set; }
        public int Idclasse { get; set; }
        public int? Idcurso { get; set; }
        public int Idturno { get; set; }
        public int Idturma { get; set; }
        public bool Confmatricula { get; set; }
        public bool Anulmatricula { get; set; }
        public int Idbolsa { get; set; }
        public int Idusr { get; set; }
        public DateTime Datamatric { get; set; }
        public bool? Ismatricula { get; set; }
        public string? Motivo { get; set; }
        public int Idstatus { get; set; }
        public bool? FromExtSw { get; set; }
        public bool? MatricInExtSw { get; set; }
        public DateTime? Datamotivo { get; set; }
        public string? Horamatric { get; set; }
        public bool? TurmaFechado { get; set; }
        public DateTime? Datahoranulou { get; set; }
        public int? IdMatriculaAnoAnt { get; set; }
        public string? AnoAnt { get; set; }
        public string? InstituicaoAnoAnt { get; set; }
        public int? IdCicloAnoAnt { get; set; }
        public string? CicloAnt { get; set; }
        public int? IdTurmaAnoAnt { get; set; }
        public string? TurmaAnoAnt { get; set; }
        public int? IdCursoAnoAnt { get; set; }
        public string? CursoAnoAnt { get; set; }
        public int? IdTurnoAnoAnt { get; set; }
        public string? TurnoAnoAnt { get; set; }
        public int? IdClasseAnoAnt { get; set; }
        public string? ClasseAnoAnt { get; set; }
        public bool? WasUpdated { get; set; }

        public virtual Tabaluno IdalunoNavigation { get; set; } = null!;
        public virtual Tabclass IdclasseNavigation { get; set; } = null!;
        public virtual Tabstatus IdstatusNavigation { get; set; } = null!;
        public virtual Tabturma IdturmaNavigation { get; set; } = null!;
        public virtual Tabturno IdturnoNavigation { get; set; } = null!;
    }
}
