using Pedido.Dominio.Categorias.Produtos.ProdutoAdicionais;
using Pedido.Dominio.Padrao;

namespace Pedido.Dominio.Carrinhos.CarrinhoProdutos.CarrinhoProdutoAdicionais
{
    public class CarrinhoProdutoAdicional : EntEmp
    {
        public int CodigoCarrinhoProduto { get; set; }
        public int CodigoProdutoAdicional { get; set; }

        public CarrinhoProduto CarrinhoProduto { get; set; }
        public ProdutoAdicional ProdutoAdicional { get; set; }
    }
}
