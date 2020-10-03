using DesafioLanche.Domain;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace DesafioLanche.Repository.Context
{
    public class DesafioLancheContext : DbContext
    {

        public DesafioLancheContext() : base("DesafioLancheDB")
        {
        }


        public DbSet<Ingrediente> Ingrediente { get; set; }
        public DbSet<Lanche> Lanche { get; set; }
        public DbSet<LancheXingrediente> LancheXingrediente { get; set; }
        public DbSet<Promocao> Promocao { get; set; }
        public DbSet<PromocaoXingrediente> PromocaoXingrediente { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Endereco> Enderereco { get; set; }
        public DbSet<Pedido> Pedido { get; set; }
        public DbSet<PedidoXlancheXingrediente> PedidoXlancheXingrediente { get; set; }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Add<OneToManyCascadeDeleteConvention>();

            base.OnModelCreating(modelBuilder);
        }
    }
}
