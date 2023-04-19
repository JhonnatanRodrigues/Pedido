using Pedido.Dominio.Adicionais.Views;
using Pedido.Dominio.Categorias.Produtos.Views;

namespace Pedido.Dominio.Categorias.Produtos.ProdutoAdicionais.Views
{
    public class ProdutoAdicionalView
    {
        public int CodigoProdutoAdicional { get; set; }

        public ProdutoView Produto { get; set; }
        public AdicionalView Adicional { get; set; }

        public ProdutoAdicionalView NovoView(ProdutoAdicional produtoAdicional)
        {
            if(produtoAdicional == null)
                return new ProdutoAdicionalView();

            return new ProdutoAdicionalView
            {
                CodigoProdutoAdicional = produtoAdicional.Id,
                Produto = new ProdutoView().NovoView(produtoAdicional.Produto),
                Adicional = new AdicionalView().NovoView(produtoAdicional.Adicional)
            };
        }
    }
}
