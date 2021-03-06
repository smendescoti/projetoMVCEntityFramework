using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoAPI03.Presentation.Models
{
    public class EmpresaCadastroModel
    {
        [Required(ErrorMessage = "Por favor, informe a razão social da empresa.")]
        public string RazaoSocial { get; set; }

        [Required(ErrorMessage = "Por favor, informe o cnpj da empresa.")]
        public string Cnpj { get; set; }
    }
}
