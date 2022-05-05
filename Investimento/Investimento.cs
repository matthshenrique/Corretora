using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investimento
{
    public class Investimento
    {
        public DataTable ObterInvestimentos()
        {
            Conexao.Conexao con = new Conexao.Conexao();

            con.LimparParametros();

            string query = "SELECT a.IdInvestimento, " +
                           "     c.IdConta, " +
                           "     d.Nome [Cliente], " +
                           "     CASE WHEN c.TipoInvestidor = 'A' " +
                           "     THEN 'Arrojado' " +
                           "         WHEN c.TipoInvestidor = 'M' " +
                           "     THEN 'Moderado' " +
                           "         WHEN c.TipoInvestidor = 'C'" +
                           "     THEN 'Conservador' END[Tipo Invest.], " +
                           "	 b.Nome[Ativo], " +
                           "	 a.Valor[Valor Investido] " +
                           "FROM Investimento_tb a " +
                           "INNER JOIN Ativo_tb b ON a.idAtivo = b.idAtivo " +
                           "INNER JOIN Conta_tb c ON a.IdConta = c.idConta " +
                           "INNER JOIN Cliente_tb d ON c.idCliente = d.idCliente ";

            return con.ExecutaConsulta(query);
        }

        public bool VerificarValorAInvestir(string tipoInvestidor, decimal saldo, decimal valorInvestimento)
        {
            return (tipoInvestidor != "A") || (valorInvestimento <= FormulaInvestir(saldo)) ? true : false;
        }

        private decimal FormulaInvestir(decimal saldo)
        {
            return ((saldo / 100) * 70);
        }

        public bool VerificarValorAtivoInvestimento(string tipoInvestidor, decimal saldo, decimal valorAtivo )
        {
            int porcentagem = VerificarPorcentagem(tipoInvestidor);
            decimal percentSaldo = ((decimal)((double)porcentagem / 100) * saldo);

            return valorAtivo <= (percentSaldo / 12) ? true : false;
        }

        private int VerificarPorcentagem(string tipoInvestidor)
        {
            if (tipoInvestidor == "A")
            {
                return 70;
            }
            else if (tipoInvestidor == "M")
            {
                return 50;
            }
            else
            {
                return 30;
            }
        }

        public void DebitarSaldoInvestir(int conta, decimal valor)
        {
            Conexao.Conexao con = new Conexao.Conexao();

            con.LimparParametros();

            string query = "UPDATE Conta_tb SET Saldo = Saldo - @Valor WHERE idConta = @Conta ";

            con.AdicionarParametro("@Conta", System.Data.SqlDbType.Int, conta);
            con.AdicionarParametro("@Valor", System.Data.SqlDbType.Decimal, valor);

            con.ExecutaAtualizacao(query);
        }

        public void CreditarSaldoVendaAtivo(int conta, decimal valor)
        {
            Conexao.Conexao con = new Conexao.Conexao();

            con.LimparParametros();

            string query = "UPDATE Conta_tb SET Saldo = Saldo + @Valor WHERE idConta = @Conta ";

            con.AdicionarParametro("@Conta", System.Data.SqlDbType.Int, conta);
            con.AdicionarParametro("@Valor", System.Data.SqlDbType.Decimal, valor);

            con.ExecutaAtualizacao(query);
        }

        public void Investir(int conta, int ativo, decimal valor)
        {
            Conexao.Conexao con = new Conexao.Conexao();

            con.LimparParametros();

            string query = "INSERT INTO Investimento_tb (IdConta, idAtivo, Valor) VALUES (@Conta, @Ativo, @Valor)";

            con.AdicionarParametro("@Conta", System.Data.SqlDbType.Int, conta);
            con.AdicionarParametro("@Ativo", System.Data.SqlDbType.Int, ativo);
            con.AdicionarParametro("@Valor", System.Data.SqlDbType.Decimal, valor);

            con.ExecutaAtualizacao(query);
        }

        public void VenderAtivo(int investimento)
        {
            Conexao.Conexao con = new Conexao.Conexao();

            con.LimparParametros();

            string query = "DELETE FROM Investimento_tb WHERE IdInvestimento = @Id";

            con.AdicionarParametro("@Id", System.Data.SqlDbType.Int, investimento);

            con.ExecutaAtualizacao(query);
        }
    }
}
