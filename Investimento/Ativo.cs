using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Conexao;

namespace Investimento
{
    public class Ativo
    {
        public DataTable ObterAtivos() 
        {
            Conexao.Conexao con = new Conexao.Conexao();

            con.LimparParametros();

            string query = "SELECT * FROM Ativo_tb";

            return con.ExecutaConsulta(query);
        }

        public decimal ObterValorAtivo(int idAtivo)
        {
            Conexao.Conexao con = new Conexao.Conexao();

            con.LimparParametros();

            string query = "SELECT Valor FROM Ativo_tb WHERE idAtivo = @Ativo";

            con.AdicionarParametro("@Ativo", System.Data.SqlDbType.NVarChar, idAtivo);

            return (decimal)con.ExecutaScalar(query);
        }
    }
}
