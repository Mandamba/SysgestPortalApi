using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SysgestColegios.Data.Procedimento;
using SysgestColegios.Models;
using System.Data;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace SysgestColegios.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetDetalheFacturacaoController : ControllerBase
    {

        [HttpGet(Name = "GetFacturacao")]
        public IEnumerable<FacturacaoDetalhada> GetFacturacao(int value)
        {
            List<FacturacaoDetalhada> facturacaos = new List<FacturacaoDetalhada>();
            FacturacaoDetalhada facturacao = null;
            LitagemFacturacaoDetalhada x_data = new LitagemFacturacaoDetalhada();
            var _data = x_data.GenerateFacturacaoDetalhada(value);
            

            foreach (DataRow item in _data.Rows)
            {                
                facturacao = new FacturacaoDetalhada
                {
                    Familia=item["Familia"].ToString(),
                    Ordem = item["Ordem"].ToString(),
                    Mes = item["Mes"].ToString(),
                    Ano = item["Ano"].ToString(),
                    TotalFacturado = (item["Total Facturado"].ToString()),
                    TotalRecebido = (item["Total Recebido"].ToString())
                };
                facturacaos.Add(facturacao);

                
            }
            return facturacaos;
        }
    }
}
