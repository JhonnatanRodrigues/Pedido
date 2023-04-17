using Pedido.Aplic.Cardapios;
using Pedido.Dominio.Adicionais;
using Pedido.Dominio.Cardapios.CardapioCategorias;
using Pedido.Dominio.Cardapios.CardapioCategorias.CardapioCategoriaProdutos;
using Pedido.Dominio.Carrinhos;
using Pedido.Dominio.Carrinhos.CarrinhoProdutos;
using Pedido.Dominio.Carrinhos.CarrinhoProdutos.CarrinhoProdutoAdicionais;
using Pedido.Dominio.Categorias;
using Pedido.Dominio.Categorias.Produtos;
using Pedido.Dominio.Categorias.Produtos.ProdutoAdicionais;
using Pedido.Repositorio.Repositorios;

namespace Pedido
{
    public class IDI
    {
        public void IdiAplic(WebApplicationBuilder builder)
        {
            builder.Services.AddScoped<IAplicCardapio, AplicCardapio>();
        }
        public void IdiRepositorio(WebApplicationBuilder builder)
        {

            builder.Services.AddScoped<IRepCardapioCategoria, RepCardapioCategoria>();
            builder.Services.AddScoped<IRepCardapioCategoriaProdutos, RepCardapioCategoriaProduto>();
            builder.Services.AddScoped<IRepProduto, RepProduto>();
            builder.Services.AddScoped<IRepCategoria, RepCategoria>();
            builder.Services.AddScoped<IRepAdicional, RepAdicional>();
            builder.Services.AddScoped<IRepProdutoAdicional, RepProdutoAdicional>();
            builder.Services.AddScoped<IRepCarrinho, RepCarrinho>();
            builder.Services.AddScoped<IRepCarrinhoProduto, RepCarrinhoProduto>();
            builder.Services.AddScoped<IRepCarrinhoProdutoAdicional, RepCarrinhoProdutoAdicional>();
        }
    }
}
