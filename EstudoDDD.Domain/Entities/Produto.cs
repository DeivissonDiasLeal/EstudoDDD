using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoDDD.Domain.Entities
{
    public class Produto
    {
        public int produtoId { get; set; }
        public string nome { get; set; }
        public decimal preco { get; set; }
        public bool ativo { get; set; }
        public int clienteId { get; set; }

        public virtual Cliente Cliente { get; set; }
    }
}
