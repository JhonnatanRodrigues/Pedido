using Pedido.Dominio.Categorias.Produtos;
using Pedido.Dominio.Padrao;

namespace Pedido.Dominio.Cardapios.CardapioCategorias.CardapioCategoriaProdutos
{
    public class CardapioCategoriaProduto : EntEmp
    {
        public int CodigoCardapioCategoria { get; set; }
        public int CodigoProduto { get; set; }

        public CardapioCategoria CardapioCategoria { get; set; }
        public Produto Produtos { get; set; }
    }
}
