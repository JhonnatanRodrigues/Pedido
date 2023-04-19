using Pedido.Dominio.Carrinhos.CarrinhoProdutos.CarrinhoProdutoAdicionais;
using Pedido.Dominio.Categorias.Produtos;
using Pedido.Dominio.Padrao;

namespace Pedido.Dominio.Carrinhos.CarrinhoProdutos
{
    public class CarrinhoProduto : EntEmp
    {
        public string? Observacao { get; set; }
        public bool EntregarJuntoAoPedido { get; set; }
        public decimal ValorTotal { get; set; }
        public int CodigoProduto { get; set; }
        public int CodigoCarrinho { get; set; }

        public Produto Produto { get; set; }
        public List<CarrinhoProdutoAdicional> CarrinhoProdutoAdicionais { get; set; }
        public Carrinho Carrinho { get; set; }
    }
}
