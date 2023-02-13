using System;
using System.Collections.Generic;

namespace SysgestColegios.Models
{
    public partial class Tdocente
    {
        public int Id { get; set; }
        public int Numdocente { get; set; }
        public string Nome { get; set; } = null!;
        public string? Morada { get; set; }
        public string? Localidade { get; set; }
        public string? Codpostal { get; set; }
        public string? Bairro { get; set; }
        public string? Comuna { get; set; }
        public string? Municipio { get; set; }
        public int? Idrovincia { get; set; }
        public int? Idnacionalidade { get; set; }
        public DateTime? Datanasc { get; set; }
        public int Sexo { get; set; }
        public string? Telefone { get; set; }
        public string? Telemovel { get; set; }
        public string? Email { get; set; }
        public int? Idtipodoc { get; set; }
        public DateTime? Dataemissdoc { get; set; }
        public string Localemissdoc { get; set; } = null!;
        public string Numdoc { get; set; } = null!;
        public DateTime? Validadedoc { get; set; }
        public int? Idpaisemissdoc { get; set; }
        public string? Nif { get; set; }
        public string? Nib { get; set; }
        public string? Iban { get; set; }
        public bool Inactivo { get; set; }
        public int Idusr { get; set; }
        public string? Observacoes { get; set; }
        public byte[]? Foto { get; set; }
        public int? IdEstadoCivil { get; set; }
        public bool IsExterno { get; set; }
        public string? Profissao { get; set; }
        public string? Funcao { get; set; }
        public string? AreaEnsino { get; set; }
        public string? HabLiter { get; set; }
        public DateTime? DtAdmissao { get; set; }
        public DateTime? DtIniContrato { get; set; }
        public DateTime? DtFimContrato { get; set; }
        public bool Deleted { get; set; }
        public int? PaisIdPais { get; set; }
        public int? ProvinciaIdprovincia { get; set; }
        public int? DocumentoPessoalIdDocumentoPessoal { get; set; }
        public string? ApiId { get; set; }
        public bool AppSync { get; set; }
    }
}
