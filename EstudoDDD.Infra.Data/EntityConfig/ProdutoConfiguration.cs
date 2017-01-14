using EstudoDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoDDD.Infra.Data.EntityConfig
{
    public class ProdutoConfiguration : EntityTypeConfiguration<Produto>
    {
        public ProdutoConfiguration()
        {
            HasKey(p => p.produtoId);

            Property(p => p.nome).IsRequired();

            HasRequired(p => p.Cliente).WithMany().HasForeignKey(p => p.clienteId);
        }
    }
}
