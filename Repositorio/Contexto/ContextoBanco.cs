using Microsoft.EntityFrameworkCore;
using Pedido.Dominio.Cardapios.CardapioCategorias;
using Pedido.Dominio.Cardapios.CardapioCategorias.CardapioCategoriaItens;
using Pedido.Dominio.Categorias.Itens;
using Pedido.Repositorio.Config.Cardapios.CardapioCategorias;
using Pedido.Repositorio.Config.Cardapios.CardapioCategorias.CardapioCategoriaItens;
using Pedido.Repositorio.Config.Categorias;
using Pedido.Repositorio.Config.Categorias.Itens;

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
            modelBuilder.ApplyConfiguration(new CardapioCategoriaItemConfig());
            modelBuilder.ApplyConfiguration(new ItemConfig());
        }

        public DbSet<CardapioCategoria> CardapioCategorias { get; set; }
        public DbSet<CardapioCategoriaItem> CardapioCategoriaItems { get; set; }
        public DbSet<Item> Items { get; set; }
    }
}
