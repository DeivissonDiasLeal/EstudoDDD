using EstudoDDD.Domain.Entities;
using EstudoDDD.Infra.Data.EntityConfig;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoDDD.Infra.Data.Contexto
{
    public class ProjetoModeloContext : DbContext
    {
        public ProjetoModeloContext() : base("ProjetoModeloDDD")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties().Where(p => p.Name == p.PropertyType.Name + "Id").Configure(p => p.IsKey());
            modelBuilder.Properties<string>().Configure(p => p.HasColumnType("varchar"));
            modelBuilder.Properties<string>().Configure(p => p.HasMaxLength(100));

            modelBuilder.Configurations.Add(new ClienteConfiguration());
            modelBuilder.Configurations.Add(new ProdutoConfiguration());

            //base.OnModelCreating(modelBuilder);
        }

        public override int SaveChanges()
        {
            foreach (var entity in ChangeTracker.Entries().Where(entity => entity.Entity.GetType().GetProperty("dataCadastro")!=null))
            {
                if(entity.State == EntityState.Added)
                {
                    entity.Property("dataCadastro").CurrentValue = DateTime.Now;
                }

                if(entity.State == EntityState.Modified)
                {
                    entity.Property("dataCadastro").IsModified = false;
                }

            }

            return base.SaveChanges();
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Produto> Produtos { get; set; }


    }
}
