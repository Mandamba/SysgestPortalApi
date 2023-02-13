using System;
using System.Collections.Generic;

namespace SysgestColegios.Models
{
    public partial class Tabaluno
    {
        public Tabaluno()
        {
            LogTorniquetes = new HashSet<LogTorniquete>();
            Tabmatriculas = new HashSet<Tabmatricula>();
        }

        public int Idaluno { get; set; }
        public int Numaluno { get; set; }
        public string Nome { get; set; } = null!;
        public string? Morada { get; set; }
        public string? Bairro { get; set; }
        public string? Comuna { get; set; }
        public string? Municipio { get; set; }
        public int? Idprovincia { get; set; }
        public DateTime Datanasc { get; set; }
        public string Sexo { get; set; } = null!;
        public string Tipoaluno { get; set; } = null!;
        public string? Telefone { get; set; }
        public string? Email { get; set; }
        public int? Idpaisorigem { get; set; }
        public string Citipo { get; set; } = null!;
        public DateTime Cidata { get; set; }
        public string Cilocal { get; set; } = null!;
        public string Cinumero { get; set; } = null!;
        public DateTime Civalidade { get; set; }
        public int? Ciidpais { get; set; }
        public string? Contribnumero { get; set; }
        public int? Idbolsa { get; set; }
        public string? Oinomepai { get; set; }
        public string? Oitelfpai { get; set; }
        public string? Oinomemae { get; set; }
        public string? Oitelfmae { get; set; }
        public string? Oiemailpai { get; set; }
        public string? Oiemailmae { get; set; }
        public string Oiencarregado { get; set; } = null!;
        public string? Oinomeencarg { get; set; }
        public string? Oitelfencarg { get; set; }
        public string? Oiparentesco { get; set; }
        public byte[]? Foto { get; set; }
        public string? Observacoes { get; set; }
        public bool Inactivo { get; set; }
        public bool? Anulmatricula { get; set; }
        public int Idusr { get; set; }
        public int Idstatus { get; set; }
        public bool Outrodesc { get; set; }
        public decimal? Outrodescperc { get; set; }
        public string? Outrodescnome { get; set; }
        public bool? PrecCob { get; set; }
        public bool? MrecCob { get; set; }
        public bool? OrecCob { get; set; }
        public string? Oiemailenc { get; set; }
        public string? Pairesidencia { get; set; }
        public string? Maeresidencia { get; set; }
        public string? Eedresidencia { get; set; }
        public string? Paiprofissao { get; set; }
        public string? Maeprofissao { get; set; }
        public string? Eedprofissao { get; set; }
        public bool HasNecEducEspec { get; set; }
        public bool ObsEii { get; set; }
        public bool QuerAtl { get; set; }
        public bool QuerTranspEsc { get; set; }
        public bool QuerAulasRef { get; set; }
        public bool QuerRefeitorio { get; set; }
        public int? IdPaiNaturalidade { get; set; }
        public int? IdMaeNaturalidade { get; set; }
        public int? IdEedcNaturalidade { get; set; }
        public string? PaiNaturalidade { get; set; }
        public string? MaeNaturalidade { get; set; }
        public string? EedcNaturalidade { get; set; }
        public string? PaiLocalTrab { get; set; }
        public string? MaeLocalTrab { get; set; }
        public string? EedcLocalTrab { get; set; }
        public bool HasAlergias { get; set; }
        public string? DescrAlergias { get; set; }
        public bool RequerCes { get; set; }
        public string? CuidEspecSaude { get; set; }
        public bool HasDoencasCronic { get; set; }
        public string? DescDoenCronic { get; set; }
        public bool CanAdmiMedic { get; set; }
        public string? DcanAdminMedic { get; set; }
        public bool HasRstritAliment { get; set; }
        public string? DrstritAliment { get; set; }
        public int? IdEstadoCivilPai { get; set; }
        public int? IdEstadoCivilMae { get; set; }
        public int? IdEstadoCivilEed { get; set; }
        public bool TemLimiteSaldoDia { get; set; }
        public decimal LimiteSaldoDia { get; set; }
        public string? ApiId { get; set; }
        public bool AppSync { get; set; }
        public bool UsaAppSync { get; set; }
        public bool PaiUsaApp { get; set; }
        public bool MaeUsaApp { get; set; }
        public bool EncUsaApp { get; set; }

        public virtual Tabstatus IdstatusNavigation { get; set; } = null!;
        public virtual ICollection<LogTorniquete> LogTorniquetes { get; set; }
        public virtual ICollection<Tabmatricula> Tabmatriculas { get; set; }
    }
}
