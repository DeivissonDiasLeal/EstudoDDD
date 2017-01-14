using EstudoDDD.Application.Interfaces;
using EstudoDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EstudoDDD.Domain.Interfaces.Servicos;

namespace EstudoDDD.Application
{
    public class AppServiceProduto : AppServiceBase<Produto>, IAppServiceProduto
    {
        private readonly IServiceProduto _serviceProduto;

        public AppServiceProduto(IServiceProduto serviceProduto) : base(serviceProduto)
        {
            _serviceProduto = serviceProduto;
        }

        public IEnumerable<Produto> BuscarPorNome(string nome)
        {
            return _serviceProduto.BuscarPorNome(nome);
        }
    }
}
