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
    public class EmpresaRepository : IEmpresaRepository
    {
        //atributo
        private string connectionstring;

        public void Inserir(Empresa empresa)
        {
            var query = @"INSERT INTO EMPRESA(IDEMPRESA, RAZAOSOCIAL, CNPJ)
                          VALUES(@IDEMPRESA, @RAZAOSOCIAL, @CNPJ)";

            using (var connection = new SqlConnection(connectionstring))
            {
                connection.Execute(query, empresa);
            }
        }

        public void Alterar(Empresa empresa)
        {
            var query = @"UPDATE EMPRESA SET RAZAOSOCIAL = @RAZAOSOCIAL, CNPJ = @CNPJ 
                          WHERE IDEMPRESA = @IDEMPRESA";

            using (var connection = new SqlConnection(connectionstring))
            {
                connection.Execute(query, empresa);
            }
        }

        public void Excluir(Empresa empresa)
        {
            var query = "DELETE FROM EMPRESA WHERE IDEMPRESA = @IDEMPRESA";

            using (var connection = new SqlConnection(connectionstring))
            {
                connection.Execute(query, empresa);
            }
        }

        public List<Empresa> ObterTodos()
        {
            var query = @"SELECT * FROM EMPRESA ORDER BY RAZAOSOCIAL";

            using (var connection = new SqlConnection(connectionstring))
            {
                return connection.Query<Empresa>(query).ToList();
            }
        }

        public Empresa ObterPorId(Guid id)
        {
            var query = @"SELECT * FROM EMPRESA WHERE IDEMPRESA = @ID";

            using (var connection = new SqlConnection(connectionstring))
            {
                return connection.Query<Empresa>(query, new { id }).FirstOrDefault();
            }
        }
    }
}
