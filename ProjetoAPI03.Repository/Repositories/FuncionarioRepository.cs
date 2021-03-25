using Dapper;
using ProjetoAPI03.Domain.Entities;
using ProjetoAPI03.Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace ProjetoAPI03.Repository.Repositories
{
    public class FuncionarioRepository : IFuncionarioRepository
    {
        //atributo
        private string connectionstring;

        public void Inserir(Funcionario funcionario)
        {
            var query = @"INSERT INTO FUNCIONARIO(IDFUNCIONARIO, NOME, CPF, MATRICULA, DATAADMISSAO, IDEMPRESA)
                          VALUES(@IDFUNCIONARIO, @NOME, @CPF, @MATRICULA, @DATAADMISSAO, @IDEMPRESA)";

            using (var connection = new SqlConnection(connectionstring))
            {
                connection.Execute(query, funcionario);
            }
        }

        public void Alterar(Funcionario funcionario)
        {
            var query = @"UPDATE FUNCIONARIO SET NOME = @NOME, CPF = @CPF, MATRICULA = @MATRICULA, 
                          DATAADMISSAO = @DATAADMISSAO, IDEMPRESA = @IDEMPRESA 
                          WHERE IDFUNCIONARIO = @IDFUNCIONARIO";

            using (var connection = new SqlConnection(connectionstring))
            {
                connection.Execute(query, funcionario);
            }
        }

        public void Excluir(Funcionario funcionario)
        {
            var query = @"DELETE FROM FUNCIONARIO WHERE IDFUNCIONARIO = @IDFUNCIONARIO";

            using (var connection = new SqlConnection(connectionstring))
            {
                connection.Execute(query, funcionario);
            }
        }

        public List<Funcionario> ObterTodos()
        {
            var query = @"SELECT * FROM FUNCIONARIO ORDER BY NOME";

            using (var connection = new SqlConnection(connectionstring))
            {
                return connection.Query<Funcionario>(query).ToList();
            }
        }

        public Funcionario ObterPorId(Guid id)
        {
            var query = @"SELECT * FROM FUNCIONARIO WHERE IDFUNCIONARIO = @ID";

            using(var connection = new SqlConnection(connectionstring))
            {
                return connection.Query<Funcionario>(query, new { id }).FirstOrDefault();
            }
        }
    }
}
