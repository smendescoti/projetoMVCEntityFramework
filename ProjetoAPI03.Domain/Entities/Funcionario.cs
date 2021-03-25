using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoAPI03.Domain.Entities
{
    public class Funcionario
    {
        //propriedades..
        public Guid IdFuncionario { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Matricula { get; set; }
        public DateTime DataAdmissao { get; set; }
        public Guid IdEmpresa { get; set; } //foreign key no banco de dados

        //relacionamentos..
        public Empresa Empresa { get; set; }
    }
}
