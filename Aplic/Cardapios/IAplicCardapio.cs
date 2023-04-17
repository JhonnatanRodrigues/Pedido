using Pedido.Dominio.Cardapios.CardapioCategorias;
using Pedido.Dominio.Cardapios.CardapioCategorias.CardapioCategoriaProdutos;
using Pedido.Dominio.ImageUploads;

namespace Pedido.Aplic.Cardapios
{
    public interface IAplicCardapio
    {
        IQueryable<CardapioCategoria>? Listar();
        List<CardapioCategoria> ListarCategorias(int codigoCardapio);
        List<CardapioCategoriaProduto> ListarProdutosCategoria(int codigoCardapioCategoria);
        void VincularImagem(ImageUploadDto dto, string uriImage);
    }
}
