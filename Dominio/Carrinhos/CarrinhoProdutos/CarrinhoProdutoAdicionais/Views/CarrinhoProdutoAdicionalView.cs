using Pedido.Dominio.Categorias.Produtos.ProdutoAdicionais.Views;

namespace Pedido.Dominio.Carrinhos.CarrinhoProdutos.CarrinhoProdutoAdicionais.Views
{
    public class CarrinhoProdutoAdicionalView
    {
        public int CodigoCarrinhoProdutoAdiciona { get; set; }
        public ProdutoAdicionalView ProdutoAdicional { get; set; }

        public CarrinhoProdutoAdicionalView NovoView(CarrinhoProdutoAdicional carrinhoProdutoAdicional)
        {
            if (carrinhoProdutoAdicional == null)
                return new CarrinhoProdutoAdicionalView();

            return new CarrinhoProdutoAdicionalView
            {
                CodigoCarrinhoProdutoAdiciona = carrinhoProdutoAdicional.Id,
                ProdutoAdicional = new ProdutoAdicionalView().NovoView(carrinhoProdutoAdicional.ProdutoAdicional)
            };
        }
    }
}
