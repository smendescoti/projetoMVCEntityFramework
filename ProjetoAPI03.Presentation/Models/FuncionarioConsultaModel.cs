using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoAPI03.Presentation.Models
{
    public class FuncionarioConsultaModel
    {
        public Guid IdFuncionario { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Matricula { get; set; }
        public DateTime DataAdmissao { get; set; }

        public EmpresaConsultaModel Empresa { get; set; }
    }
}
