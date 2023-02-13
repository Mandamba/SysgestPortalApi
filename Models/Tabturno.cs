using System;
using System.Collections.Generic;

namespace SysgestColegios.Models
{
    public partial class Tabturno
    {
        public Tabturno()
        {
            Tabmatriculas = new HashSet<Tabmatricula>();
        }

        public int Idturno { get; set; }
        public string? Nome { get; set; }
        public bool? Inactivo { get; set; }
        public int Idusr { get; set; }
        public string? Hinicio { get; set; }
        public string? Hfim { get; set; }
        public int? Idano { get; set; }
        public bool? ExclCreche { get; set; }

        public virtual Tabanoslectivo? IdanoNavigation { get; set; }
        public virtual ICollection<Tabmatricula> Tabmatriculas { get; set; }
    }
}
