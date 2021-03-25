using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoAPI03.Domain.Entities
{
    public class Empresa
    {
        //Propriedades
        public Guid IdEmpresa { get; set; }
        public string RazaoSocial { get; set; }
        public string Cnpj { get; set; }

        //Relacionamentos
        public List<Funcionario> Funcionarios { get; set; }
    }
}
