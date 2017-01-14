using EstudoDDD.Domain.Entities;
using EstudoDDD.Domain.Interfaces.Servicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EstudoDDD.Domain.Interfaces.Repositories;

namespace EstudoDDD.Domain.Services
{
    public class ServiceProduto : ServiceBase<Produto>, IServiceProduto
    {
        private readonly IRepositoryProduto _repositoryProduto;

        public ServiceProduto(IRepositoryProduto repositoryProduto) : base(repositoryProduto)
        {
            _repositoryProduto = repositoryProduto;
        }

        public IEnumerable<Produto> BuscarPorNome(string nome)
        {
            return _repositoryProduto.BuscarPorNome(nome);
        }
    }
}
