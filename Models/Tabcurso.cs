using System;
using System.Collections.Generic;

namespace SysgestColegios.Models
{
    public partial class Tabcurso
    {
        public int Idcurso { get; set; }
        public string Nome { get; set; } = null!;
        public int Idciclo { get; set; }
        public bool? Inactivo { get; set; }
        public int Idusr { get; set; }
        public int? Idano { get; set; }
        public int? Idplncurric { get; set; }

        public virtual Tabanoslectivo? IdanoNavigation { get; set; }
        public virtual Tabciclo IdcicloNavigation { get; set; } = null!;
    }
}
