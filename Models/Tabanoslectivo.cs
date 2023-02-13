using System;
using System.Collections.Generic;

namespace SysgestColegios.Models
{
    public partial class Tabanoslectivo
    {
        public Tabanoslectivo()
        {
            Tabciclos = new HashSet<Tabciclo>();
            Tabclasses = new HashSet<Tabclass>();
            Tabcursos = new HashSet<Tabcurso>();
            Tabturmas = new HashSet<Tabturma>();
            Tabturnos = new HashSet<Tabturno>();
        }

        public int Idano { get; set; }
        public int Ano { get; set; }
        public DateTime Dataprevinicio { get; set; }
        public DateTime Dataprevfim { get; set; }
        public DateTime? Datainicio { get; set; }
        public DateTime? Datafim { get; set; }
        public bool? Inactivo { get; set; }
        public bool? Fechado { get; set; }
        public int Idusr { get; set; }
        public DateTime? Datainip1 { get; set; }
        public DateTime? Datafimp1 { get; set; }
        public DateTime? Datainip2 { get; set; }
        public DateTime? Datafimp2 { get; set; }
        public DateTime? Datainip3 { get; set; }
        public DateTime? Datafimp3 { get; set; }
        public bool P1fechado { get; set; }
        public bool P2fechado { get; set; }
        public bool P3fechado { get; set; }
        public string? TextAnoLectivo { get; set; }

        public virtual ICollection<Tabciclo> Tabciclos { get; set; }
        public virtual ICollection<Tabclass> Tabclasses { get; set; }
        public virtual ICollection<Tabcurso> Tabcursos { get; set; }
        public virtual ICollection<Tabturma> Tabturmas { get; set; }
        public virtual ICollection<Tabturno> Tabturnos { get; set; }
    }
}
