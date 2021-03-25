using ProjetoAPI03.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoAPI03.Repository.Contracts
{
    public interface IFuncionarioRepository
    {
        void Inserir(Funcionario funcionario);
        void Alterar(Funcionario funcionario);
        void Excluir(Funcionario funcionario);

        List<Funcionario> ObterTodos();
        Funcionario ObterPorId(Guid id);
    }
}
