using System;
using System.Collections.Generic;

namespace SysgestColegios.Models
{
    public partial class LogTorniquete
    {
        public int IdLogTorniquete { get; set; }
        public int? IdCartaoAcesso { get; set; }
        public int? IdCartaoEntity { get; set; }
        public string? Codigo { get; set; }
        public bool IsAluno { get; set; }
        public bool IsFuncionario { get; set; }
        public bool IsDocente { get; set; }
        public int? IdEntidade { get; set; }
        public int? NumInterno { get; set; }
        public string? NomeEntidade { get; set; }
        public int? IdClasse { get; set; }
        public string? Classe { get; set; }
        public int? IdTurma { get; set; }
        public string? Turma { get; set; }
        public string? Departamento { get; set; }
        public string? Funcao { get; set; }
        public bool IsExterno { get; set; }
        public DateTime DataRegisto { get; set; }
        public string? HoraRegisto { get; set; }
        public int? IdTurno { get; set; }
        public string? Turno { get; set; }
        public int ActionType { get; set; }
        public string? DescrActionType { get; set; }
        public int GatewayNum { get; set; }
        public string? GatewayName { get; set; }
        public byte[]? Foto { get; set; }
        public bool AcessoLivre { get; set; }
        public bool AcessoCondicionado { get; set; }
        public bool? Allowed { get; set; }
        public int? IdAluno { get; set; }
        public string? CardAcompIfIsAluno { get; set; }
        public string? CardAlunoIfIsGuardian { get; set; }
        public string? GuardianName { get; set; }
        public string? ApiId { get; set; }
        public bool AppSync { get; set; }
        public int? IdTorniquete { get; set; }
        public string? TipoTorniquete { get; set; }

        public virtual Tabaluno? IdAlunoNavigation { get; set; }
    }
}
