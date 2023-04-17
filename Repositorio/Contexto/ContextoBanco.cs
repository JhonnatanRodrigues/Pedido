using Microsoft.EntityFrameworkCore;
using Pedido.Dominio.Adicionais;
using Pedido.Dominio.Cardapios.CardapioCategorias;
using Pedido.Dominio.Cardapios.CardapioCategorias.CardapioCategoriaProdutos;
using Pedido.Dominio.Carrinhos;
using Pedido.Dominio.Carrinhos.CarrinhoProdutos;
using Pedido.Dominio.Carrinhos.CarrinhoProdutos.CarrinhoProdutoAdicionais;
using Pedido.Dominio.Categorias;
using Pedido.Dominio.Categorias.Produtos;
using Pedido.Dominio.Categorias.Produtos.ProdutoAdicionais;
using Pedido.Repositorio.Config.Adicionais;
using Pedido.Repositorio.Config.Cardapios.CardapioCategorias;
using Pedido.Repositorio.Config.Cardapios.CardapioCategorias.CardapioCategoriaProdutos;
using Pedido.Repositorio.Config.Carrinhos;
using Pedido.Repositorio.Config.Carrinhos.CarrinhoProdutos;
using Pedido.Repositorio.Config.Carrinhos.CarrinhoProdutos.CarrinhoProdutoAdicionais;
using Pedido.Repositorio.Config.Categorias;
using Pedido.Repositorio.Config.Categorias.Produtos;
using Pedido.Repositorio.Config.Categorias.Produtos.ProdutoAdicionais;

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
            modelBuilder.ApplyConfiguration(new CardapioCategoriaProdutoConfig());
            modelBuilder.ApplyConfiguration(new ProdutoConfig());
            modelBuilder.ApplyConfiguration(new AdicionalConfig());
            modelBuilder.ApplyConfiguration(new ProdutoAdicionalConfig());
            modelBuilder.ApplyConfiguration(new CarrinhoConfig());
            modelBuilder.ApplyConfiguration(new CarrinhoProdutoConfig());
            modelBuilder.ApplyConfiguration(new CarrinhoProdutoAdicionalConfig());
        }

        public DbSet<CardapioCategoria> CardapioCategorias { get; set; }
        public DbSet<CardapioCategoriaProduto> CardapioCategoriaProdutos { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Adicional> Adicionais { get; set; }
        public DbSet<ProdutoAdicional> ProdutoAdicionais { get; set; }
        public DbSet<Carrinho> Carrinhos { get; set; }
        public DbSet<CarrinhoProduto> CarrinhoProdutos { get; set; }
        public DbSet<CarrinhoProdutoAdicional> CarrinhoProdutoAdicionais { get; set; }
    }
}
