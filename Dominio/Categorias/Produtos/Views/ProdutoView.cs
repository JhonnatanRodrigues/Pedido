using Pedido.Dominio.Categorias.Views;

namespace Pedido.Dominio.Categorias.Produtos.Views
{
    public class ProdutoView
    {
        public int CodigoProduto { get; set; }
        public string NomeProduto { get; set; }
        public string? Descricao { get; set; }
        public string? ImagemUri { get; set; }
        public decimal Preco { get; set; }

        public CategoriaView Categoria { get; set; }

        public ProdutoView NovoView(Produto produto)
        {
            if(produto == null)
                return new ProdutoView();

            return new ProdutoView
            {
                CodigoProduto = produto.Id,
                NomeProduto = produto.NomeProduto,
                Descricao = produto.Descricao,
                ImagemUri = produto.ImagemUri,
                Preco = produto.Preco,
                Categoria = new CategoriaView().NovoView(produto.Categoria)
            };
        }
    }
}
