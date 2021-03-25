using ProjetoAPI03.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoAPI03.Repository.Contracts
{
    public interface IEmpresaRepository
    {
        void Inserir(Empresa empresa);
        void Alterar(Empresa empresa);
        void Excluir(Empresa empresa);

        List<Empresa> ObterTodos();
        Empresa ObterPorId(Guid id);
    }
}
