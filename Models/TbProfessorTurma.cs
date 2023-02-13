using System;
using System.Collections.Generic;

namespace SysgestColegios.Models
{
    public partial class TbProfessorTurma
    {
        public int IdProfessorTurma { get; set; }
        public int Iduser { get; set; }
        public int Idturma { get; set; }
        public DateTime? DataRegisto { get; set; }

        public virtual Tabturma IdturmaNavigation { get; set; } = null!;
        public virtual Tabuser IduserNavigation { get; set; } = null!;
    }
}
