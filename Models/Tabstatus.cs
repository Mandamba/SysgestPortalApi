using System;
using System.Collections.Generic;

namespace SysgestColegios.Models
{
    public partial class Tabstatus
    {
        public Tabstatus()
        {
            Tabalunos = new HashSet<Tabaluno>();
            Tabmatriculas = new HashSet<Tabmatricula>();
        }

        public int Idstatus { get; set; }
        public string Nome { get; set; } = null!;
        public bool Inactivo { get; set; }
        public int Idusr { get; set; }
        public string? Codigo { get; set; }
        public string? Resumo { get; set; }

        public virtual ICollection<Tabaluno> Tabalunos { get; set; }
        public virtual ICollection<Tabmatricula> Tabmatriculas { get; set; }
    }
}
