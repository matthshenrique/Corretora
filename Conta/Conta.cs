using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Conexao;

namespace Conta
{
    public class Conta
    {
        private static int IdCliente = 0;
        private static string Banco = "Corretora ABCD" ;
        private static string Agencia = "1714";
        private static string TipoInvestidor;
        private static decimal Saldo;     

        public Conta() { }

        public Conta(int idCliente, decimal saldo, string tipoInvestidor) 
        {
            IdCliente = idCliente;
            Saldo = saldo;
            TipoInvestidor = tipoInvestidor;            
        }

        public void RegisterAccount()
        {
            Conexao.Conexao con = new Conexao.Conexao();

            con.LimparParametros();

            string query = "INSERT INTO Conta_tb (Banco, Agencia, Saldo, TipoInvestidor, idCliente) " +
                           "VALUES (@Banco, @Agencia, @Saldo, @TipoInvestidor, @idCliente)";   

            con.AdicionarParametro("@Banco", System.Data.SqlDbType.NVarChar, Banco);
            con.AdicionarParametro("@Agencia", System.Data.SqlDbType.NVarChar, Agencia);
            con.AdicionarParametro("@Saldo", System.Data.SqlDbType.Decimal, Saldo);
            con.AdicionarParametro("@TipoInvestidor", System.Data.SqlDbType.NVarChar, TipoInvestidor);
            con.AdicionarParametro("@idCliente", System.Data.SqlDbType.NVarChar, IdCliente);

            con.ExecutaAtualizacao(query);
        }

        public void Depositar(decimal valor, int conta)
        {
            Conexao.Conexao con = new Conexao.Conexao();

            con.LimparParametros();

            string query = "UPDATE Conta_tb SET Saldo = Saldo + @Saldo WHERE idConta = @Conta";

            con.AdicionarParametro("@Saldo", System.Data.SqlDbType.Decimal, valor);
            con.AdicionarParametro("@Conta", System.Data.SqlDbType.NVarChar, conta);

            con.ExecutaAtualizacao(query);
        }

        public void Resgatar(decimal valor, int conta)
        {
            Conexao.Conexao con = new Conexao.Conexao();

            con.LimparParametros();

            string query = "UPDATE Conta_tb SET Saldo = Saldo - @Saldo WHERE idConta = @Conta";

            con.AdicionarParametro("@Saldo", System.Data.SqlDbType.Decimal, valor);
            con.AdicionarParametro("@Conta", System.Data.SqlDbType.NVarChar, conta);

            con.ExecutaAtualizacao(query);
        }

        public decimal ObterSaldo(int conta)
        {
            Conexao.Conexao con = new Conexao.Conexao();

            con.LimparParametros();

            string query = "SELECT Saldo FROM Conta_tb WHERE idConta = @Conta";

            con.AdicionarParametro("@Conta", System.Data.SqlDbType.NVarChar, conta);

            return (decimal)con.ExecutaScalar(query);
        }

        public string ObterTipoInvestidor(int conta)
        {
            Conexao.Conexao con = new Conexao.Conexao();

            con.LimparParametros();

            string query = "SELECT TipoInvestidor FROM Conta_tb WHERE idConta = @Conta";

            con.AdicionarParametro("@Conta", System.Data.SqlDbType.NVarChar, conta);

            return (string)con.ExecutaScalar(query);
        }
    }
}
