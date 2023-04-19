using Pedido.Dominio.Carrinhos.CarrinhoProdutos.CarrinhoProdutoAdicionais;
using Pedido.Dominio.Carrinhos.CarrinhoProdutos.CarrinhoProdutoAdicionais.Views;
using Pedido.Dominio.Categorias.Produtos.Views;

namespace Pedido.Dominio.Carrinhos.CarrinhoProdutos.Views
{
    public class CarrinhoProdutoView
    {
        public int CodigoCarrinhoProduto { get; set; }
        public string? Observacao { get; set; }
        public bool EntregarJuntoAoPedido { get; set; }
        public decimal ValorTotal { get; set; }

        public ProdutoView Produto { get; set; }
        public List<CarrinhoProdutoAdicionalView> CarrinhoProdutoAdicionais { get; set; }

        public CarrinhoProdutoView NovoView(CarrinhoProduto carrinhoProduto)
        {
            var ret = new CarrinhoProdutoView();

            if (carrinhoProduto == null)
                return ret;

            ret = new CarrinhoProdutoView
            {
                CodigoCarrinhoProduto = carrinhoProduto.Id,
                Observacao = carrinhoProduto.Observacao,
                EntregarJuntoAoPedido = carrinhoProduto.EntregarJuntoAoPedido,
                ValorTotal = carrinhoProduto.ValorTotal,
                Produto = new ProdutoView().NovoView(carrinhoProduto.Produto),
            };

            foreach (var carrinhoProdutoAdicional in carrinhoProduto.CarrinhoProdutoAdicionais)
            {
                ret.CarrinhoProdutoAdicionais.Add(new CarrinhoProdutoAdicionalView().NovoView(carrinhoProdutoAdicional));
            }

            return ret;
        }
    }
}
