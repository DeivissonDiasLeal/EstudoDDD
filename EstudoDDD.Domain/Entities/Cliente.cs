
using System;
using System.Collections.Generic;

namespace EstudoDDD.Domain.Entities
{
    public class Cliente
    {
        public int clienteId { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public string Email { get; set; }
        public DateTime dataCadastro { get; set; }
        public bool ativo { get; set; }

        public virtual IEnumerable<Produto> Produtos { get; set; }

        public bool ClienteEspecial(Cliente cliente)
        {
            return cliente.ativo && DateTime.Now.Year - cliente.dataCadastro.Year >= 5;
        }


    }
}
