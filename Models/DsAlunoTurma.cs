using System;
using System.Collections.Generic;

namespace SysgestColegios.Models
{
    public partial class DsAlunoTurma
    {
        public int IdDsAlunoTurma { get; set; }
        public int IdAluno { get; set; }
        public int NumAluno { get; set; }
        public string? Nome { get; set; }
        public int IdTurma { get; set; }
        public int IdAno { get; set; }
        public int IdMatriucla { get; set; }
        public int? NumOrdem { get; set; }
        public int? IdStatus { get; set; }
        public bool IsNewInTurma { get; set; }
        public bool IsReturn { get; set; }
        public bool? ListarAluno { get; set; }
        public bool IsAnulado { get; set; }
        public bool IsTransferido { get; set; }
        public DateTime? DataEntrAnt { get; set; }
        public string? HoraEntrAnt { get; set; }
        public DateTime? DataEntrada { get; set; }
        public string? HoraEntrada { get; set; }
        public DateTime? DataSaida { get; set; }
        public string? HoraSaida { get; set; }
        public DateTime? DataAnulacao { get; set; }
        public string? HoraAnulacao { get; set; }
        public bool IsDefaultFromLog { get; set; }
        public string? Observacoes { get; set; }
        public bool? Bloqueado { get; set; }
        public DateTime? DataRegisto { get; set; }
        public DateTime? DataAlter { get; set; }
        public string? TimeRegist { get; set; }
        public string? TimeAlter { get; set; }
        public int? IdUserRegisto { get; set; }
        public int? IdUserAlter { get; set; }
        public DateTime? DateDeleted { get; set; }
        public int? IdUserDel { get; set; }
        public bool? Deleted { get; set; }
        public string? TimeDeleted { get; set; }
        public string? Status { get; set; }
    }
}
