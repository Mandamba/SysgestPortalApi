using Microsoft.Data.SqlClient;
using System.Data;

namespace SysgestColegios.Data.Procedimento
{
    public class QtdVagas_Turmas
    {
        public DataTable Qtd_Vagas(int value)
        {
            var query = string.Format("SELECT TABTURMAS.NOME [TURMA], COUNT(TABMATRICULAS.IDMATRICULA) [QTD], [VAGAS] = NUMVAGAS - COUNT(TABMATRICULAS.IDMATRICULA) FROM TABALUNOS INNER JOIN TABMATRICULAS ON TABMATRICULAS.IDALUNO = TABALUNOS.IDALUNO INNER JOIN TABCLASSES ON TABCLASSES.IDCLASSE = TABMATRICULAS.IDCLASSE INNER JOIN TABCICLOS ON TABCICLOS.IDCICLO = TABCLASSES.IDCICLO INNER JOIN TABTURMAS ON TABTURMAS.IDTURMA = TABMATRICULAS.IDTURMA INNER JOIN TABTURNOS ON TABTURNOS.IDTURNO = TABMATRICULAS.IDTURNO LEFT JOIN TABCURSOS ON TABCURSOS.IDCURSO = TABMATRICULAS.IDCURSO LEFT JOIN TABSTATUS s on TABALUNOS.IDSTATUS = s.IDSTATUS WHERE TABALUNOS.INACTIVO = 0 AND TABMATRICULAS.IDSTATUS in (2,4) AND TABMATRICULAS.IDANOLECTIVO = (SELECT MAX(IDANO) FROM TABANOSLECTIVOS WHERE INACTIVO = 0) AND TABMATRICULAS.IDTURMA IN (SELECT IDTURMA FROM tb_ProfessorTurma WHERE IDUSER = {0}) GROUP BY TABTURMAS.NOME, NUMVAGAS", value);
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
