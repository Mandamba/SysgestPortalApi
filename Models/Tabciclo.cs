using System;
using System.Collections.Generic;

namespace SysgestColegios.Models
{
    public partial class Tabciclo
    {
        public Tabciclo()
        {
            Tabclasses = new HashSet<Tabclass>();
            Tabcursos = new HashSet<Tabcurso>();
        }

        public int Idciclo { get; set; }
        public string Nome { get; set; } = null!;
        public bool? Cursos { get; set; }
        public bool? Inactivo { get; set; }
        public int Idusr { get; set; }
        public int? Idano { get; set; }
        public int? Idsubsistemac { get; set; }
        public int? Idsubsistemal { get; set; }
        public bool? ExclCreche { get; set; }

        public virtual Tabanoslectivo? IdanoNavigation { get; set; }
        public virtual ICollection<Tabclass> Tabclasses { get; set; }
        public virtual ICollection<Tabcurso> Tabcursos { get; set; }
    }
}
