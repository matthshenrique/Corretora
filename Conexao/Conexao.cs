using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Common;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Conexao
{
    public class Conexao
    {
        private static string connectionString = @"server=NomeDoSeuServidorSqlServer\SQLEXPRESS; Database=TurimDB;Integrated Security=SSPI";
        public static SqlConnection sqlconnection = new SqlConnection();
        public static SqlCommand command = new SqlCommand();
        public static SqlParameter parameter = new SqlParameter();

        public static SqlConnection Connection()
        {
            try
            {
                sqlconnection = new SqlConnection(connectionString);
                if (sqlconnection.State == ConnectionState.Closed)
                {
                    sqlconnection.Open();
                }
                return sqlconnection;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public void Open()
        {
            sqlconnection.Open();
        }

        public void Close()
        {
            sqlconnection.Close();
        }

        public void AdicionarParametro(string nome,
        SqlDbType tipo, int tamanho, object valor)
        {
            parameter = new SqlParameter
            {
                ParameterName = nome,
                SqlDbType = tipo,
                Size = tamanho,
                Value = valor
            };
            command.Parameters.Add(parameter);
        }

        public void AdicionarParametro(string nome, SqlDbType tipo, object valor)
        {
            SqlParameter parametro = new SqlParameter
            {
                ParameterName = nome,
                SqlDbType = tipo,
                Value = valor
            };
            command.Parameters.Add(parametro);
        }

        public void RemoverParametro(string pNome)
        {
            if (command.Parameters.Contains(pNome))
                command.Parameters.Remove(pNome);
        }

        public void LimparParametros()
        {
            command.Parameters.Clear();
        }

        public DataTable ExecutaConsulta(string sql)
        {
            try
            {
                command.Connection = Connection();
                command.CommandText = sql;
                command.ExecuteScalar();
                IDataReader dtreader = command.ExecuteReader();
                DataTable dtresult = new DataTable();
                dtresult.Load(dtreader);
                sqlconnection.Close();
                return dtresult;
            }
            catch (Exception ex)
            {
                // Retorna uma exceção simples que pode ser tratada por parte do desenvolvedor
                // Exemplo: if (ex.Message.toString().Contains(‘Networkig’))
                // Exemplo throw new Exception(‘Problema de rede detectado’);
                throw ex;
            }
        }

        public int ExecutaAtualizacao(string sql)
        {
            try
            {
                //Instância o sqlcommand com a query sql que será executada e a conexão.
                //comando = new SqlCommand(sql, connection());
                command.Connection = Connection();
                command.CommandText = sql;
                int result = command.ExecuteNonQuery();
                sqlconnection.Close();
                return result;
            }
            catch (Exception ex)
            {
                // Retorna uma exceção simples que pode ser tratada por parte do desenvolvedor
                throw ex;
            }
        }

        public object ExecutaScalar(string sql)
        {
            try
            {
                //Instância o sqlcommand com a query sql que será executada e a conexão.
                //comando = new SqlCommand(sql, connection());
                command.Connection = Connection();
                command.CommandText = sql;
                object result = command.ExecuteScalar();
                sqlconnection.Close();
                return result;
            }
            catch (Exception ex)
            {
                // Retorna uma exceção simples que pode ser tratada por parte do desenvolvedor
                throw ex;
            }
        }
    }
}
