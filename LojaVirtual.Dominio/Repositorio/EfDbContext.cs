using LojaVirtual.Dominio.Entidade;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaVirtual.Dominio.Repositorio
{
    public class EfDbContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Remove a auto-pluralização das tabelas com os models
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            //Referencia a entidade produto a tabela produto, sem o uso da pluralização
            modelBuilder.Entity<Produto>().ToTable("Produtos");
        }
    }
}
