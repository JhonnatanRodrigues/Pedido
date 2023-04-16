using Pedido.Dominio.Cardapios.CardapioCategorias;
using Pedido.Dominio.Cardapios.CardapioCategorias.CardapioCategoriaItens;

namespace Pedido.Aplic.Cardapios
{
    public interface IAplicCardapio
    {
        IQueryable<CardapioCategoria>? Listar();
        List<CardapioCategoria> ListarCategorias(int codigoCardapio);
        List<CardapioCategoriaItem> ListarProdutosCategoria(int codigoCardapioCategoria);
    }
}
