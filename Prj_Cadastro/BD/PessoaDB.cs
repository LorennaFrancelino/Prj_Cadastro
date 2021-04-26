using Microsoft.Data.SqlClient;
using Prj_Cadastro.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Prj_Cadastro.Entities
{
    public class PessoaDB : IPessoaDB
    {
        public void addPessoa(Pessoa p)
        {
            using (var cn = new SqlConnection())
            {
                var cmd = new SqlCommand();

                cn.ConnectionString = "Data Source=prj-cadastrodbserver.database.windows.net;Initial Catalog=Prj_Cadastro_db;User ID=sqladmin;Password=********;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO PESSOA (NOME, SOBRENOME, DTNASCIMENTO, EMAIL, CPF, CELULAR, OCUPACAO, DATACADASTRO) " +
                    "VALUES (@nome, @sobrenome, @dtNascimento @email, @cpf, @celular, @ocupacao, @dataCad))";

                cmd.Parameters.AddWithValue("nome", p.Nome);
                cmd.Parameters.AddWithValue("sobrenome", p.Sobrenome);
                cmd.Parameters.AddWithValue("dtNascimento", p.DtNascimento);
                cmd.Parameters.AddWithValue("email", p.Email);
                cmd.Parameters.AddWithValue("cpf", p.CPF);
                cmd.Parameters.AddWithValue("celular", p.Celular);
                cmd.Parameters.AddWithValue("ocupacao", p.Ocupacao);
                cmd.Parameters.AddWithValue("dataCad", DateTime.Now);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void removePessoa(Pessoa p)
        {
            throw new NotImplementedException();
        }

        public void updatePessoa(Pessoa p)
        {
            throw new NotImplementedException();
        }

        public List<Pessoa> listPessoas()
        {
            List<Pessoa> pessoas = new List<Pessoa>();

            string commandText = @"SELECT * FROM dbo.PESSOA";
            using (SqlConnection dbConnection = new SqlConnection(@"Data Source=server;Database=database;Integrated Security=true;"))
            {
                dbConnection.Open();
                using (SqlCommand dbCommand = dbConnection.CreateCommand())
                {
                    dbCommand.CommandText = commandText;
                    using (SqlDataReader reader = dbCommand.ExecuteReader())
                    {
                        while (reader.Read()) 
                        { 
                            pessoas.Add(new Pessoa((string)reader["Nome"], (string)reader["Sobrenome"], (DateTime)reader["DtNascimento"], (string)reader["Email"], (string)reader["Cpf"], (string)reader["Celular"], (string)reader["Ocupacao"], (DateTime)reader["DataCadastro"]));
                        }
                    }
                }
            }
            return pessoas;
        }
    }
}
