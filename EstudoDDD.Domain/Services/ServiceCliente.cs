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
    public class ServiceCliente : ServiceBase<Cliente>, IServiceCliente
    {
        private IRepositoryCliente _repositorioCliente;

        public ServiceCliente(IRepositoryCliente repositoryCliente) : base(repositoryCliente)
        {
            _repositorioCliente = repositoryCliente;
        }

        public IEnumerable<Cliente> ObterClientesEspeciais(IEnumerable<Cliente> clientes)
        {
            return clientes.Where(c => c.ClienteEspecial(c));
        }
    }
}
