namespace SysgestColegios.Models
{
    public class FacturacaoDetalhada
    {
        public string Familia { get; set; }
        public string Ordem { get; set; }
        public string Mes { get; set; }
        public string Ano { get; set; }
        public string TotalFacturado { get; set; }
        public string TotalRecebido { get; set; }

    }
}
