using Pedido.Dominio.Categorias.Itens;
using Pedido.Dominio.Padrao;

namespace Pedido.Dominio.Cardapios.CardapioCategorias.CardapioCategoriaItens
{
    public class CardapioCategoriaItem : EntEmp
    {
        public int CodigoCardapioCategoria { get; set; }
        public int CodigoItem { get; set; }

        public CardapioCategoria CardapioCategoria { get; set; }
        public Item Produtos { get; set; }
    }
}
