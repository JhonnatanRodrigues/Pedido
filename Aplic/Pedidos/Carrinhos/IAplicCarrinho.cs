using Pedido.Dominio.Carrinhos.CarrinhoProdutos.Views;

namespace Pedido.Aplic.Pedidos.Carrinhos
{
    public interface IAplicCarrinho
    {
        public List<CarrinhoProdutosAgrupadoView> ListarProdutosCarrinho(int codigoCarrinho);
        public List<CarrinhoProdutoView> ListarCarrinhoProduto(int codigoProdutoCarrinho);
    }
}
