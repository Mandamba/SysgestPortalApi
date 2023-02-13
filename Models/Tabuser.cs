using System;
using System.Collections.Generic;

namespace SysgestColegios.Models
{
    public partial class Tabuser
    {
        public Tabuser()
        {
            TbProfessorTurmas = new HashSet<TbProfessorTurma>();
        }

        public int Iduser { get; set; }
        public string Iniciais { get; set; } = null!;
        public string Nome { get; set; } = null!;
        public string? Userlogin { get; set; }
        public string? Userpassword { get; set; }
        public bool? Inactivo { get; set; }
        public bool? Useradmin { get; set; }
        public int Idusr { get; set; }
        public bool? Abrecaixa { get; set; }
        public int? IdPerfilAcesso { get; set; }
        public string? NomePerfilAcesso { get; set; }
        public byte[]? PassHs { get; set; }
        public Guid? SaltPw { get; set; }
        public bool? Mudarpwd { get; set; }
        public bool IsDocente { get; set; }
        public int? IdDocente { get; set; }
        public bool? IsSuperAdmin { get; set; }

        public virtual ICollection<TbProfessorTurma> TbProfessorTurmas { get; set; }
    }
}
