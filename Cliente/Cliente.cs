using System;
using System.Data;

namespace Cliente
{
    public class Cliente
    {
        private string Nome;
        private string Cpf;
        private string TipoInvestidor;
        private decimal Saldo;

        public Cliente() { }

        public Cliente(string nome, string cpf, string tipoInvestidor, decimal saldo)
        {
            Nome = nome;
            Cpf = cpf;
            TipoInvestidor = tipoInvestidor;
            Saldo = saldo;
        }

        public void InserirCliente()
        {
            Conexao.Conexao con = new Conexao.Conexao();

            con.LimparParametros();

            string query = "INSERT INTO Cliente_tb (Nome, Cpf) VALUES (@Nome, @Cpf)";

            con.AdicionarParametro("@Nome", System.Data.SqlDbType.NVarChar, Nome);
            con.AdicionarParametro("@Cpf", System.Data.SqlDbType.NVarChar, Cpf);

            int rowAffected = con.ExecutaAtualizacao(query);

            if (rowAffected == 1)
            {
                int id = ObterIdRegistrado(Cpf);

                Conta.Conta conta = new Conta.Conta(id,Saldo,TipoInvestidor);

                conta.RegisterAccount();
            } 
            else
            {
                throw new Exception("Não foi possível registrar o cliente");
            }    
        }

        public int ObterIdRegistrado(string cpf)
        {
            Conexao.Conexao con = new Conexao.Conexao();

            con.LimparParametros();

            string query = "SELECT IdCliente FROM Cliente_tb WHERE Cpf = @Cpf";

            con.AdicionarParametro("@Cpf", System.Data.SqlDbType.NVarChar, cpf);

            object result = con.ExecutaScalar(query);

            return result == null ? 0 : (int)result;
        }

        public DataTable ObterContaCliente()
        {
            Conexao.Conexao con = new Conexao.Conexao();

            con.LimparParametros();

            string query = "SELECT a.idCliente, " +
                           "        b.idConta, " +
                           "        a.Nome, " +
                           "        FORMAT(a.dtCadastro,'dd/MM/yy') [Data Cadastro], " +
                           "        SUBSTRING(a.Cpf, 1, 3) + '.' + " +
                           "        SUBSTRING(a.Cpf, 4, 3) + '.' + " +
                           "        SUBSTRING(a.Cpf, 7, 3) + '-' + " +
                           "        SUBSTRING(a.Cpf, 10, 2)[CPF], " +
                           "        b.Agencia[Ag.], " +
                           "        b.Banco, " +
                           "        b.Saldo, " +
                           "        CASE WHEN b.TipoInvestidor = 'A' " +
                           "         THEN 'Arrojado' " +
                           "             WHEN b.TipoInvestidor = 'M'  " +
                           "         THEN 'Moderado' " +
                           "             WHEN b.TipoInvestidor = 'C' " +
                           "         THEN 'Conservador' END[Tipo Invest.] " +
                           " FROM Cliente_tb a " +
                           " INNER JOIN Conta_tb b ON a.idCliente = b.idCliente" +
                           " ORDER BY a.Nome, a.Cpf, b.TipoInvestidor";

            return con.ExecutaConsulta(query);
        }

        public bool ValidarTamanhoCpf(string cpf)
        {
            return cpf.Length == 11;
        }

        public bool ValidarCpfRegistrado(string cpf)
        {
            Conexao.Conexao con = new Conexao.Conexao();

            con.LimparParametros();

            string query = "SELECT Cpf FROM Cliente_tb WHERE Cpf LIKE @Cpf";

            con.AdicionarParametro("@Cpf", System.Data.SqlDbType.NVarChar, cpf);

            object result = con.ExecutaScalar(query);

            return (string)result != cpf;
        }

    }
}
