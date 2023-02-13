using System;
using System.Collections.Generic;

namespace SysgestColegios.Models
{
    public partial class Tabclass
    {
        public Tabclass()
        {
            Tabmatriculas = new HashSet<Tabmatricula>();
        }

        public int Idclasse { get; set; }
        public string Nome { get; set; } = null!;
        public int Idciclo { get; set; }
        public bool? Inactivo { get; set; }
        public int Idusr { get; set; }
        public int? Idano { get; set; }
        public int? Idplncurric { get; set; }
        public int? Idpdgciclo { get; set; }
        public int? IdadeLimite { get; set; }
        public DateTime? DtIdadeLimite { get; set; }
        public bool? ExclCreche { get; set; }
        public string? DirPedag { get; set; }
        public string? SubDirPedag { get; set; }
        public string? EscolaTutela { get; set; }
        public string? NumEscTutela { get; set; }
        public string? NomeEscolaMapasOfic { get; set; }
        public string? MapOficTit01 { get; set; }
        public string? MapOficTit02 { get; set; }
        public string? MapOficTit03 { get; set; }
        public string? MapOficTit04 { get; set; }
        public string? MapOficTit05 { get; set; }

        public virtual Tabanoslectivo? IdanoNavigation { get; set; }
        public virtual Tabciclo IdcicloNavigation { get; set; } = null!;
        public virtual ICollection<Tabmatricula> Tabmatriculas { get; set; }
    }
}
