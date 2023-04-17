using Pedido.Aplic.Cardapios;
using Pedido.Dominio.Cardapios.CardapioCategorias;
using Pedido.Dominio.Cardapios.CardapioCategorias.CardapioCategoriaProdutos;
using Pedido.Dominio.Categorias;
using Pedido.Dominio.Categorias.Produtos;
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
        }
    }
}
