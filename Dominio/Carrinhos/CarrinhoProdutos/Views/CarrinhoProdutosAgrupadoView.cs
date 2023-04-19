namespace Pedido.Dominio.Carrinhos.CarrinhoProdutos.Views
{
    public class CarrinhoProdutosAgrupadoView
    {
        public int CodigoProdutoCarrinho { get; private set; }
        public string NomeProduto { get; private set; }
        public string? ImagemProdutoUri { get; private set; }
        public string? Observacao { get; private set; }
        public bool EntregarJuntoAoPedido { get; private set; }
        public decimal ValorTotal { get; private set; }

        public CarrinhoProdutosAgrupadoView NovoView(CarrinhoProduto carrinhoProduto)
        {
            return new CarrinhoProdutosAgrupadoView
            {
                CodigoProdutoCarrinho = carrinhoProduto.Id,
                NomeProduto = carrinhoProduto.Produto.NomeProduto,
                ImagemProdutoUri = carrinhoProduto.Produto.ImagemUri,
                Observacao = carrinhoProduto.Observacao,
                EntregarJuntoAoPedido = carrinhoProduto.EntregarJuntoAoPedido,
                ValorTotal = carrinhoProduto.ValorTotal
            };
        }
    }
}
