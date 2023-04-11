using Microsoft.EntityFrameworkCore;
using Pedido.Dominio.Cardapios.CardapioCategorias;
using Pedido.Dominio.Categorias;
using Pedido.Repositorio.Config.Cardapios.CardapioCategorias;
using Pedido.Repositorio.Config.Categorias;

namespace Pedido.Repositorio.Contexto
{
    public class ContextoBanco : DbContext
    {
        public ContextoBanco(DbContextOptions options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CardapioCategoriaConfig());
            modelBuilder.ApplyConfiguration(new CategoriaConfig());
        }

        public DbSet<CardapioCategoria> CardapioCategoria { get; set; }
        public DbSet<Categoria> Categoria { get; set; }
    }
}
