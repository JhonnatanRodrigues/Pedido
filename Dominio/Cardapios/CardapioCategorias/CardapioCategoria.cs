using Pedido.Dominio.Categorias;
using Pedido.Dominio.Padrao;

namespace Pedido.Dominio.Cardapios.CardapioCategorias
{
    public class CardapioCategoria : EntEmp
    {
        public int CodigoCardapio { get; set; }
        public int CodigoCategoria { get; set; }

        public Categoria Categoria { get; set; }
    }
}