using Pedido.Dominio.Adicionais;
using Pedido.Dominio.Padrao;

namespace Pedido.Dominio.Categorias.Produtos.ProdutoAdicionais
{
    public class ProdutoAdicional : EntEmp
    {
        public int CodigoProduto { get; set; }
        public int CodigoAdicional { get; set; }

        public Produto Produto { get; set; }
        public Adicional Adicional { get; set; }
    }
}
