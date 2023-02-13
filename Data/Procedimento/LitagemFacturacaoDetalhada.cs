using Microsoft.Data.SqlClient;
using System.Data;

namespace SysgestColegios.Data.Procedimento
{
    public class LitagemFacturacaoDetalhada
    {
        public DataTable GenerateFacturacaoDetalhada(int value)
        {
            var query = string.Format("exec sp_LitagemFacturacaoDetalhada {0}", value);
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection("Data Source=srv\\SYSGEST;initial Catalog=sysgest_colegios;User Id=sa;Password=1234qwer.;"))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            dataTable.Load(reader);
                        }
                    }

                    return dataTable;
                }
                catch (Exception ex)
                {
                    throw;
                }
                finally
                {
                    connection.Close();
                }
            }
        }

    }
}
