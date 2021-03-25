using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoAPI03.Presentation.Models
{
    public class FuncionarioCadastroModel
    {
        [Required(ErrorMessage = "Por favor, informe o nome do funcionário.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Por favor, informe o cpf do funcionário.")]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "Por favor, informe a matrícula do funcionário.")]
        public string Matricula { get; set; }

        [Required(ErrorMessage = "Por favor, informe a data de admissão do funcionário.")]
        public string DataAdmissao { get; set; }

        [Required(ErrorMessage = "Por favor, informe o id da empresa.")]
        public Guid IdEmpresa { get; set; }
    }
}
