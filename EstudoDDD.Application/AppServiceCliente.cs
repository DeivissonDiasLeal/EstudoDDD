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
    public class AppServiceCliente : AppServiceBase<Cliente>, IAppServiceCliente
    {
        private readonly IServiceCliente _clienteService;

        public AppServiceCliente(IServiceCliente clienteService) : base(clienteService)
        {
            _clienteService = clienteService;
        }

        public IEnumerable<Cliente> ObterClientesEspeciais(IEnumerable<Cliente> clientes)
        {
            return _clienteService.ObterClientesEspeciais(_clienteService.GetAll());
        }
    }
}
